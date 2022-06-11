using Microsoft.Office.Interop.Excel;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SchemaStore
{
    public partial class TEST : Form
    {
        public TEST()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            Workbook xlWorkbook = xlApp.Workbooks.Open(fileName);
            _Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = 11;

            dataGridView1.ColumnCount = colCount;
            dataGridView1.RowCount = rowCount;







            int number = 22;
            int count = 0;

            double allPrice = 0;
            double ndsPrice = 0;
            double priceWidhNds = 0;


            for (int i = 0; i < dataGridView3.Rows.Count; i++) {
                Range cellRange = xlWorksheet.Cells[number, 1];
                Range rowRange = cellRange.EntireRow;
                rowRange.Insert(XlInsertShiftDirection.xlShiftDown, false);
                // №
                xlWorksheet.Cells[number, 1] = i+1;
                // name
                xlWorksheet.Cells[number, 2] = dataGridView3.Rows[i].Cells[2].Value;
                // ed ism
                xlWorksheet.Cells[number, 3] = "шт.";
                // count
                xlWorksheet.Cells[number, 4] = dataGridView3.Rows[i].Cells[3].Value;
                count = count + int.Parse(dataGridView3.Rows[i].Cells[3].Value.ToString());
                // price
                xlWorksheet.Cells[number, 5] = dataGridView3.Rows[i].Cells[5].Value;
                // all price
                xlWorksheet.Cells[number, 6] = dataGridView3.Rows[i].Cells[6].Value;
                allPrice = allPrice + int.Parse(dataGridView3.Rows[i].Cells[6].Value.ToString());
                // nds price
                xlWorksheet.Cells[number, 7] = double.Parse(dataGridView3.Rows[i].Cells[6].Value.ToString()) * 0.2;
                ndsPrice = ndsPrice + double.Parse(dataGridView3.Rows[i].Cells[6].Value.ToString()) * 0.2;
                // price s nds
                xlWorksheet.Cells[number, 8] = double.Parse(dataGridView3.Rows[i].Cells[6].Value.ToString()) * 1.2;
                priceWidhNds = allPrice + double.Parse(dataGridView3.Rows[i].Cells[6].Value.ToString()) * 1.2;
                // 
                number++;

            }
            //number = number + dataGridView3.Rows.Count;

            xlWorksheet.Cells[number, 4] = count;
            xlWorksheet.Cells[number, 6] = allPrice;
            xlWorksheet.Cells[number, 7] = ndsPrice;
            xlWorksheet.Cells[number, 8] = priceWidhNds;

            // 13,3
            string schetData = "Счет №ТТ-1 от " + dataGridView2.CurrentRow.Cells[9].Value;
            // 15,1 - 16,2
            string platelshik = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            // 17,1 - 18,2
            string grusopolushatel = dataGridView2.CurrentRow.Cells[8].Value.ToString();
            // all naimen
            string allNaimen = $"Всего наименований {dataGridView3.Rows.Count}, на сумму {priceWidhNds} руб.";



            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    try
                    {
                        dataGridView1.Rows[i - 1].Cells[j - 1].Value = xlRange.Cells[i, j].Value2.ToString();
                    }
                    catch (Exception ex) { }
                }
            }

            //Marshal.ReleaseComObject(xlRange);
            //Marshal.ReleaseComObject(xlWorksheet);

            //xlApp.Quit();
        }

        private void TEST_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Товар' table. You can move, or remove it, as needed.
            this.товарTableAdapter.Fill(this.databaseDataSet.Товар);
            // TODO: This line of code loads data into the 'databaseDataSet.ТоварыЗаказа' table. You can move, or remove it, as needed.
            this.товарыЗаказаTableAdapter.Fill(this.databaseDataSet.ТоварыЗаказа);
            // TODO: This line of code loads data into the 'databaseDataSet.Заказ' table. You can move, or remove it, as needed.
            this.заказTableAdapter.Fill(this.databaseDataSet.Заказ);

        }
    }
}
