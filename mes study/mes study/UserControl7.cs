using DotNetEnv;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace mes_study
{
    public partial class UserControl7 : UserControl
    {
        public event EventHandler success;

        private string supabaseUrl;
        private string supabaseKey;

        public void ClearInputs()
        {
            comboBox1.SelectedIndex = -1;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        public void FocusToComboBox()
        {
            textBox1.Focus();
        }

        public UserControl7(Supabase.Client supabase)
        {
            InitializeComponent();
            supabaseUrl = Environment.GetEnvironmentVariable("SUPABASE_URL");
            supabaseKey = Environment.GetEnvironmentVariable("SUPABASE_KEY");
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // 1. 이메일, 패스워드 등 입력값 먼저 트림/검증
            string name = textBox1.Text.Trim();
            string birth = textBox2.Text.Trim();       // Date 변환 필요시 별도 처리
            string phone = textBox3.Text.Trim();
            string address = textBox5.Text.Trim();
            string username = textBox6.Text.Trim();
            string memo = textBox8.Text.Trim();
            string email = textBox4.Text.Trim();
            string password = textBox7.Text.Trim();

            if (!IsValidEmail(email))
            {
                MessageBox.Show("이메일 형식을 확인하세요.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            {
                MessageBox.Show("비밀번호는 6자 이상이어야 합니다.");
                return;
            }
            string uuid = "";
            var signupData = new
            {
                email = textBox4.Text,
                password = textBox7.Text
            };
            string signupJson = JsonConvert.SerializeObject(signupData);

            using (var signupClient = new HttpClient())
            {
                signupClient.BaseAddress = new Uri($"{supabaseUrl}/auth/v1/");
                signupClient.DefaultRequestHeaders.Clear();
                signupClient.DefaultRequestHeaders.Add("apikey", supabaseKey);
                signupClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var signupContent = new StringContent(signupJson, Encoding.UTF8, "application/json");
                var signupResponse = await signupClient.PostAsync("signup", signupContent);

                string responseBody = await signupResponse.Content.ReadAsStringAsync();

                if (!signupResponse.IsSuccessStatusCode)
                {
                    dynamic errorJson = JsonConvert.DeserializeObject(responseBody);
                    string code = errorJson.code;

                    if (code == "429")
                    {
                        MessageBox.Show("같은 이메일로 인증이 잦아 추후 다시 시도해주세요.");
                    }
                    else if (code == "22008")
                    {
                        MessageBox.Show("생년월일 날짜 형식이 올바르지 않습니다.");
                    }
                    else
                    {
                        MessageBox.Show("회원가입 실패: " + responseBody);
                    }
                    return;
                }

                var signupResult = JsonConvert.DeserializeObject<dynamic>(responseBody);
                uuid = signupResult.id; // auth.users의 id (uuid)
                                        // uuid가 제대로 파싱되는지 반드시 체크
                if (string.IsNullOrWhiteSpace(uuid))
                {
                    MessageBox.Show("auth.users id 값을 찾을 수 없습니다.");
                    return;
                }
            }

            // employees 테이블에 저장할 데이터
            var empData = new
            {
                user_id = uuid,
                name = textBox1.Text,
                birth = textBox2.Text,
                phone = textBox3.Text,
                email = textBox4.Text,
                address = textBox5.Text,
                username = textBox6.Text,
                memo = textBox8.Text
            };

            // 직원 정보 등록 요청 (employees)
            using (var empClient = new HttpClient())
            {
                empClient.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
                empClient.DefaultRequestHeaders.Clear();
                empClient.DefaultRequestHeaders.Add("apikey", supabaseKey);
                empClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);

                var empJson = JsonConvert.SerializeObject(empData);
                var empContent = new StringContent(empJson, Encoding.UTF8, "application/json");
                var empResponse = await empClient.PostAsync("employees", empContent);

                if (empResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("직원 등록 성공!");
                    ClearInputs(); // ← 등록 성공시 입력값 초기화
                }
                else
                {
                    MessageBox.Show("직원정보 저장 실패: " + await empResponse.Content.ReadAsStringAsync());
                }
            }
        }
    }
}
