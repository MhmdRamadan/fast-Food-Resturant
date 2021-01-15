using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace fastFoodResturant
{
    public partial class loginUserControl1 : UserControl
    {
        public Form1 form;
        public loginUserControl1(Form1 f)
        {
            InitializeComponent();
            form = f;
            textBox2.PasswordChar = '*';



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            customerUserControl1.getInsance().BringToFront();

            string connectionstring = @"Data Source=HACONA-MATATA\SQLEXPRESS;Initial Catalog=resturant;Integrated Security=True;";

            SqlConnection sqlcon = new SqlConnection(connectionstring);
            string query = "Select * from rest_table Where first_name = '" + textBox1.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {

                MessageBox.Show("Successfully login");
                form.button_home.Enabled = true;
                form.button_pay.Enabled = true;
                form.button_user.Enabled = true;
                form.button_collection.Enabled = true;
                    form.button_best.Enabled = true;
            }
            else
            {
                MessageBox.Show("check your username and password");
            }
        }

        private void loginUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
