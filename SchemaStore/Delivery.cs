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
            loadData();
        }
        private void loadData()
        {
            this.складTableAdapter.Fill(this.databaseDataSet.Склад);
            this.товарTableAdapter.Fill(this.databaseDataSet.Товар);
            this.поставкаTableAdapter.Fill(this.databaseDataSet.Поставка);
            this.товарыПоставкиTableAdapter.Fill(this.databaseDataSet.ТоварыПоставки);
        }
        // save delivery
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
               "Продолжить сохранение?",
               "Подтвердите сохранение",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1[2, i].Value == null || dataGridView1[2, i].Value.ToString().Length==0) dataGridView1[2, i].Value = DateTime.Now;
                        if (dataGridView1[3, i].Value == null || dataGridView1[3, i].Value.ToString().Length == 0) dataGridView1[3, i].Value = "В процессе";
                    }

                    dataGridView1.CurrentCell = null;
                    dataGridView1.EndEdit();
                    поставкаTableAdapter.Update(databaseDataSet.Поставка);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
