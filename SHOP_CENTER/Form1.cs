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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btm_sales_entry_Click(object sender, EventArgs e)
        {
            Sales_Entry b = new Sales_Entry();
            b.Hide();
            b.ShowDialog();
        }

        private void btm_pro_receive_Click(object sender, EventArgs e)
        {
            Food_item_Recive b = new Food_item_Recive();
            b.Hide();
            b.ShowDialog();
        }

        private void btm_add_Click(object sender, EventArgs e)
        {
           Login  b = new Login ();
            b.Hide();
            b.ShowDialog();
        }

        private void btm_report_Click(object sender, EventArgs e)
        {
            Repot b =new Repot();
            b.Hide();
            b.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Stock_Click(object sender, EventArgs e)
        {
            Stock_report b = new Stock_report();
            b.Hide();
            b.ShowDialog();
        }
    }
}
