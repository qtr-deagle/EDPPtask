namespace AlamaresChristianJoshuaPtask
{
    partial class RemoveFood
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
            RemoveFoodBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Courier New", 11F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(116, 145);
            button1.Name = "button1";
            button1.Size = new Size(89, 37);
            button1.TabIndex = 13;
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
            Result.TabIndex = 12;
            Result.Text = "Result:";
            Result.Click += label2_Click;
            // 
            // RemoveFoodBox
            // 
            RemoveFoodBox.Location = new Point(30, 62);
            RemoveFoodBox.Name = "RemoveFoodBox";
            RemoveFoodBox.Size = new Size(261, 27);
            RemoveFoodBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 22);
            label1.Name = "label1";
            label1.Size = new Size(237, 37);
            label1.TabIndex = 10;
            label1.Text = "REMOVE FOOD";
            // 
            // RemoveFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 205);
            Controls.Add(button1);
            Controls.Add(Result);
            Controls.Add(RemoveFoodBox);
            Controls.Add(label1);
            Name = "RemoveFood";
            Text = "RemoveFood";
            Load += RemoveFood_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label Result;
        private TextBox RemoveFoodBox;
        private Label label1;
    }
}