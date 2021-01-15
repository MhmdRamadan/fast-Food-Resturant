using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fastFoodResturant
{
    public partial class notificationUserControl1 : UserControl
    {
        public List<orderUserControl1> myOrders = new List<orderUserControl1>();
        public notificationUserControl1()
        {
            InitializeComponent();
           
            
        }
        public void addOrder(orderUserControl1 o)
        {
            
            flowLayoutPanel1.Controls.Add(o);
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        public FlowLayoutPanel setFlow
        {
            get { return flowLayoutPanel1; }
            set { flowLayoutPanel1 = value; }
        }

        public static int N { get; set; } =0;

        public void removeOrder(int index)
        {
            
            this.setFlow.Controls.Remove(myOrders[index]);
            //MessageBox.Show(index.ToString());
        }
    }
}
