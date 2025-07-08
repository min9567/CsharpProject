using DotNetEnv;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace mes_study
{
    public partial class UserControl9 : UserControl
    {
        private Supabase.Client supabase;

        private string supabaseUrl;
        private string supabaseKey;

        private string selectedUuid;

        public event EventHandler EditCompleted;
        public event EventHandler canceled;

        public void SetUuid(string uuid)
        {
            this.selectedUuid = uuid;
        }

        public void FocusToTextBox()
        {
            textBox1.Focus();
        }

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

        public UserControl9(Supabase.Client supabase)
        {
            InitializeComponent();
            this.supabase = supabase;

            // .env 로드 후 환경변수 읽기
            supabaseUrl = Environment.GetEnvironmentVariable("SUPABASE_URL");
            supabaseKey = Environment.GetEnvironmentVariable("SUPABASE_KEY");

            label7.Visible = false;
            textBox7.Visible = false;
        }

        private async void UserControl9_Load(object sender, EventArgs e)
        {
            await LoadDepartmentsAsync();
            await LoadEmployeeDataAsync();
        }

        public async Task LoadEmployeeDataAsync()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", supabaseKey);
            client.DefaultRequestHeaders.Add("apikey", supabaseKey);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // uuid로 1건 조회
            var response = await client.GetAsync($"employees?user_id=eq.{selectedUuid}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var employees = JsonConvert.DeserializeObject<List<MaterialUser>>(json);
                if (employees.Count > 0)
                {
                    var emp = employees[0];
                    textBox1.Text = emp.name;
                    textBox2.Text = emp.birth;
                    textBox3.Text = emp.phone;
                    textBox4.Text = emp.email;
                    textBox5.Text = emp.address;
                    textBox6.Text = emp.username;
                    textBox6.ReadOnly = true;
                    textBox8.Text = emp.memo;
                }
                else
                {
                    MessageBox.Show("해당 uuid의 직원 정보가 없습니다.");
                }
            }
            else
            {
                MessageBox.Show("직원 정보 불러오기 실패: " + await response.Content.ReadAsStringAsync());
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedUuid))
            {
                MessageBox.Show("유효하지 않은 uuid입니다.");
                return;
            }

            string username = textBox6.Text.Trim();

            // **username 중복 체크**
            using (var checkClient = new HttpClient())
            {
                checkClient.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
                checkClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
                checkClient.DefaultRequestHeaders.Add("apikey", supabaseKey);
                checkClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // 현재 uuid가 아닌, 동일 username이 있으면 중복!
                var checkResponse = await checkClient.GetAsync($"employees?username=eq.{username}&user_id=neq.{selectedUuid}");
                var checkJson = await checkResponse.Content.ReadAsStringAsync();
                var exists = JsonConvert.DeserializeObject<List<MaterialUser>>(checkJson);

                if (exists.Count > 0)
                {
                    MessageBox.Show("이미 사용중인 아이디(username)입니다.");
                    return;
                }
            }

            // 1. employees 정보 수정
            var empPatch = new[]
            {
                new
                 {
                    name = textBox1.Text.Trim(),
                    birth = textBox2.Text.Trim(),
                    phone = textBox3.Text.Trim(),
                    email = textBox4.Text.Trim(),
                    address = textBox5.Text.Trim(),
                    username = textBox6.Text.Trim(),
                    memo = textBox8.Text.Trim()
                }
            };
            var empJson = JsonConvert.SerializeObject(empPatch);

            using (var empClient = new HttpClient())
            {
                empClient.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
                empClient.DefaultRequestHeaders.Clear();
                empClient.DefaultRequestHeaders.Add("apikey", supabaseKey);
                empClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
                empClient.DefaultRequestHeaders.Remove("Prefer");
                empClient.DefaultRequestHeaders.Add("Prefer", "return=representation"); // PATCH 필수

                var empContent = new StringContent(empJson, Encoding.UTF8, "application/json");
                var empResp = await empClient.PatchAsync($"employees?user_id=eq.{selectedUuid}", empContent);

                if (!empResp.IsSuccessStatusCode)
                {
                    MessageBox.Show("employees 수정 실패: " + await empResp.Content.ReadAsStringAsync());
                    return;
                }
            }
            MessageBox.Show("수정 완료!");
            EditCompleted?.Invoke(this, EventArgs.Empty);
        }

        private async Task LoadDepartmentsAsync()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", supabaseKey);
            client.DefaultRequestHeaders.Add("apikey", supabaseKey);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // departments 목록 조회
            var response = await client.GetAsync("departments?select=name,id"); // id는 옵션
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var departments = JsonConvert.DeserializeObject<List<DepartmentsList>>(json);

                comboBox1.Items.Clear();
                foreach (var dept in departments)
                {
                    comboBox1.Items.Add(dept.name);
                    // 또는 id까지 쓰고 싶으면 comboBox1.Items.Add($"{dept.id} - {dept.name}");
                }
            }
            else
            {
                MessageBox.Show("부서 목록 불러오기 실패: " + await response.Content.ReadAsStringAsync());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            canceled?.Invoke(this, EventArgs.Empty);
        }
    }
}
