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
    public partial class firstUserControl1 : UserControl
    {
        notificationUserControl1 form;
        manfacture manfacture = new manfacture();
        public firstUserControl1(notificationUserControl1 f)
        {
            InitializeComponent();
            form = f;
            
        }
        string connectionstring = @"Data Source=HACONA-MATATA\SQLEXPRESS;Initial Catalog=resturant;Integrated Security=True;";

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            orderUserControl1 o = new orderUserControl1(form);
            manfacture.ConstructOrder(new meal(), o, notificationUserControl1.N++);
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
                sqlcmd.Parameters.AddWithValue("@price", 29);
                sqlcmd.Parameters.AddWithValue("@quantity", 1);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Your order has been confirmed");

            }
        }

        private void firstUserControl1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
