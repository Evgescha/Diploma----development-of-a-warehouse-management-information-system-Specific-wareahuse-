using System;
using System.Windows.Forms;

namespace SchemaStore
{
    public partial class Runner : Form
    {
        public static Runner runner;
        public static Product product;
        public static Customer customer;
        public static Warehouse warehouse;
        public static Order order;
        public static Delivery delivery;
        

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
            new TEST().Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            warehouse = new Warehouse();
            warehouse.Show();
            HideForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            order = new Order();
            order.Show();
            HideForm();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            delivery = new Delivery();
            delivery.Show();
            HideForm();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadingWindow loadingWindow = new LoadingWindow();
            loadingWindow.Show();
            new AboutProduct().Show();

            loadingWindow.Close();
        }
    }
}
