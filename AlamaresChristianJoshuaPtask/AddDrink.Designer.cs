namespace AlamaresChristianJoshuaPtask
{
    partial class AddDrink
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
            button1 = new Button();
            Result = new Label();
            AddDrinkBox = new TextBox();
            label1 = new Label();
            DrinkPrice = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Courier New", 11F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(116, 144);
            button1.Name = "button1";
            button1.Size = new Size(89, 37);
            button1.TabIndex = 13;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Result.Location = new Point(30, 109);
            Result.Name = "Result";
            Result.Size = new Size(79, 20);
            Result.TabIndex = 12;
            Result.Text = "Result:";
            Result.Click += Result_Click;
            // 
            // AddDrinkBox
            // 
            AddDrinkBox.Location = new Point(30, 61);
            AddDrinkBox.Name = "AddDrinkBox";
            AddDrinkBox.Size = new Size(180, 27);
            AddDrinkBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 21);
            label1.Name = "label1";
            label1.Size = new Size(197, 37);
            label1.TabIndex = 10;
            label1.Text = "ADD DRINK";
            // 
            // DrinkPrice
            // 
            DrinkPrice.CharacterCasing = CharacterCasing.Lower;
            DrinkPrice.Location = new Point(216, 61);
            DrinkPrice.Name = "DrinkPrice";
            DrinkPrice.Size = new Size(78, 27);
            DrinkPrice.TabIndex = 14;
            // 
            // AddDrink
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 205);
            Controls.Add(DrinkPrice);
            Controls.Add(button1);
            Controls.Add(Result);
            Controls.Add(AddDrinkBox);
            Controls.Add(label1);
            Name = "AddDrink";
            Text = "AddDrink";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label Result;
        private TextBox AddDrinkBox;
        private Label label1;
        private TextBox DrinkPrice;
    }
}