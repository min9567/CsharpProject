using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace mes_study
{
    public partial class UserControl4 : UserControl
    {
        public event EventHandler success;
        public UserControl4(Supabase.Client supabase)
        {
            InitializeComponent();
            this.Load += UserControl4_Load; // 로드시 데이터 불러옴
            textBox2.KeyPress += textBox2_KeyPress;
        }

        private async void UserControl4_Load(object sender, EventArgs e)
        {
            await LoadMaterialNamesAsync();
        }

        private async Task LoadMaterialNamesAsync()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri("https://qretxetswugkrlqhjwyn.supabase.co/rest/v1/");
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InFyZXR4ZXRzd3Vna3JscWhqd3luIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTE2MzI2NTcsImV4cCI6MjA2NzIwODY1N30.EeuiZ1OZHnm1jjpmAOErALdDNPtB4Q18uZo9Lp0da9w");
            client.DefaultRequestHeaders.Add("apikey", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InFyZXR4ZXRzd3Vna3JscWhqd3luIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTE2MzI2NTcsImV4cCI6MjA2NzIwODY1N30.EeuiZ1OZHnm1jjpmAOErALdDNPtB4Q18uZo9Lp0da9w");
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
            client.BaseAddress = new Uri("https://qretxetswugkrlqhjwyn.supabase.co/rest/v1/");
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InFyZXR4ZXRzd3Vna3JscWhqd3luIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTE2MzI2NTcsImV4cCI6MjA2NzIwODY1N30.EeuiZ1OZHnm1jjpmAOErALdDNPtB4Q18uZo9Lp0da9w");
            client.DefaultRequestHeaders.Add("apikey", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InFyZXR4ZXRzd3Vna3JscWhqd3luIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTE2MzI2NTcsImV4cCI6MjA2NzIwODY1N30.EeuiZ1OZHnm1jjpmAOErALdDNPtB4Q18uZo9Lp0da9w");
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
            int newQty = material.qty - addQty;
            string memo = textBox3.Text.Trim();

            // 4. qty 업데이트 (PATCH)
            var patch = new[]
            {
        new { qty = newQty, issuememo = memo }
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
            }
            else
            {
                MessageBox.Show("수량 변경 실패: " + await updateResponse.Content.ReadAsStringAsync());
            }
        }
    }
}
