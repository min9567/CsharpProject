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
    private UserControl6 uc6;
    private UserControl7 uc7;
    public UserControl8 uc8;
    private UserControl9 uc9;
    private UserControl12 uc12;
    private UserControl13 uc13;

    private string supabaseUrl;
    private string supabaseKey;

    private Stack<UserControl> historyStack = new Stack<UserControl>();

    public Form1(string supabaseUrl, string supabaseKey)
    {
        InitializeComponent();
        this.supabaseUrl = supabaseUrl;
        this.supabaseKey = supabaseKey;
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
        uc6 = new UserControl6(supabase);
        uc7 = new UserControl7(supabase);
        uc8 = new UserControl8(supabase);
        uc9 = new UserControl9(supabase);
        uc12 = new UserControl12(supabase);
        uc13 = new UserControl13(supabase);

        uc1.button1Clicked += Uc1_button1Clicked;
        uc1.button3Clicked += Uc1_button3Clicked;
        uc1.button4Clicked += Uc1_button4Clicked;
        uc2.success += RefreshUc1;
        uc3.success += RefreshUc1;
        uc4.success += RefreshUc1;
        uc6.success += RefreshUc1;
        uc7.success += RefreshUc8;
        uc12.success += RefreshUc13;
        uc8.button2Clicked += Uc8_button2Clicked;
        uc8.button4Clicked += Uc8_button4Clicked;
        uc9.EditCompleted += Uc9_EditCompleted;
        uc13.button2Clicked += Uc13_button2Clicked;

        uc2.canceled += Uc1_Canceled;
        uc3.canceled += Uc1_Canceled;
        uc4.canceled += Uc1_Canceled;
        uc6.canceled += Uc1_Canceled;
        uc7.canceled += Uc8_Canceled;
        uc9.canceled += Uc8_Canceled;
        uc12.canceled += Uc13_Canceled;
    }

    private async void RefreshUc1(object sender, EventArgs e)
    {
        await uc1.LoadMaterialsAsync();  // ��� ���ΰ�ħ
        panel1.Controls.Clear();
        panel1.Controls.Add(uc1);
        uc1.Dock = DockStyle.Fill;
    }

    private void Uc1_Canceled(object sender, EventArgs e)
    {
        panel1.Controls.Clear();
        panel1.Controls.Add(uc1);
        uc1.Dock = DockStyle.Fill;
        uc1.LoadMaterialsAsync(); // ��� ���ΰ�ħ�� �ʿ��ϸ�
    }

    private async void RefreshUc8(object sender, EventArgs e)
    {
        await uc8.LoadEmployeesAsync();  // ��� ���ΰ�ħ
        panel1.Controls.Clear();
        panel1.Controls.Add(uc8);
        uc8.Dock = DockStyle.Fill;
    }

    private void Uc8_Canceled(object sender, EventArgs e)
    {
        panel1.Controls.Clear();
        panel1.Controls.Add(uc8);
        uc8.Dock = DockStyle.Fill;
        uc8.LoadEmployeesAsync(); // ��� ���ΰ�ħ�� �ʿ��ϸ�
    }

    private async void RefreshUc13(object sender, EventArgs e)
    {
        await uc13.LoaddepartmentsAsync();  // ��� ���ΰ�ħ
        panel1.Controls.Clear();
        panel1.Controls.Add(uc13);
        uc13.Dock = DockStyle.Fill;
    }

    private void Uc13_Canceled(object sender, EventArgs e)
    {
        panel1.Controls.Clear();
        panel1.Controls.Add(uc13);
        uc13.Dock = DockStyle.Fill;
        uc13.LoaddepartmentsAsync(); // ��� ���ΰ�ħ�� �ʿ��ϸ�
    }

    private void Uc1_button1Clicked(object sender, EventArgs e)
    {
        if (panel1.Controls.Count > 0)
            historyStack.Push(panel1.Controls[0] as UserControl);

        uc2.ClearInputs();
        panel1.Controls.Clear();
        panel1.Controls.Add(uc2);
        uc2.Dock = DockStyle.Fill;
        uc2.FocusToComboBox();
    }

    private void Uc1_button3Clicked(object sender, EventArgs e)
    {
        if (panel1.Controls.Count > 0)
            historyStack.Push(panel1.Controls[0] as UserControl);

        string checkedUuid = sender as string; // sender�� uuid

        if (!string.IsNullOrEmpty(checkedUuid))
            uc5.SetUuid(checkedUuid); // SetUuid�� UserControl5�� ���� ���� �ʿ�

        panel1.Controls.Clear();
        panel1.Controls.Add(uc5);
        uc5.Dock = DockStyle.Fill;
        uc5.LoadMaterialListAsync();
    }

    private void Uc1_button4Clicked(object sender, EventArgs e)
    {
        if (panel1.Controls.Count > 0)
            historyStack.Push(panel1.Controls[0] as UserControl);

        string checkedUuid = sender as string; // sender�� uuid

        if (!string.IsNullOrEmpty(checkedUuid))
            uc6.SetUuid(checkedUuid); // SetUuid�� UserControl6�� ���� ���� �ʿ�

        uc6.SetUuid(checkedUuid);
        panel1.Controls.Clear();
        panel1.Controls.Add(uc6);
        uc6.Dock = DockStyle.Fill;
        uc6.LoadMaterialsAsync();
    }

    private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (panel1.Controls.Count > 0)
            historyStack.Push(panel1.Controls[0] as UserControl);

        uc1.LoadMaterialsAsync();
        panel1.Controls.Clear();
        panel1.Controls.Add(uc1);  // uc1�� UserControl1
        uc1.Dock = DockStyle.Fill;
    }

    private void �԰�ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (panel1.Controls.Count > 0)
            historyStack.Push(panel1.Controls[0] as UserControl);

        var newUc3 = new UserControl3(supabase);
        uc3.LoadMaterialNamesAsync();
        uc3.ClearInputs();
        panel1.Controls.Clear();
        panel1.Controls.Add(uc3);
        uc3.Dock = DockStyle.Fill;
        uc3.FocusToComboBox();
    }

    private void ���ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (panel1.Controls.Count > 0)
            historyStack.Push(panel1.Controls[0] as UserControl);

        uc4.LoadMaterialNamesAsync();
        uc4.ClearInputs();
        panel1.Controls.Clear();
        panel1.Controls.Add(uc4);
        uc4.Dock = DockStyle.Fill;
        uc4.FocusToComboBox();
    }

    private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (panel1.Controls.Count > 0)
            historyStack.Push(panel1.Controls[0] as UserControl);

        uc7.ClearInputs();
        panel1.Controls.Clear();
        panel1.Controls.Add(uc7);
        uc7.Dock = DockStyle.Fill;
        uc7.FocusToComboBox();
    }

    private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (panel1.Controls.Count > 0)
            historyStack.Push(panel1.Controls[0] as UserControl);

        uc8.LoadEmployeesAsync();
        panel1.Controls.Clear();
        panel1.Controls.Add(uc8);
        uc8.Dock = DockStyle.Fill;
    }

    private void Uc8_button2Clicked(object sender, EventArgs e)
    {
        if (panel1.Controls.Count > 0)
            historyStack.Push(panel1.Controls[0] as UserControl);

        string uuid = sender as string;

        if (!string.IsNullOrEmpty(uuid))
            uc9.SetUuid(uuid); // ������Ʈ��9���� uuid ����

        panel1.Controls.Clear();
        panel1.Controls.Add(uc9);
        uc9.Dock = DockStyle.Fill;
        uc9.FocusToTextBox();
        uc9.LoadEmployeeDataAsync();
    }

    private void Uc8_button4Clicked(object sender, EventArgs e)
    {
        if (panel1.Controls.Count > 0)
            historyStack.Push(panel1.Controls[0] as UserControl);

        uc7.ClearInputs();
        panel1.Controls.Clear();
        panel1.Controls.Add(uc7);
        uc7.Dock = DockStyle.Fill;
        uc7.FocusTextBox();
    }

    private async void Uc9_EditCompleted(object sender, EventArgs e)
    {
        await uc8.LoadEmployeesAsync();
        panel1.Controls.Clear();
        panel1.Controls.Add(uc8);
        uc8.Dock = DockStyle.Fill;
    }

    private void �μ����ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (panel1.Controls.Count > 0)
            historyStack.Push(panel1.Controls[0] as UserControl);

        uc12.ClearInputs();
        panel1.Controls.Clear();
        panel1.Controls.Add(uc12);
        uc12.Dock = DockStyle.Fill;
        uc12.FocusTextBox();
    }

    private async void �μ����ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (panel1.Controls.Count > 0)
            historyStack.Push(panel1.Controls[0] as UserControl);

        await uc13.LoaddepartmentsAsync();
        panel1.Controls.Clear();
        panel1.Controls.Add(uc13);
        uc13.Dock = DockStyle.Fill;
    }

    private void Uc13_button2Clicked(object sender, EventArgs e)
    {
        if (panel1.Controls.Count > 0)
            historyStack.Push(panel1.Controls[0] as UserControl);

        uc12.ClearInputs();
        panel1.Controls.Clear();
        panel1.Controls.Add(uc12);
        uc12.Dock = DockStyle.Fill;
        uc12.FocusTextBox();
    }

    private void �α׾ƿ�ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SessionInfo.UserUuid = null;
        this.DialogResult = DialogResult.Retry; // <- �߿�!
        this.Close();
    }

    private async void btnBack_Click(object sender, EventArgs e)
    {
        if (historyStack.Count > 0)
        {
            var prevControl = historyStack.Pop();
            panel1.Controls.Clear();
            panel1.Controls.Add(prevControl);

            if (prevControl is UserControl1 listUc)
                await listUc.LoadMaterialsAsync();
            else if (prevControl is UserControl8 empListUc)
                await empListUc.LoadEmployeesAsync();
            else if (prevControl is UserControl13 deptListUc)
                await deptListUc.LoaddepartmentsAsync();

            if (prevControl is UserControl2 uc2) uc2.ClearInputs();
            if (prevControl is UserControl3 uc3) uc3.ClearInputs();
            if (prevControl is UserControl4 uc4) uc4.ClearInputs();
            if (prevControl is UserControl6 uc6) uc6.ClearInputs();
            if (prevControl is UserControl7 uc7) uc7.ClearInputs();
            if (prevControl is UserControl9 uc9) uc9.ClearInputs();
            if (prevControl is UserControl12 uc12) uc12.ClearInputs();
        }
    }

    
}


