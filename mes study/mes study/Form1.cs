namespace mes_study;

public partial class Form1 : Form
{
    // 1. Ŭ���� �ʵ�� supabase ����
    private Supabase.Client supabase;
    private UserControl1 uc1;
    private UserControl2 uc2;
    private UserControl3 uc3;
    private UserControl4 uc4;

    public Form1()
    {
        InitializeComponent();
        this.Load += Form1_Load; // Load �̺�Ʈ ���� (�����̳ʿ��� �̹� ����Ǿ� ������ ���� ����)

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
            // uc1�� UserControl1 �ν��Ͻ��� ��,
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

    private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        panel1.Controls.Clear();
        panel1.Controls.Add(uc1);  // uc1�� UserControl1
        uc1.Dock = DockStyle.Fill;
    }

    private void �԰�ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        panel1.Controls.Clear();
        panel1.Controls.Add(uc3);
        uc3.Dock = DockStyle.Fill;
    }

    private void ���ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        panel1.Controls.Clear();
        panel1.Controls.Add(uc4);
        uc4.Dock = DockStyle.Fill;
    }
}


