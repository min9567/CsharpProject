using System;
using System.Text;
using System.Windows.Forms;

namespace mes_study
{
    public partial class UserControl10 : UserControl
    {
        public event EventHandler OnPasswordChanged;
        public event EventHandler OnCancel;

        private string userId;

        public UserControl10(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private async void button1_Click(object sender, EventArgs e) // 변경 버튼
        {
            string newPw = textBox1.Text.Trim();      // 변경할 비밀번호
            string confirmPw = textBox2.Text.Trim();  // 재확인

            if (string.IsNullOrEmpty(newPw) || newPw.Length < 6)
            {
                MessageBox.Show("새 비밀번호는 6자 이상 입력하세요.");
                return;
            }
            if (newPw != confirmPw)
            {
                MessageBox.Show("비밀번호 확인이 일치하지 않습니다.");
                return;
            }

            var supabaseUrl = Environment.GetEnvironmentVariable("SUPABASE_URL");
            var supabaseKey = Environment.GetEnvironmentVariable("SUPABASE_KEY");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", supabaseKey);
                client.DefaultRequestHeaders.Add("apikey", supabaseKey);

                var body = Newtonsoft.Json.JsonConvert.SerializeObject(new { password = newPw });
                var content = new StringContent(body, Encoding.UTF8, "application/json");
                var response = await client.PatchAsync($"employees?user_id=eq.{userId}", content);

                if (response.IsSuccessStatusCode)
                {
                    OnPasswordChanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("비밀번호 변경 실패: " + await response.Content.ReadAsStringAsync());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // 취소 버튼
        {
            OnCancel?.Invoke(this, EventArgs.Empty);
        }
    }
}
