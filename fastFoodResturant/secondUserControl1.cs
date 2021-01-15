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
    public partial class secondUserControl1 : UserControl
    {
        notificationUserControl1 form;
        manfacture manfacture = new manfacture();
        public secondUserControl1(notificationUserControl1 f)
        {
            InitializeComponent();
            form = f;
        }
        string connectionstring = @"Data Source=HACONA-MATATA\SQLEXPRESS;Initial Catalog=resturant;Integrated Security=True;";


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderUserControl1 o = new orderUserControl1(form);
            manfacture.ConstructOrder(new sandwish1(), o, notificationUserControl1.N++);
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
                sqlcmd.Parameters.AddWithValue("@price", 15);
                sqlcmd.Parameters.AddWithValue("@quantity", 1);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Your order has been confirmed");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orderUserControl1 o = new orderUserControl1(form);
            manfacture.ConstructOrder(new cake3(), o, notificationUserControl1.N++);
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
                sqlcmd.Parameters.AddWithValue("@price", 11);
                sqlcmd.Parameters.AddWithValue("@quantity", 1);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Your order has been confirmed");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            orderUserControl1 o = new orderUserControl1(form);
            manfacture.ConstructOrder(new beverge1(), o, notificationUserControl1.N++);
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
                sqlcmd.Parameters.AddWithValue("@price", 12);
                sqlcmd.Parameters.AddWithValue("@quantity", 1);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Your order has been confirmed");

            }
        }
    }
}
