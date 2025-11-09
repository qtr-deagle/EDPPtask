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
    public partial class AddFood : Form
    {
        private Products _productsForm;

        public AddFood(Products productsForm)
        {
            InitializeComponent();
            _productsForm = productsForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string foodName = AddFoodBox.Text.Trim();
            string priceText = FoodPrice.Text.Trim();

            if (!string.IsNullOrEmpty(foodName) && !string.IsNullOrEmpty(priceText))
            {
                if (decimal.TryParse(priceText, out decimal price))
                {
                    string filePath = Path.Combine(Application.StartupPath, "FoodList.txt");

                    string entry = $"{foodName} - {price}";
                    File.AppendAllText(filePath, entry + Environment.NewLine);

                    Result.Text = "Food added successfully!";
                    Result.ForeColor = Color.Green;

                    AddFoodBox.Text = "";
                    FoodPrice.Text = "";
                    AddFoodBox.Focus();

                    _productsForm.RefreshFoodList();
                }
                else
                {
                    Result.Text = "Price must be a number.";
                    Result.ForeColor = Color.Red;
                }
            }
            else
            {
                Result.Text = "Enter food name and price.";
                Result.ForeColor = Color.Red;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddFood_Load(object sender, EventArgs e)
        {

        }
    }
}
