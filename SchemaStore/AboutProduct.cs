using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchemaStore
{
    public partial class AboutProduct : Form
    {
        public AboutProduct()
        {
            InitializeComponent();
        }

        private void AboutProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Склад' table. You can move, or remove it, as needed.
            this.складTableAdapter.Fill(this.databaseDataSet.Склад);
            // TODO: This line of code loads data into the 'databaseDataSet.Товар' table. You can move, or remove it, as needed.
            this.товарTableAdapter.Fill(this.databaseDataSet.Товар);

        }
    }
}
