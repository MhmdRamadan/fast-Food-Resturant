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
    public partial class registerUserControl1 : UserControl
    {
        public registerUserControl1()
        {
            InitializeComponent();
            
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            string[] employees = new string[]{"Hamilton, David", "Hensien, Kari",
            "Hammond, Maria", "Harris, Keith", "Henshaw, Jeff D.", 
            "Hanson, Mark", "Harnpadoungsataya, Sariya", 
            "Harrington, Mark", "Harris, Keith", "Hartwig, Doris", 
            "Harui, Roger", "Hassall, Mark", "Hasselberg, Jonas", 
            "Harnpadoungsataya, Sariya", "Henshaw, Jeff D.", 
            "Henshaw, Jeff D.", "Hensien, Kari", "Harris, Keith", 
            "Henshaw, Jeff D.", "Hensien, Kari", "Hasselberg, Jonas",
            "Harrington, Mark", "Hedlund, Magnus", "Hay, Jeff", 
            "Heidepriem, Brandon D."};
            comboBox1.Items.AddRange(employees);
            textBox6.PasswordChar = '*';
        }
        string connectionstring = @"Data Source=HACONA-MATATA\SQLEXPRESS;Initial Catalog=resturant;Integrated Security=True;";


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("please fill the fields");
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("UserAdd", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@first_name", textBox1.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@last_name", textBox2.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@governorate", comboBox1.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@street_address", textBox3.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@phone", textBox4.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@email", textBox5.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@password", textBox6.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is successfull");

                }
            }
        }

        private void registerUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
