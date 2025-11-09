namespace AlamaresChristianJoshuaPtask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 102);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Courier New", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(65, 56);
            button1.Name = "button1";
            button1.Size = new Size(192, 43);
            button1.TabIndex = 1;
            button1.Text = "VIEW PRODUCT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Courier New", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(65, 105);
            button2.Name = "button2";
            button2.Size = new Size(192, 43);
            button2.TabIndex = 2;
            button2.Text = "ORDER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 205);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}
