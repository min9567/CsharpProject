using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace mes_study
{
    public partial class UserControl2 : UserControl
    {
        // supabase 필드 선언
        private Supabase.Client supabase;

        // supabase를 생성자에서 받는 방식
        public UserControl2(Supabase.Client supabaseClient)
        {
            InitializeComponent();
            this.supabase = supabaseClient;
        }

        // async 붙이기!
        private async void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string unit = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(unit))
            {
                MessageBox.Show("모든 항목을 입력하세요.");
                return;
            }

            var data = new
            {
                name = name,
                unit = unit,
                qty = 0
            };

            string json = JsonConvert.SerializeObject(data);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://qretxetswugkrlqhjwyn.supabase.co/rest/v1/");
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InFyZXR4ZXRzd3Vna3JscWhqd3luIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTE2MzI2NTcsImV4cCI6MjA2NzIwODY1N30.EeuiZ1OZHnm1jjpmAOErALdDNPtB4Q18uZo9Lp0da9w");
                client.DefaultRequestHeaders.Add("apikey", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InFyZXR4ZXRzd3Vna3JscWhqd3luIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTE2MzI2NTcsImV4cCI6MjA2NzIwODY1N30.EeuiZ1OZHnm1jjpmAOErALdDNPtB4Q18uZo9Lp0da9w");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("material", content);

                if (response.IsSuccessStatusCode)
                    MessageBox.Show("등록 완료!");
                else
                    MessageBox.Show("오류: " + await response.Content.ReadAsStringAsync());
            }
        }

    }
}
