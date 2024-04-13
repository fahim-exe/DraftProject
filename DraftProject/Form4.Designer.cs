namespace DraftProject
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(665, 79);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(522, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 23);
            label3.Name = "label3";
            label3.Size = new Size(513, 33);
            label3.TabIndex = 1;
            label3.Text = "Case Report Form: On Campus Course";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(333, 23);
            label2.TabIndex = 0;
            label2.Text = "ACADEMIC INTEGRITY POLICY ED 5-0";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            button3.BackColor = Color.MintCream;
            button3.Location = new Point(12, 519);
            button3.Name = "button3";
            button3.Size = new Size(80, 35);
            button3.TabIndex = 13;
            button3.Text = "View Case";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MintCream;
            button4.Location = new Point(585, 519);
            button4.Name = "button4";
            button4.Size = new Size(80, 35);
            button4.TabIndex = 0;
            button4.Text = "Confirm";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 107);
            label1.Name = "label1";
            label1.Size = new Size(665, 244);
            label1.TabIndex = 14;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label4.Location = new Point(12, 378);
            label4.Name = "label4";
            label4.Size = new Size(198, 17);
            label4.TabIndex = 15;
            label4.Text = "Signature of Faculty Member";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label5.Location = new Point(264, 378);
            label5.Name = "label5";
            label5.Size = new Size(174, 17);
            label5.TabIndex = 16;
            label5.Text = "Name of Faculty Member";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label6.Location = new Point(465, 378);
            label6.Name = "label6";
            label6.Size = new Size(50, 17);
            label6.TabIndex = 17;
            label6.Text = "Date";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.GradientInactiveCaption;
            textBox2.Location = new Point(264, 398);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.MintCream;
            button1.Location = new Point(17, 398);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(465, 398);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(689, 641);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form4";
            Text = "Faculty Review";
            Load += Form4_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
    }
}