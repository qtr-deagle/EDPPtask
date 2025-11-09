namespace AlamaresChristianJoshuaPtask
{
    partial class AddFood
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
            AddFoodBox = new TextBox();
            Result = new Label();
            button1 = new Button();
            FoodPrice = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 21);
            label1.Name = "label1";
            label1.Size = new Size(177, 37);
            label1.TabIndex = 1;
            label1.Text = "ADD FOOD";
            // 
            // AddFoodBox
            // 
            AddFoodBox.CharacterCasing = CharacterCasing.Lower;
            AddFoodBox.Location = new Point(29, 61);
            AddFoodBox.Name = "AddFoodBox";
            AddFoodBox.Size = new Size(184, 27);
            AddFoodBox.TabIndex = 2;
            AddFoodBox.TextChanged += textBox1_TextChanged;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Result.Location = new Point(29, 109);
            Result.Name = "Result";
            Result.Size = new Size(79, 20);
            Result.TabIndex = 8;
            Result.Text = "Result:";
            // 
            // button1
            // 
            button1.Font = new Font("Courier New", 11F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(115, 144);
            button1.Name = "button1";
            button1.Size = new Size(89, 37);
            button1.TabIndex = 9;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FoodPrice
            // 
            FoodPrice.CharacterCasing = CharacterCasing.Lower;
            FoodPrice.Location = new Point(219, 61);
            FoodPrice.Name = "FoodPrice";
            FoodPrice.Size = new Size(76, 27);
            FoodPrice.TabIndex = 10;
            // 
            // AddFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 205);
            Controls.Add(FoodPrice);
            Controls.Add(button1);
            Controls.Add(Result);
            Controls.Add(AddFoodBox);
            Controls.Add(label1);
            Name = "AddFood";
            Text = "AddFood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox AddFoodBox;
        private Label Result;
        private Button button1;
        private TextBox FoodPrice;
    }
}