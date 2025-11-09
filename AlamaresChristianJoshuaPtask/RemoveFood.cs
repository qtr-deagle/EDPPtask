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
    public partial class RemoveFood : Form
    {
        private Products _productsForm;

        public RemoveFood(Products productsForm)
        {
            InitializeComponent();
            _productsForm = productsForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string foodName = RemoveFoodBox.Text.Trim();
            string filePath = Path.Combine(Application.StartupPath, "FoodList.txt");

            if (!string.IsNullOrEmpty(foodName))
            {
                if (File.Exists(filePath))
                {
                    var products = File.ReadAllLines(filePath).ToList();

                    // Find line that starts with "foodName|"
                    var match = products.FirstOrDefault(p => p.StartsWith(foodName + " - ", StringComparison.OrdinalIgnoreCase));

                    if (match != null)
                    {
                        products.Remove(match);
                        File.WriteAllLines(filePath, products);

                        Result.Text = "Food removed successfully!";
                        Result.ForeColor = Color.Green;

                        RemoveFoodBox.Text = "";
                        RemoveFoodBox.Focus();
                        _productsForm.RefreshFoodList();
                    }
                    else
                    {
                        Result.Text = "Food not found in the list.";
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
                Result.Text = "Enter food name to remove.";
                Result.ForeColor = Color.Red;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RemoveFood_Load(object sender, EventArgs e)
        {

        }
    }
}
