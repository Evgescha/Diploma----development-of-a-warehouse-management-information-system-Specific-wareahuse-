using System;
using System.Windows.Forms;

namespace SchemaStore
{
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void Delivery_FormClosing(object sender, FormClosingEventArgs e)
        {
            Runner.ShowForm();
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Склад' table. You can move, or remove it, as needed.
            this.складTableAdapter.Fill(this.databaseDataSet.Склад);
            // TODO: This line of code loads data into the 'databaseDataSet.Товар' table. You can move, or remove it, as needed.
            this.товарTableAdapter.Fill(this.databaseDataSet.Товар);
            // TODO: This line of code loads data into the 'databaseDataSet.ТоварыПоставки' table. You can move, or remove it, as needed.
            this.товарыПоставкиTableAdapter.Fill(this.databaseDataSet.ТоварыПоставки);
            // TODO: This line of code loads data into the 'databaseDataSet.Поставка' table. You can move, or remove it, as needed.
            this.поставкаTableAdapter.Fill(this.databaseDataSet.Поставка);

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
