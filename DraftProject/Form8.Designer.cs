namespace DraftProject
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(662, 79);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(522, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 56);
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
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.GradientInactiveCaption;
            richTextBox1.Location = new Point(12, 97);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(662, 403);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.MintCream;
            button1.Location = new Point(596, 549);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(693, 645);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(panel2);
            Name = "Form8";
            Text = "Faculty Member Comments";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private RichTextBox richTextBox1;
        private Button button1;
    }
}