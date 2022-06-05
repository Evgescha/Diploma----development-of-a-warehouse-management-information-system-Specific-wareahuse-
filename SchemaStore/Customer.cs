using System;
using System.Data;
using System.Windows.Forms;

namespace SchemaStore
{
    public partial class Customer : Form
    {
        AboutOrder aboutOrder;
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
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

            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
               "Продолжить сохранение?",
               "Подтвердите сохранение",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.EndEdit();
                    заказчикTableAdapter.Update(databaseDataSet.Заказчик);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //save productGaver
        private void toolStripButton11_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
               "Продолжить сохранение?",
               "Подтвердите сохранение",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    dataGridView2.CurrentCell = null;
                    dataGridView2.EndEdit();
                    заказчикГрузополучательTableAdapter.Update(databaseDataSet.ЗаказчикГрузополучатель);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // add Customer data as Gaver
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.RowCount > 1)
            {
                try
                {
                    DataGridViewRow rowWithInfo = dataGridView1.CurrentRow;
                    DataRowView row = (DataRowView)заказчикЗаказчикГрузополучательBindingSource.AddNew();

                    row[0] = int.Parse(rowWithInfo.Cells[0].Value.ToString());
                    for (int col = 1; col <= 5; col++)
                    {
                        row[col + 1] = rowWithInfo.Cells[col].Value;
                    }
                    заказчикЗаказчикГрузополучательBindingSource.EndEdit();
                }
                catch (Exception ex) {
                    MessageBox.Show("Ошибка добавления заказчика как грузополучателя.\r\nПроверьте, не существует ли уже такая запись.");
                }
            }
            else {
                MessageBox.Show("Не выбран заказчик или в нем указаны неверные данные");
            }
        }
        // back btn
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Runner.ShowForm();
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        // about order
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null || dataGridView2.RowCount < 1) {
                MessageBox.Show("Не выбран заказ для просмотра информации");
                return;
            }

            int idDeliveryFromSelectedOrder = заказчикГрузополучательBindingSource.Find("ID", int.Parse(dataGridView2.CurrentRow.Cells[9].Value.ToString()));
            if (idDeliveryFromSelectedOrder == -1) return;
            comboBox1.SelectedItem = comboBox1.Items[idDeliveryFromSelectedOrder];

            
            for (int i=0; i<dataGridView3.RowCount; i++) {
                if (comboBox1.SelectedValue.Equals(dataGridView3[0, i].Value)) {
                    dataGridView3.ClearSelection();
                    dataGridView3.CurrentCell = dataGridView3[2, i];
                    break;
                }
            }

            aboutOrder = new AboutOrder(dataGridView1.CurrentRow, dataGridView3.CurrentRow, dataGridView2.CurrentRow);
            aboutOrder.Show();

        }
    }
}
