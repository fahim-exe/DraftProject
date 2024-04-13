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
    public partial class Form4 : Form
    {
        public static Form4 instance;
        string imagelocation = "", img_src;
        string step_3 = @"/faculty_step_3.txt";




        string path = Form2.instance.global_path, path_txt = Form2.instance.global_path_txt;
        public Dictionary<string, string> myDict = new Dictionary<string, string>();


        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

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

            //MessageBox.Show(imagelocation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string path_stdn = Form2.instance.global_path + @"\student.txt";
                string path_txt = Form2.instance.global_path_txt;

                string textContent_case = File.ReadAllText(path_txt);
                string textContent_stdn = File.ReadAllText(path_stdn);

                string msg = textContent_case + "\n" + textContent_stdn;

                MessageBox.Show(msg);



                //MessageBox.Show(path);
            }
            catch
            {
                MessageBox.Show("Something went wrong!!");

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string r_date, f_name, s3=path+step_3;

            f_name = textBox2.Text;
            r_date = dateTimePicker1.Text;

            myDict["Faculty Name"] = f_name;
            myDict["Step-3 Date"] = r_date;

            using (StreamWriter sw = new StreamWriter(s3, false)) 
            {
                foreach(KeyValuePair<string, string> entry in myDict)
                {
                    sw.WriteLine(entry.Key + " : " + entry.Value);
                }
            }


            try
            {
                string image_destination = path;

                File.Copy(img_src, Path.Combine(image_destination, Path.GetFileName(img_src)), true);
                

                (this.Owner as Form1).btn3.Enabled = false;
                this.Hide();
            }

            catch
            {
                MessageBox.Show("You did not give the signature image");
            }









            //(this.Owner as Form1).btn3.Enabled = false;
            //this.Hide();

        }
    }
}
