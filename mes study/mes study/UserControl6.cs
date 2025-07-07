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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mes_study
{
    public partial class UserControl6 : UserControl
    {
        private Supabase.Client supabase;

        private string supabaseUrl;
        private string supabaseKey;

        private string selectedUuid;
        public void SetUuid(string uuid)
        {
            selectedUuid = uuid;
        }
        public UserControl6(Supabase.Client supabase)
        {
            InitializeComponent();
            this.supabase = supabase;

            supabaseUrl = Environment.GetEnvironmentVariable("SUPABASE_URL");
            supabaseKey = Environment.GetEnvironmentVariable("SUPABASE_KEY");

        }

        private async void UserControl6_Load(object sender, EventArgs e)
        {
            await LoadMaterialsAsync();
        }

        public async Task LoadMaterialsAsync()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", supabaseKey);
            client.DefaultRequestHeaders.Add("apikey", supabaseKey);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            System.Diagnostics.Debug.WriteLine("uuid: " + selectedUuid);

            if (string.IsNullOrEmpty(selectedUuid))
            {
                MessageBox.Show("uuid가 없습니다.");
                return;
            }

            // uuid로 1건 조회
            var response = await client.GetAsync($"material?uuid=eq.{selectedUuid}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var materials = JsonConvert.DeserializeObject<List<Material>>(json);

                if (materials.Count > 0)
                {
                    var m = materials[0];
                    textBox3.Text = m.memo ?? "";  // memo값 textbox3에 미리 세팅
                }
                else
                {
                    MessageBox.Show("해당 uuid의 데이터가 없습니다.");
                }
            }
            else
            {
                MessageBox.Show("데이터 불러오기 실패: " + await response.Content.ReadAsStringAsync());
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedUuid))
            {
                MessageBox.Show("uuid가 없습니다.");
                return;
            }

            string newMemo = textBox3.Text.Trim();

            using var client = new HttpClient();
            client.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", supabaseKey);
            client.DefaultRequestHeaders.Add("apikey", supabaseKey);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Remove("Prefer");
            client.DefaultRequestHeaders.Add("Prefer", "return=representation"); // PATCH 필수

            // 수정할 데이터
            var patch = new[] { new { memo = newMemo } };
            var content = new StringContent(JsonConvert.SerializeObject(patch), Encoding.UTF8, "application/json");

            var response = await client.PatchAsync($"material?uuid=eq.{selectedUuid}", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("비고가 성공적으로 수정되었습니다.");
                textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("비고 수정 실패: " + await response.Content.ReadAsStringAsync());
            }
        }
    }
}
