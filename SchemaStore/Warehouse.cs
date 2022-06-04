using System;
using System.Windows.Forms;

namespace SchemaStore
{
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
        }
        // btn back
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Warehouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            Runner.ShowForm();
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.СкладТоварНнИНазвание' table. You can move, or remove it, as needed.
            this.складТоварНнИНазваниеTableAdapter.Fill(this.databaseDataSet.СкладТоварНнИНазвание);
            // TODO: This line of code loads data into the 'databaseDataSet.СкладТоварНнИНазвание' table. You can move, or remove it, as needed.
            this.складТоварНнИНазваниеTableAdapter.Fill(this.databaseDataSet.СкладТоварНнИНазвание);
            // TODO: This line of code loads data into the 'databaseDataSet.СкладТоварНнИНазвание' table. You can move, or remove it, as needed.
            this.складТоварНнИНазваниеTableAdapter.Fill(this.databaseDataSet.СкладТоварНнИНазвание);
            // TODO: This line of code loads data into the 'databaseDataSet.Склад' table. You can move, or remove it, as needed.
            this.складTableAdapter.Fill(this.databaseDataSet.Склад);
            // TODO: This line of code loads data into the 'databaseDataSet.Склад' table. You can move, or remove it, as needed.
            this.складTableAdapter.Fill(this.databaseDataSet.Склад);
            loadData();
        }
        private void loadData() {
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
               "Продолжить сохранение?",
               "Подтвердите сохранение",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.EndEdit();
                    складTableAdapter.Update(databaseDataSet.Склад);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
