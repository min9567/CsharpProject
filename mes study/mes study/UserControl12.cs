using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mes_study
{
    public partial class UserControl12 : UserControl
    {
        public event EventHandler success;
        public event EventHandler canceled;

        public void FocusTextBox()
        {
            textBox1.Focus();
        }

        public UserControl12(Supabase.Client supabase)
        {
            InitializeComponent();
        }

        public void ClearInputs()
        {
            textBox1.Text = "";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string departmentName = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(departmentName))
            {
                MessageBox.Show("부서명을 입력하세요.");
                return;
            }

            var supabaseUrl = Environment.GetEnvironmentVariable("SUPABASE_URL");
            var supabaseKey = Environment.GetEnvironmentVariable("SUPABASE_KEY");

            var body = JsonConvert.SerializeObject(new { name = departmentName });

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
                client.DefaultRequestHeaders.Add("apikey", supabaseKey);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var content = new StringContent(body, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("departments", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("부서 등록 성공!");
                    textBox1.Text = "";
                    success?.Invoke(this, EventArgs.Empty);  // 등록 완료 신호 보내기
                }
                else
                {
                    MessageBox.Show("등록 실패: " + await response.Content.ReadAsStringAsync());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            canceled?.Invoke(this, EventArgs.Empty);
        }
    }
}
