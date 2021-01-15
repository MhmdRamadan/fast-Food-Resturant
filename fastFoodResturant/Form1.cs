using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace fastFoodResturant
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            panel4.Top = button_home.Top;
            firstUserControl11.BringToFront();
            notificationUserControl11.Visible = false;
            button_home.Enabled = false;
            button_pay.Enabled = false;
            button_collection.Enabled = false;
            button_user.Enabled = false;
            button_best.Enabled = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Top = button_home.Top;
            firstUserControl11.BringToFront();
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel4.Top = button_best.Top;
            secondUserControl11.BringToFront();
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void reg_btn(object sender, EventArgs e)
        {
            panel4.Top = button6.Top;
            registerUserControl11.BringToFront();
        }

        private void login_btn(object sender, EventArgs e)
        {
            panel4.Top = button12.Top;
            loginUserControl11.BringToFront();
        }

        private void order_btn(object sender, EventArgs e)
        {
            panel4.Top = button_collection.Top;
            collectionUserControl11.BringToFront();
        }

        private void not_Click(object sender, EventArgs e)
        {
            if(notificationUserControl11.Visible)
            {
                notificationUserControl11.Visible = false;
                notificationUserControl11.SendToBack();
                
            }
            else
            {
                notificationUserControl11.Visible = true;
                notificationUserControl11.BringToFront();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void custome_btn(object sender, EventArgs e)
        {
            panel4.Top = button_user.Top;
            customerUserControl11.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void payment_btn(object sender, EventArgs e)
        {
            panel4.Top = button_pay.Top;
            paymentUserControl11.BringToFront();
        }

        private void logout_btn(object sender, EventArgs e)
        {
            //disable all buttons but not login and register
            //delete orders table data
            // make login in front view
            string connectionstring = @"Data Source=HACONA-MATATA\SQLEXPRESS;Initial Catalog=resturant;Integrated Security=True;";
            string query = " DELETE FROM order_table";
            SqlConnection MyConn2 = new SqlConnection(connectionstring);
            SqlCommand mycommand = new SqlCommand(query, MyConn2);
            SqlDataReader myreader2;
            MyConn2.Open();
            myreader2 = mycommand.ExecuteReader();
            MessageBox.Show("Successfull log out");
            while (myreader2.Read())
            {
            }
            MyConn2.Close();
            notificationUserControl11.Visible = false;
            button_home.Enabled = false;
            button_pay.Enabled = false;
            button_collection.Enabled = false;
            button_user.Enabled = false;
            button_best.Enabled = false;


        }

        private void paymentUserControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
