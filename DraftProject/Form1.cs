using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;




namespace DraftProject
{
    
    public partial class Form1 : Form
    {

        // CHANGE THE DIRECTOORY TO  string path = @"C:\Users\"Username"\Desktop\TRU_CASE"; -1
        // CHANGE THE DIRECTOORY TO  string student_path = @"C:\Users\"Username"\Desktop\TRU_CASE\STDN_CASE\"; -2


        string path = @"C:\Users\User\Desktop\TRU_CASE";  //change this line-1
        string student_path = @"C:\Users\User\Desktop\TRU_CASE\STDN_CASE\"; // change this line-2
        public static Form1 instance;
        public Button btn1, btn2, btn3, btn4, btn5;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            btn1 = btn_Faculty1;
            btn2 = btn_student;
            btn3 = button3;
            btn4 = button4;
            btn5 = button5;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

        }

        private void btn_Faculty1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.Show();
            
            //this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Owner = this;
            form3.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Owner = this;
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Owner = this;
            form5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Owner = this;
            form6.Show();
        }
    }
}
