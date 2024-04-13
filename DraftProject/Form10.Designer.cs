namespace DraftProject
{
    partial class Form10
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Student name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 9);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 56);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 2;
            label3.Text = "Student email";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(303, 56);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 105);
            label5.Name = "label5";
            label5.Size = new Size(187, 30);
            label5.TabIndex = 4;
            label5.Text = "I have reviewed the information in\r\nthe form as well as the evidence:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(303, 105);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "label6";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 170);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 6;
            label7.Text = "Date of Explanation";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(303, 170);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 7;
            label8.Text = "label8";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 220);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 8;
            label9.Text = "Explanation";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Location = new Point(303, 220);
            label10.Name = "label10";
            label10.Size = new Size(374, 277);
            label10.TabIndex = 9;
            label10.Text = "label10";
            // 
            // button1
            // 
            button1.Location = new Point(549, 587);
            button1.Name = "button1";
            button1.Size = new Size(128, 42);
            button1.TabIndex = 10;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 641);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form10";
            Text = "Student Preview";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
    }
}