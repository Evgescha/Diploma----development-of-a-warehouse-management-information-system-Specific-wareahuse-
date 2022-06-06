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
            this.товарTableAdapter.Fill(this.databaseDataSet1.Товар);
            this.складТоварНнИНазваниеTableAdapter.Fill(this.databaseDataSet.СкладТоварНнИНазвание);
            loadData();
            comboBox1_SelectedIndexChanged(null, null);
        }
        private void loadData()
        {
            this.складTableAdapter.Fill(this.databaseDataSet.Склад);
            this.заказчикГрузополучательTableAdapter.Fill(this.databaseDataSet.ЗаказчикГрузополучатель);
            this.заказчикTableAdapter.Fill(this.databaseDataSet.Заказчик);
            this.товарыЗаказаTableAdapter.Fill(this.databaseDataSet.ТоварыЗаказа);
            this.заказTableAdapter.Fill(this.databaseDataSet.Заказ);
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
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1[2, i].Value == null) dataGridView1[2, i].Value = DateTime.Now;
                        if (dataGridView1[3, i].Value == null) dataGridView1[3, i].Value = "Предзаказ";
                        if (dataGridView1[5, i].Value == null) dataGridView1[5, i].Value = 0;
                    }

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
            if (!isAllFill())
            {
                MessageBox.Show("Не выбран заказ или не все поля заполнены");
                return;
            }

            addNewProductInOrderProductTable();

            int count = int.Parse(textBox1.Text);
            //update count product on warehause if order not in preorder
            if (!dataGridView1.CurrentRow.Cells[3].Value.Equals("Предзаказ"))
            {
                removeCountProductFromWarehouseOrAddNewLine(int.Parse(comboBox1.SelectedValue.ToString()), count);
            }
            //update count pre-ordering product on warehause if order status is preorder
            if (dataGridView1.CurrentRow.Cells[3].Value.Equals("Предзаказ"))
            {
                addCountPreorderProductInWarehouseOrAddNewLine(int.Parse(comboBox1.SelectedValue.ToString()), count);
            }

            updateAllSummWithCurrentPrice();

            loadData();
            comboBox1_SelectedIndexChanged(null, null);
        }

        private void updateAllSummWithCurrentPrice()
        {
            double newPrice = 0;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                newPrice += double.Parse(dataGridView2[6, i].Value.ToString());
            }

            dataGridView1.CurrentRow.Cells[5].Value = newPrice ;
            dataGridView1.CurrentRow.Cells[6].Value = newPrice * 1.2;
            dataGridView1.EndEdit();
            заказBindingSource.EndEdit();
            заказTableAdapter.Update(databaseDataSet.Заказ);

            //    //dataGridView1.CurrentCell = temp;
        }

        private void addNewProductInOrderProductTable()
        {
            DataRowView row = (DataRowView)заказТоварыЗаказаBindingSource.AddNew();
            row[2] = comboBox1.SelectedValue;
            row[3] = int.Parse(textBox1.Text);
            row[4] = double.Parse(textBox2.Text);
            row[5] = double.Parse(textBox3.Text);
            row[6] = double.Parse(textBox4.Text);

            заказТоварыЗаказаBindingSource.EndEdit();
            товарыЗаказаTableAdapter.Update(databaseDataSet.ТоварыЗаказа);
        }

        private void removeCountProductFromWarehouseOrAddNewLine(int productNN, int count)
        {
            //add new line
            if (dataGridView3.RowCount != 0)
            {
                dataGridView3[1, 0].Value = int.Parse(dataGridView3[1, 0].Value.ToString()) - count;
                складBindingSource.EndEdit();
                складTableAdapter.Update(databaseDataSet.Склад);
            }
            //edit current line
            else
            {
                DataRowView row = (DataRowView)складBindingSource.AddNew();
                row[0] = productNN;
                row[1] = -count;
                складBindingSource.EndEdit();
                складTableAdapter.Update(databaseDataSet.Склад);
            }
        }


        private void addCountPreorderProductInWarehouseOrAddNewLine(int productNN, int count)
        {
            //add new line
            if (dataGridView3.RowCount != 0)
            {
                dataGridView3[3, 0].Value = int.Parse(dataGridView3[3, 0].Value.ToString()) + count;
                складBindingSource.EndEdit();
                складTableAdapter.Update(databaseDataSet.Склад);
            }
            //edit current line
            else
            {
                DataRowView row = (DataRowView)складBindingSource.AddNew();
                row[0] = productNN;
                row[3] = count;
                складBindingSource.EndEdit();
                складTableAdapter.Update(databaseDataSet.Склад);
            }

        }

        private bool isAllFill()
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.RowCount == 0) return false;
            if (comboBox1.SelectedItem == null || textBox1.Text.Length == 0 || textBox3.Text.Length == 0) return false;

            return true;
        }

        private void countOrPriceChanged(object sender, EventArgs e)
        {
            try
            {
                int count = textBox1.Text.Length == 0 ? 0 : int.Parse(textBox1.Text);
                double price;
                if (dataGridView4.RowCount > 0)
                {
                    if (count <= 9)
                        price = double.Parse(dataGridView4[5, 0].Value.ToString());
                    else if (count <= 49)
                        price = double.Parse(dataGridView4[6, 0].Value.ToString());
                    else if (count <= 99)
                        price = double.Parse(dataGridView4[7, 0].Value.ToString());
                    else
                        price = double.Parse(dataGridView4[8, 0].Value.ToString());
                }
                else
                {
                    price = 0;
                }
                textBox2.Text = price + "";
                textBox3.Text = price + "";

                double sum = count * price;
                textBox4.Text = sum + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // remove product from order btn
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.CurrentRow == null || dataGridView2.Rows.Count == 0)
                {
                    MessageBox.Show("Не выбран товар для удаления из заказа");
                    return;
                }

                int productNN = int.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString());
                int count = int.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString());

                this.складTableAdapter.FillByProductId(this.databaseDataSet.Склад, int.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString()));

                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                заказТоварыЗаказаBindingSource.EndEdit();
                товарыЗаказаTableAdapter.Update(databaseDataSet.ТоварыЗаказа);

                //update count product on warehause if order not in preorder
                if (!dataGridView1.CurrentRow.Cells[3].Value.Equals("Предзаказ"))
                {
                    removeCountProductFromWarehouseOrAddNewLine(productNN, -count);
                }

                //update count pre-ordering product on warehause if order status is preorder
                if (dataGridView1.CurrentRow.Cells[3].Value.Equals("Предзаказ"))
                {
                    addCountPreorderProductInWarehouseOrAddNewLine(productNN, -count);
                }

                updateAllSummWithCurrentPrice();

            }
            catch (Exception ex) { }
            loadData();
            comboBox1_SelectedIndexChanged(null, null);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.товарTableAdapter.FillByProductId(this.databaseDataSet1.Товар, int.Parse(comboBox1.SelectedValue.ToString()));
                this.складTableAdapter.FillByProductId(this.databaseDataSet.Склад, int.Parse(comboBox1.SelectedValue.ToString()));
                if (dataGridView3.RowCount > 0)
                {
                    w1.Text = int.Parse(dataGridView3[1, 0].Value.ToString()) + "";
                    w2.Text = int.Parse(dataGridView3[3, 0].Value.ToString()) + "";
                    w3.Text = int.Parse(dataGridView3[4, 0].Value.ToString()) + "";
                    w4.Text = int.Parse(dataGridView3[5, 0].Value.ToString()) + "";
                }
                else
                {
                    w1.Text = "0";
                    w2.Text = "0";
                    w3.Text = "0";
                    w4.Text = "0";
                }

                countOrPriceChanged(null, null);
            }
            catch (Exception ex) {  }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.складTableAdapter.FillByProductId(this.databaseDataSet.Склад, int.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString()));
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.складTableAdapter.FillByProductId(this.databaseDataSet.Склад, int.Parse(comboBox1.SelectedValue.ToString()));
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
