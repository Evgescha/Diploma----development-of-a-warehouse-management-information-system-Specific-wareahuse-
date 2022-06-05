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
            z1.Text = customerRow.Cells[1].Value.ToString();
            z2.Text = customerRow.Cells[3].Value.ToString();
            z3.Text = customerRow.Cells[2].Value.ToString();
            z4.Text = customerRow.Cells[4].Value.ToString();
            z5.Text = customerRow.Cells[5].Value.ToString();

            g1.Text = deliveryRow.Cells[2].Value.ToString();
            g2.Text = deliveryRow.Cells[4].Value.ToString();
            g3.Text = deliveryRow.Cells[3].Value.ToString();
            g4.Text = deliveryRow.Cells[5].Value.ToString();
            g5.Text = deliveryRow.Cells[6].Value.ToString();

            o1.Text = orderRow.Cells[2].Value.ToString();
            o2.Text = orderRow.Cells[3].Value.ToString();
            o3.Text = orderRow.Cells[4].Value.ToString();
            o4.Text = orderRow.Cells[5].Value.ToString();
            o5.Text = orderRow.Cells[7].Value.ToString();

            this.товарыЗаказаTableAdapter.FillByOrderId(this.databaseDataSet.ТоварыЗаказа, int.Parse(orderRow.Cells[0].Value.ToString()));
        }

    }
}
