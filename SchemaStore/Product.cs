using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data;

namespace SchemaStore
{
    public partial class Product : Form
    {

        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Товар' table. You can move, or remove it, as needed.
            this.товарTableAdapter.Fill(this.databaseDataSet.Товар);
        }

        // open price's file
        private void button1_Click(object sender, EventArgs e)
        {
            LoadingWindow loadingWindow = new LoadingWindow();
            // Display form modelessly
            loadingWindow.Show();
            loadDataFromExcel();
            loadingWindow.Close();
            if (dataGridView2.ColumnCount > 0 && dataGridView2.RowCount > 0)
            {
                moveDataFromFilegridToDatagrid();
                MessageBox.Show("Данные загружены.\r\n" +
                    "Проверьте правильность и сохраните изменения в базе.");
            }

        }

        private void moveDataFromFilegridToDatagrid()
        {
            int rowCount = dataGridView2.RowCount;
            for (int i = 0; i < rowCount - 1; i++)
            {
                DataGridViewCell nnCell = dataGridView2[0, i];
                DataGridViewRow existingRow = getRowFromDatagridByPRoductNN(nnCell);
                //update info
                if (existingRow != null)
                {
                    for (int col = 0; col < 9; col++)
                    {
                        existingRow.Cells[col].Value = dataGridView2[col, i].Value;
                    }
                }
                //create product
                else
                {
                    try
                    {
                        DataGridViewRow rowWithInfo = dataGridView2.Rows[i];
                        DataRowView row = (DataRowView)товарBindingSource.AddNew();

                        row[0] = int.Parse(rowWithInfo.Cells[0].Value.ToString());
                        for (int col = 1; col < 9; col++)
                        {
                            row[col] = rowWithInfo.Cells[col].Value;
                        }

                        товарBindingSource.EndEdit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private DataGridViewRow getRowFromDatagridByPRoductNN(DataGridViewCell nnCell)
        {

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                try
                {
                    int currentNN = int.Parse(nnCell.Value.ToString());
                    int readedNN = int.Parse(dataGridView1[0, i].Value.ToString());
                    if (readedNN.Equals(currentNN))
                    {
                        return dataGridView1.Rows[i];
                    }
                }
                catch (Exception e) { return null; }
            }
            return null;
        }

        private void loadDataFromExcel()
        {
            string fileName = null;
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select Excel file with product price";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fileName = fdlg.FileName;
            }
            else
            {
                return;
            }


            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = 11;

            dataGridView2.ColumnCount = colCount;
            dataGridView2.RowCount = rowCount;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    //write the value to the Grid  
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        dataGridView2.Rows[i - 1].Cells[j - 1].Value = xlRange.Cells[i, j].Value2.ToString();
                    }
                }
            }
            // remove empty cols from file
            dataGridView2.Rows.RemoveAt(0);
            dataGridView2.Rows.RemoveAt(0);
            dataGridView2.Columns.RemoveAt(6);
            dataGridView2.Columns.RemoveAt(4);

            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            xlApp.Quit();
        }

        // save button
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
                    товарTableAdapter.Update(databaseDataSet.Товар);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // close form
        private void Product_FormClosing(object sender, FormClosingEventArgs e)
        {
            Runner.ShowForm();
        }

        // button back
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            товарBindingSource.Filter = dataGridView1.Columns[1].HeaderText.ToString() + " LIKE '%" + textBox1.Text + "%'";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            товарBindingSource.RemoveFilter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AboutProduct().Show();
        }
    }
}
