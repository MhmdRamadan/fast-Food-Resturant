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
    public partial class customerUserControl1 : UserControl
    {
        private static customerUserControl1 _Instance = null;
        public static customerUserControl1 getInsance()
        {
            if(_Instance == null)
            {
                return new customerUserControl1();
            }
            return _Instance;
        }

        public customerUserControl1()
        {
            InitializeComponent();
        }
        string connectionstring = @"Data Source=HACONA-MATATA\SQLEXPRESS;Initial Catalog=resturant;Integrated Security=True;";


        private void customerUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM rest_table", sqlcon);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

            }
        }
    }
}
