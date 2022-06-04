using System;
using System.Windows.Forms;

namespace SchemaStore
{
    public partial class Runner : Form
    {
        public static Runner runner;
        public static Product product;
        public static Customer customer;
        //public static;
        //public static;
        //public static;
        //public static;
        //public static;


        public static void ShowForm()
        {
            runner.Show();
        }
        public static void HideForm()
        {
            runner.Hide();
        }

        public Runner()
        {
            InitializeComponent();
            runner = this;
        }

        private void Runner_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            product = new Product();
            product.Show();
            HideForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer = new Customer();
            customer.Show();
            HideForm();
        }
    }
}
