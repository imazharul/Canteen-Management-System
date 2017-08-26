using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace SHOP_CENTER
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent(); 
        }
        SqlConnection con = new SqlConnection("Data Source=MAZHARUL\\SQLEXPRESS;Initial Catalog=Homeland;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (text_User_name.Text == "" || tex_Password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection("Data Source=MAZHARUL\\SQLEXPRESS;Initial Catalog=Log;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Select * from SingUp where User_Name='"+text_User_name.Text+"' and Password='"+tex_Password.Text+"'", con);
                //cmd.Parameters.AddWithValue("@username", text_User_name.Text);
                //cmd.Parameters.AddWithValue("@password",tex_Password.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show New_food form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    New_food_item fm = new New_food_item();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void text_User_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
