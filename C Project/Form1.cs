namespace C_Project
{
    public partial class Form1 : Form
    {   // 폼 클래스에 추가
        int originalInventoryTop;
        UserControl3 salesSubMenuControl;

        public Form1()
        {
            InitializeComponent();

            // 폼 처음에 inventory의 원래 Top값 저장
            originalInventoryTop = siderinventory.Top;

            salesSubMenuControl = new UserControl3();
            salesSubMenuControl.Visible = false; // 처음엔 안 보이게
            // 원하는 위치(예: Sales 바로 아래)
            salesSubMenuControl.Location = new Point(
                sidersales.Left, sidersales.Bottom + 5
            );
            salesSubMenuControl.OrdersClicked += SalesSubMenuControl_OrdersClicked;
            salesSubMenuControl.CustomersClicked += SalesSubMenuControl_CustomersClicked;
            panel1.Controls.Add(salesSubMenuControl);
        }

        private void SalesSubMenuControl_OrdersClicked(object sender, EventArgs e)
        {
            TopTitle.Text = "Orders";
            panelmain.Controls.Clear();
            var ordersControl = new UserControl1();
            ordersControl.Dock = DockStyle.Fill;
            panelmain.Controls.Add(ordersControl);
        }

        private void SalesSubMenuControl_CustomersClicked(object sender, EventArgs e)
        {
            TopTitle.Text = "Customer";
            panelmain.Controls.Clear();
            var customersControl = new UserControl2();
            customersControl.Dock = DockStyle.Fill;
            panelmain.Controls.Add(customersControl);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidersales_Click(object sender, EventArgs e)
        {

        }

        bool salesExpanded = false;

        private void sidersales_Click_1(object sender, EventArgs e)
        {
            salesExpanded = !salesExpanded;
            salesSubMenuControl.Visible = salesExpanded;

            if (salesExpanded)
            {
                // salesSubMenuControl이 보이면, inventory 위치를 아래로
                siderinventory.Top = salesSubMenuControl.Bottom;
            }
            else
            {
                // salesSubMenuControl이 안보이면, 원래 위치로 복귀
                siderinventory.Top = originalInventoryTop;
            }

        }

        private void labelorders_Click(object sender, EventArgs e)
        {
            
        }

        private void labelcustomers_Click(object sender, EventArgs e)
        {

        }
    }
}
