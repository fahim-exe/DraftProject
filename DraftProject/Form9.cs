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
    public partial class Form9 : Form
    {
        public static Form9 instance;
        public Label lb1, lb2, lb3, lb4, lb5, lb6, lb7, lb8, lb9, lb10, 
            lb11, lb12, lb15, lb16, lb17, lb18, lb19, lb20, lb21, lb22, 
            lb23, lb24, lb25, lb26, lb27, lb29, lb30, lb31, lb32, lb33, 
            lb34, lb35, lb36;

        public PictureBox f9_pb2;
        public Form9()
        {
            InitializeComponent();
            instance = this;
            lb1 = label1;
            lb2 = label2;
            lb3 = label3;
            lb4 = label4;
            lb5 = label5;
            lb6 = label6;
            lb7 = label7;
            lb8 = label8;
            lb9 = label9;
            lb10 = label10;
            lb11 = label11;

            lb12 = label12;

            lb15 = label15;
            lb16 = label16;
            lb17 = label17;
            lb18 = label18;
            lb19 = label19;
            lb20 = label20;
            lb21 = label21;
            lb22 = label22;
            lb23 = label23;
            lb24 = label24;
            lb25 = label25;
            lb26 = label26;
            lb27 = label27;
            lb29 = label29;
            lb30 = label30;
            lb31 = label31;
            lb32 = label32;
            lb33 = label33;
            lb34 = label34;
            //lb35 = label35;
            //lb36 = label36;
            f9_pb2 = pictureBox2;



        }

        private void button1_Click(object sender, EventArgs e)
        {           
            this.Hide();
        }
    }
}
