namespace AlamaresChristianJoshuaPtask
{
    partial class RemoveDrink
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
            RemoveDrinkBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Courier New", 11F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(116, 145);
            button1.Name = "button1";
            button1.Size = new Size(89, 37);
            button1.TabIndex = 17;
            button1.Text = "REMOVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Result.Location = new Point(30, 110);
            Result.Name = "Result";
            Result.Size = new Size(79, 20);
            Result.TabIndex = 16;
            Result.Text = "Result:";
            Result.Click += Result_Click;
            // 
            // RemoveDrinkBox
            // 
            RemoveDrinkBox.Location = new Point(30, 62);
            RemoveDrinkBox.Name = "RemoveDrinkBox";
            RemoveDrinkBox.Size = new Size(261, 27);
            RemoveDrinkBox.TabIndex = 15;
            RemoveDrinkBox.TextChanged += RemoveDrinkBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 22);
            label1.Name = "label1";
            label1.Size = new Size(257, 37);
            label1.TabIndex = 14;
            label1.Text = "REMOVE DRINK";
            // 
            // RemoveDrink
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 205);
            Controls.Add(button1);
            Controls.Add(Result);
            Controls.Add(RemoveDrinkBox);
            Controls.Add(label1);
            Name = "RemoveDrink";
            Text = "RemoveDrink";
            Load += RemoveDrink_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label Result;
        private TextBox RemoveDrinkBox;
        private Label label1;
    }
}