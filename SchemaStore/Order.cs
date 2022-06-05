using System;
using System.Data;
using System.Windows.Forms;

namespace SchemaStore
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.СкладТоварНнИНазвание' table. You can move, or remove it, as needed.
            this.складТоварНнИНазваниеTableAdapter.Fill(this.databaseDataSet.СкладТоварНнИНазвание);
            // TODO: This line of code loads data into the 'databaseDataSet.ЗаказчикГрузополучатель' table. You can move, or remove it, as needed.
            this.заказчикГрузополучательTableAdapter.Fill(this.databaseDataSet.ЗаказчикГрузополучатель);
            // TODO: This line of code loads data into the 'databaseDataSet.Заказчик' table. You can move, or remove it, as needed.
            this.заказчикTableAdapter.Fill(this.databaseDataSet.Заказчик);
            // TODO: This line of code loads data into the 'databaseDataSet.ТоварыЗаказа' table. You can move, or remove it, as needed.
            this.товарыЗаказаTableAdapter.Fill(this.databaseDataSet.ТоварыЗаказа);
            // TODO: This line of code loads data into the 'databaseDataSet.Заказ' table. You can move, or remove it, as needed.
            this.заказTableAdapter.Fill(this.databaseDataSet.Заказ);

            loadData();
        }
        private void loadData() {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            Runner.ShowForm();
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
                    заказTableAdapter.Update(databaseDataSet.Заказ);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры, клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }
        //add new product in order
        private void button4_Click(object sender, EventArgs e)
        {
            if (!isAllFill()) {
                MessageBox.Show("Не выбран заказ или не все поля заполнены");
                return;
            }


            DataRowView row = (DataRowView)заказТоварыЗаказаBindingSource.AddNew();
            row[2] = comboBox1.SelectedValue;
            row[3] = double.Parse(textBox1.Text);
            row[4] = double.Parse(textBox2.Text);
            row[5] = double.Parse(textBox3.Text);
            row[6] = double.Parse(textBox4.Text);

            заказТоварыЗаказаBindingSource.EndEdit();
            товарыЗаказаTableAdapter.Update(databaseDataSet.ТоварыЗаказа);
            loadData();
        }

        private bool isAllFill()
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.RowCount == 0) return false;
            if (comboBox1.SelectedItem == null || textBox1.Text.Length==0 || textBox3.Text.Length ==0) return false;

            return true;
        }

        private void countOrPriceChanged(object sender, EventArgs e)
        {
            try {
                int count = int.Parse(textBox1.Text);
                double price = double.Parse(textBox3.Text);

                double sum = count * price;
                textBox4.Text = sum+"";
            } catch (Exception ex) { }
        }
        
        // remove product from order
        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null || dataGridView2.Rows.Count == 0) {
                MessageBox.Show("Не выбран товар для удаления из заказа");
                return;
            }
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            заказТоварыЗаказаBindingSource.EndEdit();
            try
            {
                товарыЗаказаTableAdapter.Update(databaseDataSet.ТоварыЗаказа);
            }
            catch (Exception ex) { }
            loadData();
        }
    }
}
