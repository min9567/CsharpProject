namespace mes_study
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                using (var login = new LoginForm())
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        // Form1���� �α׾ƿ� �� DialogResult.Retry�� ��ȯ!
                        var mainForm = new Form1(login.SupabaseUrl, login.SupabaseKey);
                        var result = mainForm.ShowDialog();

                        if (result == DialogResult.Retry)
                        {
                            // �α׾ƿ� -> �ٽ� �α��� �ݺ�
                            continue;
                        }
                        else
                        {
                            // ����ڰ� �׳� �ݰų�, ���� ����
                            break;
                        }
                    }
                    else
                    {
                        // �α��� ���/�ݱ� �� ���α׷� ����
                        break;
                    }
                }
            }
        }
    }
}
