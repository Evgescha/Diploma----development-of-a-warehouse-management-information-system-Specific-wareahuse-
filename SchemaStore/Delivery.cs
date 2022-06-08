using System;
using System.Data;
using System.Drawing;
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
            this.товарTableAdapter.Fill(this.databaseDataSet.Товар);
            this.складTableAdapter.Fill(this.databaseDataSet.Склад);
            this.товарыПоставкиTableAdapter.Fill(this.databaseDataSet.ТоварыПоставки);
            this.поставкаTableAdapter.Fill(this.databaseDataSet.Поставка);
            this.складТоварНнИНазваниеTableAdapter.Fill(this.databaseDataSet.СкладТоварНнИНазвание);
            updateInfoAboutSelectedPRoduct(null, null);
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры, клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        //btn add
        private void button4_Click(object sender, EventArgs e)
        {
            if (!isAllFill())
            {
                MessageBox.Show("Не выбран заказ или не все поля заполнены");
                return;
            }


            int count = int.Parse(textBox1.Text);
            double price = double.Parse(textBox2.Text);
            int productNN = int.Parse(comboBox1.SelectedValue.ToString());

            addNewProductInDeliveryProductTable(productNN, count, price);

            addSummToDeliveryOrder(price*count);

            if (dataGridView1.CurrentRow.Cells[3].Value.ToString().Equals("В процессе"))
            {
                addCountPreorderProductInWarehouseOrAddNewLine(productNN, count);
            }
            else
            {
                addCountProductToStoreInWarehouseOrAddNewLine(productNN, count);
            }

            this.товарыПоставкиTableAdapter.Fill(this.databaseDataSet.ТоварыПоставки);
            updateInfoAboutSelectedPRoduct(null, null);

        }

        private bool isAllFill()
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.RowCount == 0) return false;
            if (comboBox1.SelectedItem == null || textBox1.Text.Length == 0) return false;

            return true;
        }
        // update 
        private void updateInfoAboutSelectedPRoduct(object sender, EventArgs e)
        {
            try
            {
                this.товарTableAdapter.FillByProductId(this.databaseDataSet.Товар, int.Parse(comboBox1.SelectedValue.ToString()));
                this.складTableAdapter.FillByProductId(this.databaseDataSet.Склад, int.Parse(comboBox1.SelectedValue.ToString()));
                textBox2.Text = dataGridView3[4, 0].Value.ToString();
                if (dataGridView3.RowCount > 0)
                {
                    w1.Text = int.Parse(dataGridView4[1, 0].Value.ToString()) + "";
                    w2.Text = int.Parse(dataGridView4[3, 0].Value.ToString()) + "";
                    w3.Text = int.Parse(dataGridView4[4, 0].Value.ToString()) + "";
                    w4.Text = int.Parse(dataGridView4[5, 0].Value.ToString()) + "";
                }
                else
                {
                    w1.Text = "0";
                    w2.Text = "0";
                    w3.Text = "0";
                    w4.Text = "0";
                }
            }
            catch (Exception ex) {
                w1.Text = "0";
                w2.Text = "0";
                w3.Text = "0";
                w4.Text = "0";
            }
        }

        private void w1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                w1.ForeColor = int.Parse(w1.Text) < 0 ? Color.Red : Color.Black;
                w2.ForeColor = int.Parse(w2.Text) < 0 ? Color.Red : Color.Black;
                w3.ForeColor = int.Parse(w3.Text) < 0 ? Color.Red : Color.Black;
                w4.ForeColor = int.Parse(w4.Text) < 0 ? Color.Red : Color.Black;
            }
            catch (Exception ex) { }
        }


        private void addNewProductInDeliveryProductTable(int productNN, int count, double price)
        {

            DataRowView row = (DataRowView)поставкаТоварыПоставкиBindingSource.AddNew();
            row[2] = productNN;
            row[3] = count;
            row[4] = price;
            row[5] = count*price;

            поставкаТоварыПоставкиBindingSource.EndEdit();
            товарыПоставкиTableAdapter.Update(databaseDataSet.ТоварыПоставки);
        }

        private void addSummToDeliveryOrder(double price)
        {
            try
            {
                double priceNow = double.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                dataGridView1.CurrentRow.Cells[5].Value = priceNow + price;

                dataGridView1.CurrentCell = null;
                dataGridView1.EndEdit();
                поставкаTableAdapter.Update(databaseDataSet.Поставка);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void addCountPreorderProductInWarehouseOrAddNewLine(int productNN, int count)
        {
            //edit current line
            if (dataGridView4.RowCount > 1)
            {
                dataGridView4.Rows[0].Cells[4].Value = int.Parse(dataGridView4.Rows[0].Cells[4].Value.ToString()) + count;
            }
            //add new line
            else
            {
                DataRowView row = (DataRowView)складBindingSource.AddNew();
                row[0] = productNN;
                row[4] = count;
            }
            складBindingSource.EndEdit();
            складTableAdapter.Update(databaseDataSet.Склад);
        }


        private void addCountProductToStoreInWarehouseOrAddNewLine(int productNN, int count)
        {
            //edit current line
            if (dataGridView4.RowCount > 1)
            {
                dataGridView4.Rows[0].Cells[1].Value = int.Parse(dataGridView4.Rows[0].Cells[1].Value.ToString()) + count;
            }
            //add new line
            else
            {
                DataRowView row = (DataRowView)складBindingSource.AddNew();
                row[0] = productNN;
                row[1] = count;
            }
            складBindingSource.EndEdit();
            складTableAdapter.Update(databaseDataSet.Склад);
        }
        // delete btn
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
                double price = double.Parse(dataGridView2.CurrentRow.Cells[5].Value.ToString());
                price = -1 * price;

                this.складTableAdapter.FillByProductId(this.databaseDataSet.Склад, productNN);

                removeProductInDeliveryProductTable();

                addSummToDeliveryOrder(price * count);

                if (dataGridView1.CurrentRow.Cells[3].Value.ToString().Equals("В процессе"))
                {
                    addCountPreorderProductInWarehouseOrAddNewLine(productNN, -count);
                }
                else
                {
                    addCountProductToStoreInWarehouseOrAddNewLine(productNN, -count);
                }

                this.товарыПоставкиTableAdapter.Fill(this.databaseDataSet.ТоварыПоставки);
                updateInfoAboutSelectedPRoduct(null, null);
            }
            catch (Exception ex) { }
        }

        private void removeProductInDeliveryProductTable()
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            поставкаТоварыПоставкиBindingSource.EndEdit();
            товарыПоставкиTableAdapter.Update(databaseDataSet.ТоварыПоставки);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int count = textBox1.Text.Length == 0 ? 0 : int.Parse(textBox1.Text);
                double price;
                if (dataGridView3.RowCount > 0)
                {
                    price = double.Parse(dataGridView3[4, 0].Value.ToString());
                }
                else
                {
                    price = 0;
                }

                double sum = count * price;
                textBox4.Text = sum + "";
            }
            catch (Exception ex)
            {
               
            }
        }
    }
}
