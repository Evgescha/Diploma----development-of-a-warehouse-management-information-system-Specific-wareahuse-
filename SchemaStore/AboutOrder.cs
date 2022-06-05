using System;
using System.Windows.Forms;

namespace SchemaStore
{
    public partial class AboutOrder : Form
    {
        DataGridViewRow customerRow;
        DataGridViewRow deliveryRow;
        DataGridViewRow orderRow;

        public AboutOrder(
            DataGridViewRow customerRow, 
            DataGridViewRow deliveryRow, 
            DataGridViewRow orderRow)
        {
            InitializeComponent();
            this.customerRow = customerRow;
            this.deliveryRow = deliveryRow;
            this.orderRow = orderRow;
        }

        private void AboutOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
