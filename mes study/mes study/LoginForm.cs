using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetEnv;

namespace mes_study
{
    public partial class LoginForm : Form
    {
        private Supabase.Client supabase;
        public string SupabaseUrl { get; private set; }
        public string SupabaseKey { get; private set; }

        public LoginForm()
        {
            Env.Load(".env.txt");
            InitializeComponent();

           textBox1.Text = "test";
           textBox2.Text = "111111";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 한글 유니코드 범위만 막기 (특수문자/영문/숫자/기본키는 허용)
            if (e.KeyChar >= 0x3131 && e.KeyChar <= 0x318E) // 자음, 모음
                e.Handled = true;
            else if (e.KeyChar >= 0xAC00 && e.KeyChar <= 0xD7A3) // 완성형 한글
                e.Handled = true;
            // 나머지는 허용 (영문, 숫자, 특수문자, 백스페이스 등)
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("아이디와 비밀번호를 모두 입력하세요.");
                return;
            }

            // 1. employees에서 email 조회
            var supabaseUrl = Environment.GetEnvironmentVariable("SUPABASE_URL");
            var supabaseKey = Environment.GetEnvironmentVariable("SUPABASE_KEY");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", supabaseKey);
                client.DefaultRequestHeaders.Add("apikey", supabaseKey);

                var resp = await client.GetAsync($"employees?username=eq.{username}");
                if (resp.IsSuccessStatusCode)
                {
                    var json = await resp.Content.ReadAsStringAsync();
                    var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MaterialUser>>(json);
                    if (list.Count == 0)
                    {
                        MessageBox.Show("존재하지 않는 아이디입니다.");
                        return;
                    }

                    // 2. username은 있음 → password 비교
                    var emp = list[0];
                    if (emp.password != password)
                    {
                        MessageBox.Show("비밀번호가 틀립니다.");
                        return;
                    }

                    // 비밀번호가 생년월일과 같으면 비밀번호 변경 UserControl 띄우기
                    if (emp.password == emp.birth)
                    {
                        loginpanel.Visible = false;

                        var changePwCtrl = new UserControl10(emp.user_id);
                        changePwCtrl.Dock = DockStyle.Fill;

                        changePwCtrl.OnPasswordChanged += (s, args) =>
                        {
                            this.Controls.Remove(changePwCtrl);
                            loginpanel.Visible = true;
                            MessageBox.Show("비밀번호가 변경되었습니다. 다시 로그인 해주세요.");
                            textBox1.Text = "";
                            textBox2.Text = "";
                        };

                        changePwCtrl.OnCancel += (s, args) =>
                        {
                            this.Controls.Remove(changePwCtrl);  // 유저컨트롤 제거
                            loginpanel.Visible = true;           // 로그인 패널 다시 노출
                            textBox2.Text = "";
                        };

                        this.Controls.Add(changePwCtrl);

                        return; // 이하 로그인 로직 중단
                    }

                    SessionInfo.UserUuid = emp.user_id;

                    this.SupabaseUrl = supabaseUrl;
                    this.SupabaseKey = supabaseKey;
                    this.DialogResult = DialogResult.OK; // → Program.cs에서 Application.Run(new Form1()) 실행됨
                    this.Close();
                }
                else
                {
                    MessageBox.Show("서버 오류: " + await resp.Content.ReadAsStringAsync());
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
