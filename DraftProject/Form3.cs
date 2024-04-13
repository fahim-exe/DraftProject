using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraftProject
{
    public partial class Form3 : Form
    {   
        
        string path = Form2.instance.global_path;
        public static Form3 instance;
        private bool btnclick = false;

        string student = @"/student.txt", imagelocation="", img_src;

        public Dictionary<string,string> myDict = new Dictionary<string, string>();


        public Form3()
        {
            InitializeComponent();


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnclick = true;
            Form7 form7 = new Form7();
            form7.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string path_txt = Form2.instance.global_path_txt;

                string textContent = File.ReadAllText(path_txt);
                MessageBox.Show(textContent);



                //MessageBox.Show(path_txt);
            }
            catch
            {
                MessageBox.Show("Something went wrong!!");

            }






        }

        private void button2_Click(object sender, EventArgs e)
        {
            string st_name, check, explanation, st_email, explanation_date;

            st_name = textBox1.Text;

            if (radioButton1.Checked == true)
            {
                check = "Yes";
            }

            else
            {
                check = "No";
            }

            st_email = textBox2.Text;


            if (btnclick == false)
            {
                explanation = "Not Given";
            }

            else
            {
                explanation = Form7.instance.rtb.Text;

            }

            explanation_date = dateTimePicker1.Text;
            

            if (btnclick == false)
            {
                myDict["Student Name"] = st_name;
                myDict["Student Email"] = st_email;
                myDict["Student Signature date"] = explanation_date;
                myDict["Explanation"] = explanation;

            }

            else
            {
                myDict["Student Name"] = st_name;
                myDict["Student Email"] = st_email;
                myDict["Student Signature date"] = explanation_date;
                myDict["Explanation"] = explanation;


            }




            string message = "";
            foreach (var entry in myDict)
            {
                message += $"{entry.Key}: {entry.Value}";
            }

            Form10 form10 = new Form10();

            form10.Show();

            Form10.instance.lb2.Text = st_name;
            Form10.instance.lb4.Text = st_email;
            Form10.instance.lb6.Text = check;
            Form10.instance.lb8.Text = explanation_date;
            Form10.instance.lb10.Text = explanation;

            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string student_file = path + student;

            using (StreamWriter sw = new StreamWriter(student_file, false))
            {
                foreach (KeyValuePair<string, string> entry in myDict)
                {
                    sw.WriteLine(entry.Key + " : " + entry.Value);
                }
            }


            //(this.Owner as Form1).btn2.Enabled = false;
            //this.Hide();

            try
            {
                string image_destination = path;

                File.Copy(img_src, Path.Combine(image_destination, Path.GetFileName(img_src)), true);
                this.Hide();

                (this.Owner as Form1).btn2.Enabled = false;
            }

            catch
            {
                MessageBox.Show("You did not give the signature image");
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)| *.png| All Files(*.*)|*.*";

                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = open.FileName;

                    img_src = imagelocation;





                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
