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
                        // Form1에서 로그아웃 시 DialogResult.Retry로 반환!
                        var mainForm = new Form1(login.SupabaseUrl, login.SupabaseKey);
                        var result = mainForm.ShowDialog();

                        if (result == DialogResult.Retry)
                        {
                            // 로그아웃 -> 다시 로그인 반복
                            continue;
                        }
                        else
                        {
                            // 사용자가 그냥 닫거나, 완전 종료
                            break;
                        }
                    }
                    else
                    {
                        // 로그인 취소/닫기 → 프로그램 종료
                        break;
                    }
                }
            }
        }
    }
}
