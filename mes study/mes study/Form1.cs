namespace mes_study;
using DotNetEnv;

public partial class Form1 : Form
{
    // 1. Ŭ���� �ʵ�� supabase ����
    private Supabase.Client supabase;
    private UserControl1 uc1;
    private UserControl2 uc2;
    private UserControl3 uc3;
    private UserControl4 uc4;
    private UserControl5 uc5;

    public Form1()
    {
        InitializeComponent();
        this.Load += Form1_Load; // Load �̺�Ʈ ���� (�����̳ʿ��� �̹� ����Ǿ� ������ ���� ����)

    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        Env.Load(".env.txt");

        var supabaseUrl = Environment.GetEnvironmentVariable("SUPABASE_URL");
        var supabaseKey = Environment.GetEnvironmentVariable("SUPABASE_KEY");
        supabase = new Supabase.Client(supabaseUrl, supabaseKey);
        await supabase.InitializeAsync();

        uc1 = new UserControl1(supabase);
        uc2 = new UserControl2(supabase);
        uc3 = new UserControl3(supabase);
        uc4 = new UserControl4(supabase);
        uc5 = new UserControl5(supabase);

        uc1.button1Clicked += Uc1_button1Clicked;
        uc1.button3Clicked += Uc1_button3Clicked;
        uc2.success += RefreshUc1;
        uc3.success += RefreshUc1;
        uc4.success += RefreshUc1;
    }

    private async void RefreshUc1(object sender, EventArgs e)
    {
        await uc1.LoadMaterialsAsync();
        uc1.Dock = DockStyle.Fill;
    }

    private void Uc1_button1Clicked(object sender, EventArgs e)
    {
        uc2.ClearInputs();
        panel1.Controls.Clear();
        panel1.Controls.Add(uc2);
        uc2.Dock = DockStyle.Fill;
        uc2.FocusToComboBox();
    }

    private void Uc1_button3Clicked(object sender, EventArgs e)
    {

        string checkedUuid = sender as string; // sender�� uuid

        if (!string.IsNullOrEmpty(checkedUuid))
            uc5.SetUuid(checkedUuid); // SetUuid�� UserControl5�� ���� ���� �ʿ�

        panel1.Controls.Clear();
        panel1.Controls.Add(uc5);
        uc5.Dock = DockStyle.Fill;
        uc5.LoadMaterialListAsync();

    }

    private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        uc1.LoadMaterialsAsync();
        panel1.Controls.Clear();
        panel1.Controls.Add(uc1);  // uc1�� UserControl1
        uc1.Dock = DockStyle.Fill;
    }

    private void �԰�ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        uc3.LoadMaterialNamesAsync();
        uc3.ClearInputs();
        panel1.Controls.Clear();
        panel1.Controls.Add(uc3);
        uc3.Dock = DockStyle.Fill;
        uc3.FocusToComboBox();
    }

    private void ���ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        uc4.LoadMaterialNamesAsync();
        uc4.ClearInputs();
        panel1.Controls.Clear();
        panel1.Controls.Add(uc4);
        uc4.Dock = DockStyle.Fill;
        uc4.FocusToComboBox();
    }
}


