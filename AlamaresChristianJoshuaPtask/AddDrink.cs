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
    public partial class AddDrink : Form
    {
        private Products _productsForm;
        public AddDrink(Products productsForm)
        {
            InitializeComponent();
            _productsForm = productsForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DrinkName = AddDrinkBox.Text.Trim();
            string priceText = DrinkPrice.Text.Trim();

            if (!string.IsNullOrEmpty(DrinkName) && !string.IsNullOrEmpty(priceText))
            {
                if (decimal.TryParse(priceText, out decimal price))
                {
                    string filePath = Path.Combine(Application.StartupPath, "DrinkList.txt");

                    string entry = $"{DrinkName} - {price}";
                    File.AppendAllText(filePath, entry + Environment.NewLine);

                    Result.Text = "Drink added successfully!";
                    Result.ForeColor = Color.Green;

                    AddDrinkBox.Text = "";
                    DrinkPrice.Text = "";
                    AddDrinkBox.Focus();

                    _productsForm.RefreshDrinkList();
                }
                else
                {
                    Result.Text = "Price must be a number.";
                    Result.ForeColor = Color.Red;
                }
            }
            else
            {
                Result.Text = "Enter Drink name and price.";
                Result.ForeColor = Color.Red;
            }
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }
    }
}
