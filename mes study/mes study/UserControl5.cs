using DotNetEnv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace mes_study
{
    public partial class UserControl5 : UserControl
    {
        private Supabase.Client supabase;
        private string supabaseUrl;
        private string supabaseKey;

        private string selectedUuid;
        public void SetUuid(string uuid)
        {
            selectedUuid = uuid;
        }

        public UserControl5(Supabase.Client supabase)
        {
            InitializeComponent();
            this.supabase = supabase;

            supabaseUrl = Environment.GetEnvironmentVariable("SUPABASE_URL");
            supabaseKey = Environment.GetEnvironmentVariable("SUPABASE_KEY");

            this.Load += UserControl5_Load; // Load 이벤트 연결
        }

        private async void UserControl5_Load(object sender, EventArgs e)
        {
            await LoadMaterialListAsync();
        }

        public async Task LoadMaterialListAsync()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri($"{supabaseUrl}/rest/v1/");
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", supabaseKey);
            client.DefaultRequestHeaders.Add("apikey", supabaseKey);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // ★ uuid 필터 적용 부분
            string url = string.IsNullOrEmpty(selectedUuid)
            ? "materiallist?select=*"
            : $"materiallist?uuid=eq.{selectedUuid}&select=*";

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<MaterialList>>(json);

                listView1.Items.Clear();

                foreach (var item in list)
                {
                    var lv = new ListViewItem();
                    lv.SubItems.Add(item.name);
                    lv.SubItems.Add(item.qty_in.ToString());
                    lv.SubItems.Add(item.qty_out.ToString());
                    lv.SubItems.Add(item.qty_result.ToString());
                    lv.SubItems.Add(item.registrant);
                    lv.SubItems.Add(item.created_at?.ToString("yyyy-MM-dd HH:mm:ss") ?? "");
                    lv.SubItems.Add(item.memo ?? "");
                    listView1.Items.Add(lv);
                }
            }
            else
            {
                MessageBox.Show("materiallist 불러오기 실패: " + await response.Content.ReadAsStringAsync());
            }
        }

    }
}
