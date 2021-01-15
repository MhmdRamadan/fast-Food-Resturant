using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fastFoodResturant.builderpattern;
using System.Data.SqlClient;

namespace fastFoodResturant
{
    public partial class collectionUserControl1 : UserControl
    {
        
        public string size = null;
        public decimal quantity=1;
        notificationUserControl1 form;
        manfacture manfacture = new manfacture();
        
        
        public collectionUserControl1(notificationUserControl1 f)
        {
            InitializeComponent();
            form = f;
        }

        string connectionstring = @"Data Source=HACONA-MATATA\SQLEXPRESS;Initial Catalog=resturant;Integrated Security=True;";
        private void button1_Click(object sender, EventArgs e)
        {
            
            size = comboBox1.Text;
            quantity = numericUpDown1.Value;
            orderUserControl1 o = new orderUserControl1(form);
            manfacture.ConstructOrder(new sandwish1(), o, notificationUserControl1.N++,size,quantity);
            form.setFlow.Controls.Add(o);
            form.myOrders.Add(o);
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("Userorder", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@name", o.Name);
                sqlcmd.Parameters.AddWithValue("@type", o.Type);
                sqlcmd.Parameters.AddWithValue("@extras", o.Exters);
                sqlcmd.Parameters.AddWithValue("@size", o.Size1);
                sqlcmd.Parameters.AddWithValue("@price",14 * numericUpDown1.Value);
                sqlcmd.Parameters.AddWithValue("@quantity", numericUpDown1.Value);
                
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Your order has been confirmed");
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            size = comboBox2.Text;
            quantity = numericUpDown2.Value;
            orderUserControl1 o = new orderUserControl1(form);
            manfacture.ConstructOrder(new sandwish2(), o, notificationUserControl1.N++, size, quantity);
            form.setFlow.Controls.Add(o);
            form.myOrders.Add(o);

            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("Userorder", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@name", o.Name);
                sqlcmd.Parameters.AddWithValue("@type", o.Type);
                sqlcmd.Parameters.AddWithValue("@extras", o.Exters);
                sqlcmd.Parameters.AddWithValue("@size", o.Size1);
                sqlcmd.Parameters.AddWithValue("@price", 6* numericUpDown2.Value);
                sqlcmd.Parameters.AddWithValue("@quantity", numericUpDown2.Value);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Your order has been confirmed");

            }



        }
        private void button3_Click(object sender, EventArgs e)
        {
            size = comboBox3.Text;
            quantity = numericUpDown3.Value;
            orderUserControl1 o = new orderUserControl1(form);
            manfacture.ConstructOrder(new sandwish3(), o, notificationUserControl1.N++, size, quantity);
            form.setFlow.Controls.Add(o);
            form.myOrders.Add(o);
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("Userorder", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@name", o.Name);
                sqlcmd.Parameters.AddWithValue("@type", o.Type);
                sqlcmd.Parameters.AddWithValue("@extras", o.Exters);
                sqlcmd.Parameters.AddWithValue("@size", o.Size1);
                sqlcmd.Parameters.AddWithValue("@price", 17* numericUpDown3.Value);
                sqlcmd.Parameters.AddWithValue("@quantity", numericUpDown3.Value);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Your order has been confirmed");

            }




        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            size = comboBox4.Text;
            quantity = numericUpDown4.Value;
            orderUserControl1 o = new orderUserControl1(form);
            manfacture.ConstructOrder(new cake1(), o, notificationUserControl1.N++,size, quantity);
            form.setFlow.Controls.Add(o);
            form.myOrders.Add(o);
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("Userorder", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@name", o.Name);
                sqlcmd.Parameters.AddWithValue("@type", o.Type);
                sqlcmd.Parameters.AddWithValue("@extras", o.Exters);
                sqlcmd.Parameters.AddWithValue("@size", o.Size1);
                sqlcmd.Parameters.AddWithValue("@price",51* numericUpDown4.Value);
                sqlcmd.Parameters.AddWithValue("@quantity", numericUpDown4.Value);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Your order has been confirmed");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            size = comboBox5.Text;
            quantity = numericUpDown5.Value;
            orderUserControl1 o = new orderUserControl1(form);
            manfacture.ConstructOrder(new cake2(), o, notificationUserControl1.N++, size, quantity);
            form.setFlow.Controls.Add(o);
            form.myOrders.Add(o);
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("Userorder", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@name", o.Name);
                sqlcmd.Parameters.AddWithValue("@type", o.Type);
                sqlcmd.Parameters.AddWithValue("@extras", o.Exters);
                sqlcmd.Parameters.AddWithValue("@size", o.Size1);
                sqlcmd.Parameters.AddWithValue("@price", 49* numericUpDown5.Value);
                sqlcmd.Parameters.AddWithValue("@quantity", numericUpDown5.Value);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Your order has been confirmed");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            size = comboBox6.Text;
            quantity = numericUpDown7.Value;
            orderUserControl1 o = new orderUserControl1(form);
            manfacture.ConstructOrder(new cake3(), o, notificationUserControl1.N++, size, quantity);
            form.setFlow.Controls.Add(o);
            form.myOrders.Add(o);
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("Userorder", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@name", o.Name);
                sqlcmd.Parameters.AddWithValue("@type", o.Type);
                sqlcmd.Parameters.AddWithValue("@extras", o.Exters);
                sqlcmd.Parameters.AddWithValue("@size", o.Size1);
                sqlcmd.Parameters.AddWithValue("@price", 51* numericUpDown6.Value);
                sqlcmd.Parameters.AddWithValue("@quantity", numericUpDown6.Value);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Your order has been confirmed");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            size = comboBox7.Text;
            quantity = numericUpDown7.Value;
            orderUserControl1 o = new orderUserControl1(form);
            manfacture.ConstructOrder(new beverge1(), o, notificationUserControl1.N++, size, quantity);
            form.setFlow.Controls.Add(o);
            form.myOrders.Add(o); 
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("Userorder", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@name", o.Name);
                sqlcmd.Parameters.AddWithValue("@type", o.Type);
                sqlcmd.Parameters.AddWithValue("@extras", o.Exters);
                sqlcmd.Parameters.AddWithValue("@size", o.Size1);
                sqlcmd.Parameters.AddWithValue("@price", 7* numericUpDown7.Value);
                sqlcmd.Parameters.AddWithValue("@quantity", numericUpDown7.Value);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Your order has been confirmed");

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            size = comboBox8.Text;
            quantity = numericUpDown8.Value;
            orderUserControl1 o = new orderUserControl1(form);
            manfacture.ConstructOrder(new beverge2(), o, notificationUserControl1.N++, size, quantity);
            form.setFlow.Controls.Add(o);
            form.myOrders.Add(o);
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("Userorder", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@name", o.Name);
                sqlcmd.Parameters.AddWithValue("@type", o.Type);
                sqlcmd.Parameters.AddWithValue("@extras", o.Exters);
                sqlcmd.Parameters.AddWithValue("@size", o.Size1);
                sqlcmd.Parameters.AddWithValue("@price", 7 * numericUpDown8.Value);
                sqlcmd.Parameters.AddWithValue("@quantity", numericUpDown8.Value);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Your order has been confirmed");

            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            size = comboBox9.Text;
            quantity = numericUpDown9.Value;
            orderUserControl1 o = new orderUserControl1(form);
            manfacture.ConstructOrder(new beverge3(), o, notificationUserControl1.N++, size, quantity);
            form.setFlow.Controls.Add(o);
            form.myOrders.Add(o);
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("Userorder", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@name", o.Name);
                sqlcmd.Parameters.AddWithValue("@type", o.Type);
                sqlcmd.Parameters.AddWithValue("@extras", o.Exters);
                sqlcmd.Parameters.AddWithValue("@size", o.Size1);
                sqlcmd.Parameters.AddWithValue("@price", 7 * numericUpDown9.Value);
                sqlcmd.Parameters.AddWithValue("@quantity", numericUpDown9.Value);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Your order has been confirmed");

            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.BackColor = Color.Red;
                checkBox1.ForeColor = Color.White;
                Layout1.Visible = true;
                Layout2.Visible = true;
                Layout3.Visible = true;


            }
            else
            {
                checkBox1.BackColor = Color.White;
                checkBox1.ForeColor = Color.Black;
                if (checkBox2.Checked == true)
                {
                    checkBox2.BackColor = Color.Red;
                    checkBox2.ForeColor = Color.White;
                    Layout1.Visible = true;

                }
                else
                {
                    checkBox2.BackColor = Color.White;
                    checkBox2.ForeColor = Color.Black;
                    Layout1.Visible = false;
                }
                if (checkBox3.Checked == true)
                {
                    checkBox3.BackColor = Color.Red;
                    checkBox3.ForeColor = Color.White;
                    Layout2.Visible = true;

                }
                else
                {
                    checkBox3.BackColor = Color.White;
                    checkBox3.ForeColor = Color.Black;
                    Layout2.Visible = false;
                }
                if (checkBox4.Checked == true)
                {
                    checkBox4.BackColor = Color.Red;
                    checkBox4.ForeColor = Color.White;

                    Layout3.Visible = true;
                }
                else
                {
                    checkBox4.BackColor = Color.White;
                    checkBox4.ForeColor = Color.Black;
                    Layout3.Visible = false;
                }


            }

        }
       
        private void mainLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

