using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlamaresChristianJoshuaPtask
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            this.Load += new EventHandler(Orders_Load);
        }
        private void Orders_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "FoodList.txt");

            FoodOrderList.Items.Clear();
            if (File.Exists(filePath))
            {
                string[] products = File.ReadAllLines(filePath);
                FoodOrderList.Items.AddRange(products);
            }

            string drinkPath = Path.Combine(Application.StartupPath, "DrinkList.txt");

            DrinkOrderList.Items.Clear();
            if (File.Exists(drinkPath))
            {
                string[] drinks = File.ReadAllLines(drinkPath);
                DrinkOrderList.Items.AddRange(drinks);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessOrder processOrder = new ProcessOrder();
            processOrder.ShowDialog();
        }

        private void FoodOrderList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
