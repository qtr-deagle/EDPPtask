namespace AlamaresChristianJoshuaPtask
{
    partial class Products
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
            label1 = new Label();
            DrinkProductList = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            FoodProductList = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 20);
            label1.Name = "label1";
            label1.Size = new Size(177, 37);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTS";
            label1.Click += label1_Click;
            // 
            // DrinkProductList
            // 
            DrinkProductList.FormattingEnabled = true;
            DrinkProductList.Location = new Point(303, 103);
            DrinkProductList.Name = "DrinkProductList";
            DrinkProductList.Size = new Size(189, 284);
            DrinkProductList.TabIndex = 2;
            DrinkProductList.SelectedIndexChanged += DrinkProductList_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Courier New", 11F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(58, 393);
            button1.Name = "button1";
            button1.Size = new Size(89, 37);
            button1.TabIndex = 3;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Courier New", 11F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(158, 393);
            button2.Name = "button2";
            button2.Size = new Size(89, 37);
            button2.TabIndex = 4;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Courier New", 11F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(403, 393);
            button3.Name = "button3";
            button3.Size = new Size(89, 37);
            button3.TabIndex = 6;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Courier New", 11F, FontStyle.Bold | FontStyle.Italic);
            button4.Location = new Point(303, 393);
            button4.Name = "button4";
            button4.Size = new Size(89, 37);
            button4.TabIndex = 5;
            button4.Text = "ADD";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 75);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 7;
            label2.Text = "FOODS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(350, 75);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 8;
            label3.Text = "DRINKS";
            // 
            // FoodProductList
            // 
            FoodProductList.FormattingEnabled = true;
            FoodProductList.Location = new Point(58, 103);
            FoodProductList.Name = "FoodProductList";
            FoodProductList.Size = new Size(189, 284);
            FoodProductList.TabIndex = 9;
            FoodProductList.SelectedIndexChanged += FoodProductList_SelectedIndexChanged;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 455);
            Controls.Add(FoodProductList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(DrinkProductList);
            Controls.Add(label1);
            Name = "Products";
            Text = "Products";
            Load += Products_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox DrinkProductList;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
        private ListBox FoodProductList;
    }
}