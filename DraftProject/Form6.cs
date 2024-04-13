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
    public partial class Form6 : Form
    {
        public static Form6 instance;
        string imagelocation = "", img_src;
        string step_5 = @"/dean_step_5.txt";
        string path = Form2.instance.global_path, path_txt = Form2.instance.global_path_txt;
        public Dictionary<string, string> myDict = new Dictionary<string, string>();


        public Form6()
        {
            InitializeComponent();
            instance = this;
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path_txt = Form2.instance.global_path_txt;
                string path_std = path + @"\student.txt";
                string path_fct = path + @"\faculty_step_3.txt";
                string path_chair = path + @"\chair_step_4.txt";

                string textContent_case = File.ReadAllText(path_txt);
                string textContent_student = File.ReadAllText(path_std);
                string textContent_faculty = File.ReadAllText(path_fct);
                string textContent_chair = File.ReadAllText(path_chair);

                string msg = textContent_case + "\n" + textContent_student + "\n" + textContent_faculty + "\n" + textContent_chair + "\n \n";



                MessageBox.Show(msg);




                //MessageBox.Show(path_txt);
                //MessageBox.Show(path_std);
                //MessageBox.Show(path_fct);
            }
            catch
            {
                MessageBox.Show("Something went wrong!!");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dean_name, comments, explain = "", date;
            string check = "";

            if (radioButton1.Checked)
            {
                check = "Yes";
            }

            else
            {
                check = "No";
                explain = richTextBox1.Text;
            }


            comments = richTextBox2.Text;
            dean_name = textBox1.Text;
            date = dateTimePicker1.Text;

            if (check == "Yes")
            {
                myDict["Dean Name"] = dean_name;
                myDict["Agree with case"] = check;
                myDict["Comments"] = comments;
                myDict["Signature date"] = date;

            }

            else
            {
                myDict["Dean Name"] = dean_name;
                myDict["Agree with case"] = check;
                myDict["Explanation"] = explain;
                myDict["Comments"] = comments;
                myDict["Signature date"] = date;
            }



            string msg = "";

            foreach (KeyValuePair<string, string> entry in myDict)
            {
                msg += entry.Key + ": " + entry.Value + "\n\n";
            }

            MessageBox.Show(msg);



        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s5 = path + step_5;

            using (StreamWriter sw = new StreamWriter(s5, false))
            {
                foreach (KeyValuePair<string, string> entry in myDict)
                {
                    sw.WriteLine(entry.Key + " : " + entry.Value);
                }
            }


            try
            {
                string image_destination = path;

                File.Copy(img_src, Path.Combine(image_destination, Path.GetFileName(img_src)), true);


                (this.Owner as Form1).btn5.Enabled = false;
                this.Hide();
            }

            catch
            {
                MessageBox.Show("You did not give the signature image");
            }

        }
    }
}
