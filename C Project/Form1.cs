namespace C_Project
{
    public partial class Form1 : Form
    {   // �� Ŭ������ �߰�
        int originalInventoryTop;
        UserControl3 salesSubMenuControl;

        public Form1()
        {
            InitializeComponent();

            // �� ó���� inventory�� ���� Top�� ����
            originalInventoryTop = siderinventory.Top;

            salesSubMenuControl = new UserControl3();
            salesSubMenuControl.Visible = false; // ó���� �� ���̰�
            // ���ϴ� ��ġ(��: Sales �ٷ� �Ʒ�)
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
                // salesSubMenuControl�� ���̸�, inventory ��ġ�� �Ʒ���
                siderinventory.Top = salesSubMenuControl.Bottom;
            }
            else
            {
                // salesSubMenuControl�� �Ⱥ��̸�, ���� ��ġ�� ����
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
