using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraftProject
{

    public partial class Form2 : Form
    {
        // CHANGE THE DIRECTOORY TO  string path = @"C:\Users\"Username"\Desktop\TRU_CASE"; -1
        



        public string student_path = @"C:\Users\User\Desktop\TRU_CASE\STDN_CASE\"; //change this line -1
        public string case_path    = @"C:\Users\User\Desktop\TRU_CASE\STDN_CASE\"; //change this line -1
        public string filename, folder;
        public string img_src, img_name;
        public string global_path_txt, global_path;

        public static Form2 instance;
        public Dictionary<string, string> myDict = new Dictionary<string, string>();
        private bool btnclick = false;

        public string imagelocation = "";

        





        public Form2()
        {
            InitializeComponent();

            instance = this;


            


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(student_path))
            {
                Directory.CreateDirectory(student_path);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnclick = true;
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string st_name, st_number, st_email, fc_name, date1, date2, course_namenum, ass_num, dept, term, description,
                check1, check2, condition1 = "No", condition2 = "No", rvw_fac /**, added_description=" **/;
            st_name = textBox1.Text;
            st_number = textBox2.Text;
            
            folder = st_number;
            filename = @"\ "+ st_number +".txt";
            st_email = textBox3.Text;
            fc_name = textBox4.Text;
            date1 = dateTimePicker1.Text;
            date2 = dateTimePicker2.Text;
            course_namenum = textBox5.Text;
            ass_num = textBox6.Text;
            dept = textBox7.Text;
            term = textBox8.Text;
            description = richTextBox1.Text;
            check1 = label18.Text;
            check2 = label19.Text;
            rvw_fac = textBox9.Text;

            //added_description = Form8.instance.richtb.Text;

            Form9 form9 = new Form9();
            form9.Show();


            //inserting labels into form 9
            Form9.instance.lb1.Text = label4.Text;
            Form9.instance.lb3.Text = label5.Text;
            Form9.instance.lb5.Text = label6.Text;
            Form9.instance.lb7.Text = label8.Text;
            Form9.instance.lb9.Text = "Occurance Date";
            Form9.instance.lb11.Text = label10.Text;
            Form9.instance.lb15.Text = label11.Text;
            Form9.instance.lb17.Text = label12.Text;
            Form9.instance.lb19.Text = label13.Text;
            Form9.instance.lb21.Text = "Description";
            Form9.instance.lb23.Text = check1;
            Form9.instance.lb25.Text = check2;
            Form9.instance.lb27.Text = "Signature";
            Form9.instance.lb29.Text = label21.Text;
            Form9.instance.lb31.Text = "Signature date";
            Form9.instance.lb33.Text = "Reviewed Faculty Name";





            //inserting inputs into form 9

            Form9.instance.lb2.Text = st_name;
            Form9.instance.lb4.Text = st_number;
            Form9.instance.lb6.Text = st_email;
            Form9.instance.lb8.Text = fc_name;
            Form9.instance.lb10.Text = date1;

            Form9.instance.lb12.Text = course_namenum;
            Form9.instance.lb16.Text = ass_num;
            Form9.instance.lb18.Text = dept;
            Form9.instance.lb20.Text = term;

            if (btnclick == false)
            {

                Form9.instance.lb22.Text = description;

            }

            else
            {
                description = description + " " + Form8.instance.richtb.Text;

                Form9.instance.lb22.Text = description;

            }

            if (checkBox1.Checked == true)
            {
                Form9.instance.lb24.Text = "Yes";
                condition1 = "Yes";


            }

            else
            {
                Form9.instance.lb24.Text = "No";
            }

            if (checkBox2.Checked == true)
            {
                Form9.instance.lb26.Text = "Yes";
                condition2 = "Yes";

            }

            else
            {
                Form9.instance.lb26.Text = "No";
            }


            Form9.instance.f9_pb2.ImageLocation = imagelocation;
            Form9.instance.lb30.Text = textBox9.Text;
            Form9.instance.lb32.Text = dateTimePicker2.Text;
            Form9.instance.lb34.Text = rvw_fac;



            if (btnclick == false)

            {


                myDict["Student Name"] = st_name;

                myDict["Student Number"] = st_number;

                myDict["Student Email"] = st_email;

                myDict["Faculty Name"] = fc_name;

                myDict["Occurance Date"] = date1;

                myDict["Course and Number"] = course_namenum;

                myDict["Assignment/Exam"] = ass_num;

                myDict["Department"] = dept;

                myDict["Term/Semester"] = term;

                myDict["Description"] = description;

                myDict["Reviewed Faculty Name"] = rvw_fac;

                myDict["Review Date"] = date2;


            }


            else

            {


                myDict["Student Name"] = st_name;

                myDict["Student Number"] = st_number;

                myDict["Student Email"] = st_email;

                myDict["Faculty Name"] = fc_name;

                myDict["Occurance Date"] = date1;

                myDict["Course and Number"] = course_namenum;

                myDict["Assignment/Exam"] = ass_num;

                myDict["Department"] = dept;

                myDict["Term/Semester"] = term;

                myDict["Description"] = description;

                myDict["Reviewed Faculty Name"] = rvw_fac;

                myDict["Review Date"] = date2;


            }


            myDict["Bring support person"] = condition1;

            myDict["Submit Written statement"] = condition2;


            /**

            myDict.Add(label4.Text, st_name);
            myDict.Add(label5.Text, st_number);
            myDict.Add(label6.Text, st_email);
            myDict.Add(label8.Text, fc_name);
            myDict.Add(label9.Text, date);
            myDict.Add(label10.Text, course_namenum);
            myDict.Add(label11.Text, ass_num);
            myDict.Add(label12.Text, dept);
            myDict.Add(label13.Text, term);
            myDict.Add("Description", description);
            myDict.Add("Bring support person", condition1);
            myDict.Add("Submit Written statement", condition2);

            **/

            /**

            using (StreamWriter sw = new StreamWriter(filename))

            {

                foreach (KeyValuePair<string, string> entry in myDict)

                {

                    sw.WriteLine(entry.Key + ": " + entry.Value);

                }

            }

            **/





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





        /**

        private void button4_Click(object sender, EventArgs e)
        {
            string student_folder = case_path + folder;
            string student_file = student_folder + filename;
            string image_destination = student_folder;

            if (!Directory.Exists(student_folder))
            {
                Directory.CreateDirectory(student_folder);
            }

            using (StreamWriter sw = new StreamWriter(student_file, false))
            {
                foreach (KeyValuePair<string, string> entry in myDict)
                {
                    sw.WriteLine(entry.Key + " : " + entry.Value);
                }
            }

            MessageBox.Show(img_src);
            MessageBox.Show(image_destination);
            MessageBox.Show(student_folder);
            MessageBox.Show(student_file);

            

            this.Hide();
        }


        **/







  

        private void button4_Click(object sender, EventArgs e)
        {
            string student_folder = case_path + folder;
            string student_file = student_folder+filename;
            string image_destination = student_folder;

            global_path_txt = student_file;
            global_path = student_folder;
            

            //MessageBox.Show(student_file);
            //MessageBox.Show(student_folder);
            

            if (!Directory.Exists(student_file)) 
            {
                Directory.CreateDirectory(student_folder);               

            }

            //MessageBox.Show(filename);

            try
            {
                using (StreamWriter sw = new StreamWriter(student_file, false))
                {
                    foreach (KeyValuePair<string, string> entry in myDict)
                    {
                        sw.WriteLine(entry.Key + " : " + entry.Value);
                    }

                }

            }

            catch
            {
                MessageBox.Show("Please enter student id");
            }
            


            /**

            else
            {
                

                using (StreamWriter sw = new StreamWriter(student_file))

                    {

                        foreach (KeyValuePair<string, string> entry in myDict)

                        {

                            sw.WriteLine(entry.Key + ": " + entry.Value);

                        }

                    }

                //File.Copy( img_src, image_destination, true);

            }

            **/


            //MessageBox.Show(img_src);
            //MessageBox.Show(image_destination);

            

            try
            {
                File.Copy(img_src, Path.Combine(image_destination, Path.GetFileName(img_src)), true);
                this.Hide();
            }
            
            catch
            {
                MessageBox.Show("You did not give the signature image");
            }




            (this.Owner as Form1).btn1.Enabled = false;




        }

      

    }
}


