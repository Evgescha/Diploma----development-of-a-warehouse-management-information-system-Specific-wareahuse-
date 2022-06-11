using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchemaStore
{
    public partial class AboutProduct : Form
    {
        List<ProductDto> list = new List<ProductDto>();

        public AboutProduct()
        {
            InitializeComponent();
        }

        private void AboutProduct_Load(object sender, EventArgs e)
        {
            закупленныеТоварыTableAdapter.Fill(databaseDataSet.ЗакупленныеТовары);
            проданныеТоварыTableAdapter.Fill(databaseDataSet.ПроданныеТовары);
            складTableAdapter.Fill(databaseDataSet.Склад);
            товарTableAdapter.Fill(databaseDataSet.Товар);

            dataGridView6.RowCount = dataGridView3.RowCount;

            initialData();

            for (int i = 0; i < dataGridView3.Rows.Count-1; i++) {
                dataGridView6[0, i].Value = dataGridView1[0, i].Value;
                dataGridView6[1, i].Value = dataGridView1[1, i].Value;
                for (int j = 1; j < 8; j++) {
                    dataGridView6[j+1, i].Value = dataGridView3[j, i].Value;
                }
            }
        }

        private void initialData()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                loadGridAboutProduct(i);
                updateCurrentProductInfo(i);
            }
        }

        private void updateCurrentProductInfo(int i)
        {
            int ostatok = 0;
            int order = 0;
            int preorder = 0;
            int virtualOstatok = 0;
            if (dataGridView2.Rows.Count != 0)
            {
                ostatok = parseInt(dataGridView2[1, 0].Value); 
                order = parseInt(dataGridView2[3, 0].Value);
                preorder = parseInt(dataGridView2[4, 0].Value);
                virtualOstatok = parseInt(dataGridView2[5, 0].Value);
            }

            int orderedCount = 0;
            double orderedSum = 0;
            if (dataGridView4.Rows.Count != 0)
            {
                orderedCount = parseInt(dataGridView4[1, 0].Value);
                orderedSum = parseDouble(dataGridView4[2, 0].Value);
            }


            int deliveredCount = 0;
            double deliveredSum = 0;
            if (dataGridView5.Rows.Count != 0)
            {
                deliveredCount = parseInt(dataGridView5[1, 0].Value);
                deliveredSum = parseDouble(dataGridView5[2, 0].Value);
            }


            dataGridView3[1, i].Value = ostatok;
            dataGridView3[2, i].Value = order;
            dataGridView3[3, i].Value = preorder;
            dataGridView3[4, i].Value = virtualOstatok;
            dataGridView3[5, i].Value = orderedCount;
            dataGridView3[6, i].Value = orderedSum;
            dataGridView3[7, i].Value = deliveredCount;
            dataGridView3[8, i].Value = deliveredSum;

        }

        private void loadGridAboutProduct(int i)
        {
            // load all datagrid
            int productNN = int.Parse(dataGridView1[0, i].Value.ToString());
            // 5 grid
            закупленныеТоварыTableAdapter.FillByProductNN(databaseDataSet.ЗакупленныеТовары, productNN);
            // 4 grid
            проданныеТоварыTableAdapter.FillByProductNN(databaseDataSet.ПроданныеТовары, productNN);
            // 2 grid
            складTableAdapter.FillByProductId(databaseDataSet.Склад, productNN);
        }

        private int parseInt(object cellValue)
        {
            try { return int.Parse(cellValue.ToString()); } catch (Exception ex) { return 0; }
        }

        private double parseDouble(object cellValue)
        {
            try { return double.Parse(cellValue.ToString()); } catch (Exception ex) { return 0; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int productNN = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            for (int i = 0; i < dataGridView6.Rows.Count; i++) {
                try {
                    int secondProductNN = int.Parse(dataGridView6.Rows[i].Cells[0].Value.ToString());
                    if (productNN == secondProductNN) {
                        dataGridView6.CurrentCell = dataGridView6.Rows[i].Cells[0];
                    }
                } catch (Exception ex) { }
            }

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int productNN = int.Parse(dataGridView6.CurrentRow.Cells[0].Value.ToString());
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    int secondProductNN = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    if (productNN == secondProductNN)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                    }
                }
                catch (Exception ex) { }
            }
        }
    }
}
