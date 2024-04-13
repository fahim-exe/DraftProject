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
    public partial class Form10 : Form
    {
        public static Form10 instance;
        public Label lb2, lb4, lb6, lb8, lb10;

        public Form10()
        {
            InitializeComponent();
            instance = this;

            lb2 = label2;
            lb4 = label4;
            lb6 = label6;
            lb8 = label8;
            lb10 = label10;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
