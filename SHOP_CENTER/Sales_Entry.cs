using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOP_CENTER
{
    public partial class Sales_Entry : Form
    {
        public Sales_Entry()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Balance_596 b = new Balance_596();
            b.Hide();
            b.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Available_Bill_No b = new Available_Bill_No();
            b.Hide();
            b.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Balance b = new Balance();
            b.Hide();
            b.ShowDialog();
        }
    }
}
