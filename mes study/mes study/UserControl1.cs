using DotNetEnv;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mes_study
{
    public partial class UserControl1 : UserControl
    {
        private Supabase.Client supabase;
        private string supabaseUrl;
        private string supabaseKey;

        public event EventHandler button1Clicked;
        public UserControl1(Supabase.Client supabase)
        {
            InitializeComponent();
            this.supabase = supabase;

            // .env 로드 후 환경변수 읽기
            supabaseUrl = Environment.GetEnvironmentVariable("SUPABASE_URL");
            supabaseKey = Environment.GetEnvironmentVariable("SUPABASE_KEY");

            this.Load += UserControl1_Load;
            button2.Visible = false;
        }

        private async void UserControl1_Load(object sender, EventArgs e)
        {
            await LoadMaterialsAsync();
        }

        public async Task LoadMaterialsAsync()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", supabaseKey);
            client.DefaultRequestHeaders.Add("apikey", supabaseKey);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync("material?select=*");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var materials = JsonConvert.DeserializeObject<List<Material>>(json);

                listView1.Items.Clear();

                foreach (var m in materials)
                {
                    var item = new ListViewItem("");
                    item.SubItems.Add(m.name);
                    item.SubItems.Add(m.qty.ToString());
                    item.SubItems.Add(m.unit);
                    item.SubItems.Add(m.memo);
                    listView1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("데이터 불러오기 실패: " + await response.Content.ReadAsStringAsync());
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // 하나라도 체크된 게 있으면 보이게, 아니면 숨기게
            button2.Visible = listView1.CheckedItems.Count > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1Clicked?.Invoke(this, EventArgs.Empty);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
                return;
            }

            var result = MessageBox.Show(
                "정말 삭제하시겠습니까?",
                "삭제 확인",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (result != DialogResult.OK) return;

            // 여러 개 선택해도 일괄 삭제 처리
            foreach (ListViewItem item in listView1.CheckedItems)
            {
                string name = item.SubItems[1].Text; // name이 2번째 컬럼(0=빈칸)
                                                     // 또는 id 컬럼이 있다면 id로 삭제하는 것이 더 안전

                using var client = new HttpClient();
                client.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", supabaseKey);
                client.DefaultRequestHeaders.Add("apikey", supabaseKey);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // name이 unique라면 아래처럼 사용
                var response = await client.DeleteAsync($"material?name=eq.{name}");

                // id가 있다면 id=eq.{id}로!
                // var response = await client.DeleteAsync($"material?id=eq.{id}");

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"삭제 실패: {await response.Content.ReadAsStringAsync()}");
                }
            }

            // 삭제 후 리스트 새로고침
            await LoadMaterialsAsync();
        }
    }
}
