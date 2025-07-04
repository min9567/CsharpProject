using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Project
{
    public partial class UserControl3 : UserControl
    {
        public event EventHandler OrdersClicked;
        public event EventHandler CustomersClicked;

        public UserControl3()
        {
            InitializeComponent();

        }
        private void labelorders_Click(object sender, EventArgs e)
        {
            OrdersClicked?.Invoke(this, EventArgs.Empty);
        }

        private void labelcustomers_Click(object sender, EventArgs e)
        {
            CustomersClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
