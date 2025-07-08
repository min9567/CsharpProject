using DotNetEnv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;

namespace mes_study
{
    public partial class UserControl8 : UserControl
    {
        private Supabase.Client supabase;

        private string supabaseUrl;
        private string supabaseKey;

        public event EventHandler button1Clicked;
        public event EventHandler button2Clicked;

        public UserControl8(Supabase.Client supabase)
        {
            InitializeComponent();
            this.supabase = supabase;

            // .env 로드 후 환경변수 읽기
            supabaseUrl = Environment.GetEnvironmentVariable("SUPABASE_URL");
            supabaseKey = Environment.GetEnvironmentVariable("SUPABASE_KEY");

            button1.Visible = false;
            button2.Visible = false;
            button2.Visible = false;

            this.listView1.ItemChecked += listView1_ItemChecked;
        }

        private async void UserControl8_Load(object sender, EventArgs e)
        {
            await LoadEmployeesAsync();
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // 하나라도 체크된 게 있으면 보이게, 아니면 숨기게
            button1.Visible = listView1.CheckedItems.Count > 0;
            button2.Visible = listView1.CheckedItems.Count > 0;
            button3.Visible = listView1.CheckedItems.Count > 0;
        }

        public async Task LoadEmployeesAsync()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", supabaseKey);
            client.DefaultRequestHeaders.Add("apikey", supabaseKey);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync("employees?select=*");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var employees = JsonConvert.DeserializeObject<List<MaterialUser>>(json);

                listView1.Items.Clear();
                foreach (var emp in employees)
                {
                    var item = new ListViewItem("");
                    item.SubItems.Add(emp.name);
                    item.SubItems.Add(emp.username);
                    item.SubItems.Add(emp.birth);
                    item.SubItems.Add(emp.phone);
                    item.SubItems.Add("");
                    item.SubItems.Add(emp.created_at?.ToString("yyyy-MM-dd") ?? "");
                    item.Tag = emp.user_id;
                    listView1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("직원 목록 불러오기 실패: " + await response.Content.ReadAsStringAsync());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("수정할 항목을 선택하세요.");
                return;
            }
            if (listView1.CheckedItems.Count > 1)
            {
                MessageBox.Show("하나만 선택하세요.");
                return;
            }
            // uuid 컬럼 인덱스(예: 0번째 컬럼) 확인 필요
            string uuid = listView1.CheckedItems[0].Tag?.ToString();
            button2Clicked?.Invoke(uuid, EventArgs.Empty);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("초기화할 항목을 선택하세요.");
                return;
            }

            int successCount = 0, failCount = 0;

            foreach (ListViewItem item in listView1.CheckedItems)
            {
                string uuid = item.Tag?.ToString();
                string birth = item.SubItems[3].Text; // 컬럼 인덱스(생년월일 위치) 확인!

                if (string.IsNullOrEmpty(uuid) || string.IsNullOrEmpty(birth))
                {
                    failCount++;
                    continue;
                }

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
                    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    string url = $"employees?user_id=eq.{uuid}";
                    var body = JsonConvert.SerializeObject(new { password = birth });
                    var content = new StringContent(body, Encoding.UTF8, "application/json");

                    var response = await client.PatchAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {
                        successCount++;
                    }
                    else
                    {
                        failCount++;
                    }
                }
            }

            MessageBox.Show($"비밀번호 초기화 완료\n성공: {successCount}개, 실패: {failCount}개");
        }

    }
}
