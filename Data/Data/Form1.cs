namespace Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 입고ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            UcIn uc = new UcIn();
            uc.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(uc);
        }

        private void 출고ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            UcOut uc = new UcOut();
            uc.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(uc);
        }

        private void 자재목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            UcList uc = new UcList();
            uc.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(uc);
        }
    }
}
