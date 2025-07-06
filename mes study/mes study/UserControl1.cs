using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mes_study
{
    public partial class UserControl1 : UserControl
    {
        private Supabase.Client supabase;

        public event EventHandler button1Clicked;
        public UserControl1(Supabase.Client supabase)
        {
            InitializeComponent();
            this.supabase = supabase;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
