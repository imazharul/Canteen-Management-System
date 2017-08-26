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
    public partial class Food_item_Recive : Form
    {
        public Food_item_Recive()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Balance b = new Balance();
            b.Hide();
            b.ShowDialog();
        }
    }
}
