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
    public partial class paymentUserControl1 : UserControl
    {
        public paymentUserControl1()
        {
            InitializeComponent();
        }
        string connectionstring = @"Data Source=HACONA-MATATA\SQLEXPRESS;Initial Catalog=resturant;Integrated Security=True;";

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM order_table",sqlcon);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

            }
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            MessageBox.Show("the total price : "+ sum.ToString());

        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}