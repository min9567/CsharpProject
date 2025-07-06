namespace mes_study;

public partial class Form1 : Form
{
    // 1. 클래스 필드로 supabase 선언
    private Supabase.Client supabase;
    private UserControl1 uc1;
    private UserControl2 uc2;
    private UserControl3 uc3;
    private UserControl4 uc4;

    public Form1()
    {
        InitializeComponent();
        this.Load += Form1_Load; // Load 이벤트 연결 (디자이너에서 이미 연결되어 있으면 생략 가능)

    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        var supabaseUrl = "https://qretxetswugkrlqhjwyn.supabase.co";
        var supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InFyZXR4ZXRzd3Vna3JscWhqd3luIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTE2MzI2NTcsImV4cCI6MjA2NzIwODY1N30.EeuiZ1OZHnm1jjpmAOErALdDNPtB4Q18uZo9Lp0da9w";
        supabase = new Supabase.Client(supabaseUrl, supabaseKey);
        await supabase.InitializeAsync();

        uc1 = new UserControl1(supabase);
        uc2 = new UserControl2(supabase);
        uc3 = new UserControl3(supabase);
        uc4 = new UserControl4(supabase);

        uc1.button1Clicked += Uc1_button1Clicked;
        uc2.success += async (s, e) =>
        {
            // uc1이 UserControl1 인스턴스일 때,
            await uc1.LoadMaterialsAsync(); // public async Task LoadMaterialsAsync()
            panel1.Controls.Clear();
            panel1.Controls.Add(uc1);
            uc1.Dock = DockStyle.Fill;
        };
    }
    private void Uc1_button1Clicked(object sender, EventArgs e)
    {
        panel1.Controls.Clear();
        panel1.Controls.Add(uc2);
        uc2.Dock = DockStyle.Fill;
    }

    private void 내역ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        panel1.Controls.Clear();
        panel1.Controls.Add(uc1);  // uc1이 UserControl1
        uc1.Dock = DockStyle.Fill;
    }

    private void 입고ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        panel1.Controls.Clear();
        panel1.Controls.Add(uc3);
        uc3.Dock = DockStyle.Fill;
    }

    private void 출고ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        panel1.Controls.Clear();
        panel1.Controls.Add(uc4);
        uc4.Dock = DockStyle.Fill;
    }
}


