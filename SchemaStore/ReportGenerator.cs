using Microsoft.Office.Interop.Excel;
using System;
using System.Windows.Forms;

namespace SchemaStore
{
    public partial class ReportGenerator : Form
    {      

        public void generateReport(int orderID, int grusopolushID, int customerID)
        {
            LoadingWindow loading = new LoadingWindow();
            loading.Show();

            InitializeComponent();


            заказTableAdapter.FillByID(databaseDataSet.Заказ, orderID);
            товарыЗаказаTableAdapter.FillByOrderId(databaseDataSet.ТоварыЗаказа, orderID);
            заказчикГрузополучательTableAdapter.FillByID(databaseDataSet.ЗаказчикГрузополучатель, grusopolushID);
            заказчикTableAdapter.FillByID(databaseDataSet.Заказчик, customerID);

            string fileName = "card.xlsx";


            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(fileName);
            _Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Range xlRange = xlWorksheet.UsedRange;



            int number = 22;
            int count = 0;

            double allPrice = 0;
            double ndsPrice = 0;
            double priceWidhNds = 0;


            //for (int i = 0; i < productGrid.Rows.Count; i++)
            //{
            //    Range cellRange = xlWorksheet.Cells[number, 1];
            //    Range rowRange = cellRange.EntireRow;
            //    rowRange.Insert(XlInsertShiftDirection.xlShiftDown, false);
            //    // №
            //    xlWorksheet.Cells[number, 1] = i + 1;
            //    // name
            //    xlWorksheet.Cells[number, 2] = productGrid.Rows[i].Cells[2].Value;
            //    // ed ism
            //    xlWorksheet.Cells[number, 3] = "шт.";
            //    // count
            //    xlWorksheet.Cells[number, 4] = productGrid.Rows[i].Cells[3].Value;
            //    count = count + int.Parse(productGrid.Rows[i].Cells[3].Value.ToString());
            //    // price
            //    xlWorksheet.Cells[number, 5] = productGrid.Rows[i].Cells[5].Value;
            //    // all price
            //    xlWorksheet.Cells[number, 6] = productGrid.Rows[i].Cells[6].Value;
            //    allPrice = allPrice + int.Parse(productGrid.Rows[i].Cells[6].Value.ToString());
            //    // nds price
            //    xlWorksheet.Cells[number, 7] = double.Parse(productGrid.Rows[i].Cells[6].Value.ToString()) * 0.2;
            //    ndsPrice = ndsPrice + double.Parse(productGrid.Rows[i].Cells[6].Value.ToString()) * 0.2;
            //    // price s nds
            //    xlWorksheet.Cells[number, 8] = double.Parse(productGrid.Rows[i].Cells[6].Value.ToString()) * 1.2;
            //    priceWidhNds = allPrice + double.Parse(productGrid.Rows[i].Cells[6].Value.ToString()) * 1.2;
            //    // 
            //    number++;

            //}

            xlWorksheet.Cells[number, 4] = count;
            xlWorksheet.Cells[number, 6] = allPrice;
            xlWorksheet.Cells[number, 7] = ndsPrice;
            xlWorksheet.Cells[number, 8] = priceWidhNds;




            // 13,3
            string schetData = "Счет №ТТ-1 от " + orderGrid.Rows[0].Cells[9].Value;
            // 15,1 - 16,2
            string platelсhikName = customerGrid.CurrentRow.Cells[1].Value.ToString();
            string platelсhikAdres = $"{customerGrid.CurrentRow.Cells[3].Value.ToString()}, " +
                $"{customerGrid.CurrentRow.Cells[2].Value.ToString()}; " +
                $"ИНН {customerGrid.CurrentRow.Cells[4].Value.ToString()}, " +
                $"КПП {customerGrid.CurrentRow.Cells[5].Value.ToString()}";
            // 17,1 - 18,2
            string grusopolushatelName = grusoGrid.CurrentRow.Cells[2].Value.ToString();
            string grusopolushatelAdres = $"{grusoGrid.CurrentRow.Cells[4].Value.ToString()}, " +
                $"{grusoGrid.CurrentRow.Cells[3].Value.ToString()}; " +
                $"ИНН {grusoGrid.CurrentRow.Cells[5].Value.ToString()}, " +
                $"КПП {grusoGrid.CurrentRow.Cells[6].Value.ToString()}";


            xlWorksheet.Cells[13, 3] = schetData;
            xlWorksheet.Cells[15, 1] = "Плательщик: " + platelсhikName;
            xlWorksheet.Cells[16, 2] = platelсhikAdres;
            xlWorksheet.Cells[17, 1] = "Грузополучатель: " + grusopolushatelName;
            xlWorksheet.Cells[18, 2] = grusopolushatelAdres;

            // all naimen
            string allNaimen = $"Всего наименований {productGrid.Rows.Count}, на сумму {priceWidhNds} руб.";
            number = number + 2;
            xlWorksheet.Cells[number, 1] = allNaimen;


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel Files|*.xlsx;";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName =
                "Плательщик " + platelсhikName.Replace("\'", "").Replace("\"", "")
                + ", " + schetData.Replace("/", "-").Replace(":", "-");

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xlApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName);
            }
            try
            {
                //xlWorkbook.RejectAllChanges();
                object misValue = System.Reflection.Missing.Value;
                xlWorkbook.Close(false, misValue, misValue);
            }
            catch (Exception ex) { }
            xlApp.Quit();


            loading.Close();

            this.Close();
        }

        private void TEST_Load(object sender, EventArgs e)
        {
            this.заказчикГрузополучательTableAdapter.Fill(this.databaseDataSet.ЗаказчикГрузополучатель);
            this.заказчикTableAdapter.Fill(this.databaseDataSet.Заказчик);
            this.товарыЗаказаTableAdapter.Fill(this.databaseDataSet.ТоварыЗаказа);
            this.заказTableAdapter.Fill(this.databaseDataSet.Заказ);
        }
    }
}
