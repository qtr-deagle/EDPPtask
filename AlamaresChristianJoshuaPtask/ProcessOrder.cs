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
    public partial class ProcessOrder : Form
    {
        public ProcessOrder()
        {
            InitializeComponent();
        }

        private void UpdateTotalResult()
        {
            decimal total = 0;

            foreach (var item in ProcessOrderList.Items)
            {
                string line = item.ToString();
                string[] parts = line.Split('-');

                if (parts.Length == 2)
                {
                    string pricePart = parts[1].Trim();

                    if (decimal.TryParse(pricePart, out decimal price))
                    {
                        total += price;
                    }
                }
            }

            TotalResult.Text = total.ToString("N2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string productName = OrderProductBox.Text.Trim();
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Please enter a product name.");
                return;
            }

            string foodPath = Path.Combine(Application.StartupPath, "FoodList.txt");
            string drinkPath = Path.Combine(Application.StartupPath, "DrinkList.txt");

            string matchedLine = null;

            // Search in FoodList
            if (File.Exists(foodPath))
            {
                matchedLine = File.ReadAllLines(foodPath)
                                  .FirstOrDefault(line => line.StartsWith(productName + " - ", StringComparison.OrdinalIgnoreCase));
            }

            // If not found in FoodList, search in DrinkList
            if (matchedLine == null && File.Exists(drinkPath))
            {
                matchedLine = File.ReadAllLines(drinkPath)
                                  .FirstOrDefault(line => line.StartsWith(productName + " - ", StringComparison.OrdinalIgnoreCase));
            }

            if (matchedLine != null)
            {
                // format nicely like "Burger - 75"
                string[] parts = matchedLine.Split('-');
                string display = $"{parts[0]} - {parts[1]}";

                if (!ProcessOrderList.Items.Contains(display))
                {
                    ProcessOrderList.Items.Add(display);
                    UpdateTotalResult();
                }

                OrderProductBox.Text = "";
                OrderProductBox.Focus();
            }
            else
            {
                MessageBox.Show("Product not found in Orders.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string productName = OrderProductBox.Text.Trim();
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Please enter a product name to remove.");
                return;
            }

            bool itemRemoved = false;

            for (int i = 0; i < ProcessOrderList.Items.Count; i++)
            {
                string item = ProcessOrderList.Items[i].ToString();

                // Match format: "Burger - 75"
                string[] parts = item.Split('-');
                if (parts.Length == 2)
                {
                    string namePart = parts[0].Trim();

                    if (namePart.Equals(productName, StringComparison.OrdinalIgnoreCase))
                    {
                        ProcessOrderList.Items.RemoveAt(i);
                        itemRemoved = true;
                        break;
                    }
                }
            }

            if (itemRemoved)
            {
                UpdateTotalResult(); // Recalculate total
                OrderProductBox.Text = "";
                OrderProductBox.Focus();
            }
            else
            {
                MessageBox.Show("Product not found in the order list.");
            }
        }

        private void OrderProductBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string paymentText = PaymentBox.Text.Trim();
            string totalText = TotalResult.Text.Trim();

            if (decimal.TryParse(paymentText, out decimal payment) &&
                decimal.TryParse(totalText, out decimal total))
            {
                if (payment >= total)
                {
                    decimal change = payment - total;
                    ChangeResult.Text = change.ToString("N2");
                }
                else
                {
                    MessageBox.Show("Payment is less than total. Please enter a valid amount.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter numeric values only.");
            }
        }

        private void PaymentBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "AlamaresChristianJoshua.txt");

            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine("===== RECEIPT =====");
            receipt.AppendLine($"Date: {DateTime.Now}");
            receipt.AppendLine($"Order #: {Guid.NewGuid().ToString().Substring(0, 8)}"); // or use a name input
            receipt.AppendLine();

            receipt.AppendLine("Items:");
            foreach (var item in ProcessOrderList.Items)
            {
                receipt.AppendLine($"• {item}");
            }

            receipt.AppendLine();
            receipt.AppendLine($"Total: {TotalResult.Text}");
            receipt.AppendLine($"Payment: {PaymentBox.Text.Trim()}");
            receipt.AppendLine($"Change: {ChangeResult.Text}");
            receipt.AppendLine("===================");

            File.WriteAllText(filePath, receipt.ToString());

            // Open in Notepad
            System.Diagnostics.Process.Start("notepad.exe", filePath);
        }
    }
}
