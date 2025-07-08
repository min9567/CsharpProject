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
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자와 백스페이스만 허용
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자와 백스페이스만 허용
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // 현재 커서 위치 기억
            int selStart = textBox3.SelectionStart;
            int oldLength = textBox3.Text.Length;

            // 숫자만 추출
            string onlyNum = new string(textBox3.Text.Where(char.IsDigit).ToArray());
            string formatted = onlyNum;

            if (onlyNum.Length <= 3)
                formatted = onlyNum;
            else if (onlyNum.Length <= 7)
                formatted = $"{onlyNum.Substring(0, 3)}-{onlyNum.Substring(3)}";
            else if (onlyNum.Length <= 10)
                formatted = $"{onlyNum.Substring(0, 3)}-{onlyNum.Substring(3, 3)}-{onlyNum.Substring(6)}";
            else if (onlyNum.Length >= 11)
                formatted = $"{onlyNum.Substring(0, 3)}-{onlyNum.Substring(3, 4)}-{onlyNum.Substring(7, 4)}";

            // 값이 다르면 갱신
            if (textBox3.Text != formatted)
            {
                textBox3.Text = formatted;
                // 바뀐 텍스트의 길이와 커서 위치 보정
                int diff = textBox3.Text.Length - oldLength;
                textBox3.SelectionStart = Math.Max(0, selStart + diff);
            }
        }


        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 한글 유니코드 범위만 막기 (특수문자/영문/숫자/기본키는 허용)
            if (e.KeyChar >= 0x3131 && e.KeyChar <= 0x318E) // 자음, 모음
                e.Handled = true;
            else if (e.KeyChar >= 0xAC00 && e.KeyChar <= 0xD7A3) // 완성형 한글
                e.Handled = true;
            // 나머지는 허용 (영문, 숫자, 특수문자, 백스페이스 등)
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 영문 대소문자, 숫자, 백스페이스만 허용
            if (!(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true; // 허용하지 않은 문자 입력 차단
                return;
            }

            // 한글 유니코드 차단(이전 방식, 참고용)
            if ((e.KeyChar >= 0x3131 && e.KeyChar <= 0x318E) ||
                (e.KeyChar >= 0xAC00 && e.KeyChar <= 0xD7A3))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 한글 유니코드 범위만 막기 (특수문자/영문/숫자/기본키는 허용)
            if (e.KeyChar >= 0x3131 && e.KeyChar <= 0x318E) // 자음, 모음
                e.Handled = true;
            else if (e.KeyChar >= 0xAC00 && e.KeyChar <= 0xD7A3) // 완성형 한글
                e.Handled = true;
            // 나머지는 허용 (영문, 숫자, 특수문자, 백스페이스 등)
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
            
            // employees 테이블에 저장할 데이터
            var empData = new
            {
                name = textBox1.Text,
                birth = textBox2.Text,
                phone = textBox3.Text,
                email = textBox4.Text,
                address = textBox5.Text,
                username = textBox6.Text,
                password = textBox7.Text,
                memo = textBox8.Text
            };

            // username 중복 체크
            using (var checkClient = new HttpClient())
            {
                checkClient.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
                checkClient.DefaultRequestHeaders.Clear();
                checkClient.DefaultRequestHeaders.Add("apikey", supabaseKey);
                checkClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);

                // employees?username=eq.{username} 쿼리로 중복 확인
                string url = $"employees?username=eq.{username}";
                var checkResponse = await checkClient.GetAsync(url);
                var checkResult = await checkResponse.Content.ReadAsStringAsync();

                // 결과가 []이면 중복 아님, [{...}]이면 중복
                if (checkResult.Trim() != "[]")
                {
                    MessageBox.Show("중복된 아이디입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


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
