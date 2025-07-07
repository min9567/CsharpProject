using DotNetEnv;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mes_study
{
    public partial class UserControl3 : UserControl
    {
        public event EventHandler success;

        private string supabaseUrl;
        private string supabaseKey;

        public void ClearInputs()
        {
            comboBox1.SelectedIndex = -1;
            textBox2.Text = "";
            textBox3.Text = "";
        }
        public void FocusToComboBox()
        {
            comboBox1.Focus();
        }

        public UserControl3(Supabase.Client supabase)
        {
            InitializeComponent();
            this.Load += UserControl3_Load; // 로드시 데이터 불러옴
            textBox2.KeyPress += textBox2_KeyPress;

            supabaseUrl = Environment.GetEnvironmentVariable("SUPABASE_URL");
            supabaseKey = Environment.GetEnvironmentVariable("SUPABASE_KEY");
        }

        private async void UserControl3_Load(object sender, EventArgs e)
        {
            await LoadMaterialNamesAsync();
        }

        public async Task LoadMaterialNamesAsync()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", supabaseKey);
            client.DefaultRequestHeaders.Add("apikey", supabaseKey);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync("material?select=name");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var materials = JsonConvert.DeserializeObject<List<Material>>(json);

                comboBox1.Items.Clear();
                foreach (var m in materials)
                {
                    comboBox1.Items.Add(m.name);
                }
            }
            else
            {
                MessageBox.Show("데이터 불러오기 실패: " + await response.Content.ReadAsStringAsync());
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자와 백스페이스만 입력 허용
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // 1. ComboBox에서 선택한 name
            var name = comboBox1.SelectedItem?.ToString();


            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("품목을 선택하세요.");
                return;
            }

            // 2. textbox2에 입력된 숫자값
            if (!int.TryParse(textBox2.Text, out int addQty))
            {
                MessageBox.Show("수량을 입력하세요.");
                return;
            }

            // 3. 기존 qty 조회 (GET)
            using var client = new HttpClient();
            client.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", supabaseKey);
            client.DefaultRequestHeaders.Add("apikey", supabaseKey);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // 해당 품목의 qty 조회
            var response = await client.GetAsync($"material?name=eq.{name}");

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("품목 조회 실패");
                return;
            }

            var json = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<Material>>(json);

            if (list.Count == 0)
            {
                MessageBox.Show("해당 품목이 없습니다.");
                return;
            }

            var material = list[0];
            int newQty = material.qty + addQty;
            string memo = textBox3.Text.Trim();

            // 4. qty 업데이트 (PATCH)
            var patch = new[]
            {
        new { qty = newQty, receivingmemo = memo }
    };
            var content = new StringContent(JsonConvert.SerializeObject(patch), Encoding.UTF8, "application/json");
            // Patch 사용시 반드시 'Prefer: return=representation' 헤더 필요
            client.DefaultRequestHeaders.Remove("Prefer");
            client.DefaultRequestHeaders.Add("Prefer", "return=representation");

            var updateResponse = await client.PatchAsync($"material?name=eq.{name}", content);

            if (updateResponse.IsSuccessStatusCode)
            {
                MessageBox.Show($"수량이 {material.qty} → {newQty}로 변경되었습니다.");
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.SelectedIndex = -1;
                success?.Invoke(this, EventArgs.Empty);
                FocusToComboBox();

                var materialListData = new
                {
                    uuid = material.uuid,                  // material에서 uuid 컬럼 가져오기 (material 클래스에 uuid 추가 필요)
                    name = name,                  // 품목명
                    qty_in = addQty,                       // 입고수량 (추가된 값)
                    qty_out = 0,                           // 출고시에는 0, 입고이므로
                    qty_result = newQty,                   // 최종 수량
                    registrant = "",              // 로그인 사용자 등에서 가져와서 입력
                    memo = memo                            // 메모
                };
                var materialListContent = new StringContent(JsonConvert.SerializeObject(materialListData), Encoding.UTF8, "application/json");
                // materialList용 POST
                var listResponse = await client.PostAsync("materiallist", materialListContent);
                if (!listResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("materialList 저장 실패: " + await listResponse.Content.ReadAsStringAsync());
                }
            }
            else
            {
                MessageBox.Show("수량 변경 실패: " + await updateResponse.Content.ReadAsStringAsync());
            }
        }
        private void UserControl3_Load_1(object sender, EventArgs e)
        {

        }
    }
}
