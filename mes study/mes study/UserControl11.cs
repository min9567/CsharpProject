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
    public partial class UserControl11 : UserControl
    {
        private Supabase.Client supabase;

        private string uuid;

        public UserControl11(Supabase.Client supabase, string uuid)
        {
            InitializeComponent();
            this.supabase = supabase;
            this.uuid = uuid;

            LoadEmployeeInfo(uuid);
        }

        private async void LoadEmployeeInfo(string uuid)
        {
            var supabaseUrl = Environment.GetEnvironmentVariable("SUPABASE_URL");
            var supabaseKey = Environment.GetEnvironmentVariable("SUPABASE_KEY");

            using var client = new HttpClient();
            client.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
            client.DefaultRequestHeaders.Add("apikey", supabaseKey);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // uuid로 직원 한 명만 조회
            var response = await client.GetAsync($"employees?user_id=eq.{uuid}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var employees = JsonConvert.DeserializeObject<List<MaterialUser>>(json);

                if (employees.Count > 0)
                {
                    var emp = employees[0];
                    label3.Text = emp.name ?? "";
                    label5.Text = emp.birth ?? "";
                    label7.Text = emp.username ?? "";
                    label9.Text = emp.phone ?? "";
                    label11.Text = emp.email ?? "";
                    label13.Text = emp.department ?? "";
                    label15.Text = emp.address ?? "";
                    label19.Text = emp.memo ?? "";
                }
                else
                {
                    MessageBox.Show("직원 정보를 찾을 수 없습니다.");
                }
            }
            else
            {
                MessageBox.Show("직원 정보 불러오기 실패: " + await response.Content.ReadAsStringAsync());
            }
        }
    }
}
