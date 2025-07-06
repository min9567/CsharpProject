using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using DotNetEnv;

namespace mes_study
{
    public partial class UserControl2 : UserControl
    {
        // supabase 필드 선언
        private Supabase.Client supabase;
        public event EventHandler success;

        private string supabaseUrl;
        private string supabaseKey;

        // supabase를 생성자에서 받는 방식
        public UserControl2(Supabase.Client supabaseClient)
        {
            InitializeComponent();
            this.supabase = supabase;
        }

        // async 붙이기!
        private async void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string unit = textBox2.Text.Trim();
            string memo = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(unit))
            {
                MessageBox.Show("모든 항목을 입력하세요.");
                return;
            }

            var data = new
            {
                name = name,
                unit = unit,
                qty = 0,
                memo = memo
            };

            string json = JsonConvert.SerializeObject(data);

            var url = Environment.GetEnvironmentVariable("SUPABASE_URL");
            var key = Environment.GetEnvironmentVariable("SUPABASE_KEY");


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"{url}/rest/v1/");
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", key);
                client.DefaultRequestHeaders.Add("apikey", key);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("material", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("등록 완료!");
                    success?.Invoke(this, EventArgs.Empty);  // 등록 완료 신호 보내기
                }
                else
                    MessageBox.Show("오류: " + await response.Content.ReadAsStringAsync());
            }

        }

    }
}
