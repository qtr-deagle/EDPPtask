namespace AlamaresChristianJoshuaPtask
{
    partial class ProcessOrder
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
            ProcessOrderList = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Courier New", 11F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(54, 423);
            button1.Name = "button1";
            button1.Size = new Size(316, 37);
            button1.TabIndex = 18;
            button1.Text = "PRINT";
            button1.UseVisualStyleBackColor = true;
            // 
            // ProcessOrderList
            // 
            ProcessOrderList.FormattingEnabled = true;
            ProcessOrderList.Location = new Point(114, 95);
            ProcessOrderList.Name = "ProcessOrderList";
            ProcessOrderList.Size = new Size(189, 224);
            ProcessOrderList.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 22);
            label1.Name = "label1";
            label1.Size = new Size(277, 37);
            label1.TabIndex = 15;
            label1.Text = "PROCESS ORDER";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 27);
            textBox1.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 332);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 22;
            label4.Text = "Total:";
            // 
            // button2
            // 
            button2.Font = new Font("Courier New", 11F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(281, 62);
            button2.Name = "button2";
            button2.Size = new Size(89, 27);
            button2.TabIndex = 24;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Courier New", 11F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(186, 62);
            button3.Name = "button3";
            button3.Size = new Size(89, 27);
            button3.TabIndex = 23;
            button3.Text = "ADD";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 361);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 25;
            label2.Text = "Payment:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 390);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 26;
            label3.Text = "Change:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 357);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 27);
            textBox2.TabIndex = 27;
            // 
            // button4
            // 
            button4.Font = new Font("Courier New", 11F, FontStyle.Bold | FontStyle.Italic);
            button4.Location = new Point(281, 358);
            button4.Name = "button4";
            button4.Size = new Size(89, 27);
            button4.TabIndex = 28;
            button4.Text = "PAY";
            button4.UseVisualStyleBackColor = true;
            // 
            // ProcessOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 487);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(ProcessOrderList);
            Controls.Add(label1);
            Name = "ProcessOrder";
            Text = "ProcessOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ListBox DrinkOrderList;
        private ListBox ProcessOrderList;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button4;
    }
}