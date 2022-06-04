using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchemaStore
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.ЗаказчикГрузополучатель' table. You can move, or remove it, as needed.
            this.заказчикГрузополучательTableAdapter.Fill(this.databaseDataSet.ЗаказчикГрузополучатель);
            // TODO: This line of code loads data into the 'databaseDataSet.Заказ' table. You can move, or remove it, as needed.
            this.заказTableAdapter.Fill(this.databaseDataSet.Заказ);
            // TODO: This line of code loads data into the 'databaseDataSet.Заказчик' table. You can move, or remove it, as needed.
            this.заказчикTableAdapter.Fill(this.databaseDataSet.Заказчик);

        }
        // save customer
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }
        //save productGaver
        private void toolStripButton11_Click(object sender, EventArgs e)
        {

        }
    }
}
