namespace AlamaresChristianJoshuaPtask
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            DrinkOrderList = new ListBox();
            FoodOrderList = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(353, 77);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 14;
            label3.Text = "DRINKS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 77);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 13;
            label2.Text = "FOODS";
            // 
            // button1
            // 
            button1.Font = new Font("Courier New", 11F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(61, 395);
            button1.Name = "button1";
            button1.Size = new Size(434, 37);
            button1.TabIndex = 12;
            button1.Text = "ORDER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DrinkOrderList
            // 
            DrinkOrderList.FormattingEnabled = true;
            DrinkOrderList.Location = new Point(306, 105);
            DrinkOrderList.Name = "DrinkOrderList";
            DrinkOrderList.Size = new Size(189, 284);
            DrinkOrderList.TabIndex = 11;
            // 
            // FoodOrderList
            // 
            FoodOrderList.FormattingEnabled = true;
            FoodOrderList.Location = new Point(61, 105);
            FoodOrderList.Name = "FoodOrderList";
            FoodOrderList.Size = new Size(189, 284);
            FoodOrderList.TabIndex = 10;
            FoodOrderList.SelectedIndexChanged += FoodOrderList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 22);
            label1.Name = "label1";
            label1.Size = new Size(137, 37);
            label1.TabIndex = 9;
            label1.Text = "ORDERS";
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 455);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(DrinkOrderList);
            Controls.Add(FoodOrderList);
            Controls.Add(label1);
            Name = "Orders";
            Text = "Orders";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Button button1;
        private ListBox DrinkOrderList;
        private ListBox FoodOrderList;
        private Label label1;
    }
}