using System;
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
            // TODO: This line of code loads data into the 'databaseDataSet.Товар' table. You can move, or remove it, as needed.
            this.товарTableAdapter.Fill(this.databaseDataSet.Товар);
            // TODO: This line of code loads data into the 'databaseDataSet.Склад' table. You can move, or remove it, as needed.
            this.складTableAdapter.Fill(this.databaseDataSet.Склад);
            // TODO: This line of code loads data into the 'databaseDataSet.ТоварыПоставки' table. You can move, or remove it, as needed.
            this.товарыПоставкиTableAdapter.Fill(this.databaseDataSet.ТоварыПоставки);
            // TODO: This line of code loads data into the 'databaseDataSet.Поставка' table. You can move, or remove it, as needed.
            this.поставкаTableAdapter.Fill(this.databaseDataSet.Поставка);
            // TODO: This line of code loads data into the 'databaseDataSet.СкладТоварНнИНазвание' table. You can move, or remove it, as needed.
            this.складТоварНнИНазваниеTableAdapter.Fill(this.databaseDataSet.СкладТоварНнИНазвание);
            loadData();
        }
        private void loadData()
        {
            comboBox1_SelectedIndexChanged(null, null);
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
                    //поставкаTableAdapter.Update(databaseDataSet.Поставка);
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (!isAllFill())
            {
                MessageBox.Show("Не выбран заказ или не все поля заполнены");
                return;
            }
        }
        private bool isAllFill()
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.RowCount == 0) return false;
            if (comboBox1.SelectedItem == null || textBox1.Text.Length == 0) return false;

            return true;
        }
        // update 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
