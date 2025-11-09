using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AlamaresChristianJoshuaPtask
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            this.Load += new EventHandler(Products_Load);
        }

        private void Products_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "FoodList.txt");

            FoodProductList.Items.Clear();
            if (File.Exists(filePath))
            {
                string[] products = File.ReadAllLines(filePath);
                FoodProductList.Items.AddRange(products);
            }

            string drinkPath = Path.Combine(Application.StartupPath, "DrinkList.txt");

            DrinkProductList.Items.Clear();
            if (File.Exists(drinkPath))
            {
                string[] drinks = File.ReadAllLines(drinkPath);
                DrinkProductList.Items.AddRange(drinks);
            }
        }

        public void RefreshFoodList()
        {
            string filePath = Path.Combine(Application.StartupPath, "FoodList.txt");

            FoodProductList.Items.Clear();
            if (File.Exists(filePath))
            {
                string[] products = File.ReadAllLines(filePath);
                FoodProductList.Items.AddRange(products);
            }
        }
        public void RefreshDrinkList()
        {
            string drinkPath = Path.Combine(Application.StartupPath, "DrinkList.txt");

            DrinkProductList.Items.Clear();
            if (File.Exists(drinkPath))
            {
                string[] drinks = File.ReadAllLines(drinkPath);
                DrinkProductList.Items.AddRange(drinks);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveDrink removeDrink = new RemoveDrink(this);
            removeDrink.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood(this);
            addFood.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveFood removeFood = new RemoveFood(this);
            removeFood.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDrink addDrink = new AddDrink(this);
            addDrink.ShowDialog();
        }

        private void FoodProductList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DrinkProductList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
