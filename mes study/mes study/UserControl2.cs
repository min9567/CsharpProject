using DotNetEnv;
using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mes_study
{
    public partial class UserControl2 : UserControl
    {
        // supabase 필드 선언
        private Supabase.Client supabase;
        public event EventHandler success;

        private string supabaseUrl;
        private string supabaseKey;

        public void ClearInputs()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        public void FocusToComboBox()
        {
            textBox1.Focus();
        }

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

            var url = Environment.GetEnvironmentVariable("SUPABASE_URL");
            var key = Environment.GetEnvironmentVariable("SUPABASE_KEY");


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"{url}/rest/v1/");
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", key);
                client.DefaultRequestHeaders.Add("apikey", key);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // 1. 등록 전, 같은 name이 있는지 조회
                var checkResponse = await client.GetAsync($"material?name=eq.{name}");
                if (checkResponse.IsSuccessStatusCode)
                {
                    var checkJson = await checkResponse.Content.ReadAsStringAsync();
                    // material 테이블에서 name이 이미 존재하는지 체크
                    var exists = checkJson.Contains(name); // 매우 단순 체크(확실하게 하려면 JSON 파싱 필요)
                    if (!string.IsNullOrEmpty(checkJson) && checkJson != "[]")
                    {
                        MessageBox.Show("이미 등록된 품명입니다.");
                        return;
                    }
                }

                // 2. 등록 진행
                var data = new
                {
                    name = name,
                    unit = unit,
                    qty = 0,
                    memo = memo
                };

                string json = JsonConvert.SerializeObject(data);

                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("material", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("등록 완료!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    success?.Invoke(this, EventArgs.Empty);  // 등록 완료 신호 보내기
                }
                else
                    MessageBox.Show("오류: " + await response.Content.ReadAsStringAsync());
            }

        }

    }
}
