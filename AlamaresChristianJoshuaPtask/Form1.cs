namespace AlamaresChristianJoshuaPtask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            product.ShowDialog();
        }
    }
}
