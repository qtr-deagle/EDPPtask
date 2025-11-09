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
    public partial class RemoveDrink : Form
    {
        private Products _productsForm;

        public RemoveDrink(Products productsForm)
        {
            InitializeComponent();
            _productsForm = productsForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DrinkName = RemoveDrinkBox.Text.Trim();
            string filePath = Path.Combine(Application.StartupPath, "DrinkList.txt");

            if (!string.IsNullOrEmpty(DrinkName))
            {
                if (File.Exists(filePath))
                {
                    var products = File.ReadAllLines(filePath).ToList();

                    // Find line that starts with "DrinkName|"
                    var match = products.FirstOrDefault(p => p.StartsWith(DrinkName + " | ", StringComparison.OrdinalIgnoreCase));

                    if (match != null)
                    {
                        products.Remove(match);
                        File.WriteAllLines(filePath, products);

                        Result.Text = "Drink removed successfully!";
                        Result.ForeColor = Color.Green;

                        RemoveDrinkBox.Text = "";
                        RemoveDrinkBox.Focus();
                        _productsForm.RefreshDrinkList();
                    }
                    else
                    {
                        Result.Text = "Drink not found in the list.";
                        Result.ForeColor = Color.Red;
                    }
                }
                else
                {
                    Result.Text = "Product file not found.";
                    Result.ForeColor = Color.Red;
                }
            }
            else
            {
                Result.Text = "Enter Drink name to remove.";
                Result.ForeColor = Color.Red;
            }
        }

        private void RemoveDrinkBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }
    }
}
