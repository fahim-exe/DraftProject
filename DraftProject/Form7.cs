﻿using System;
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

    public partial class Form7 : Form
    {
        public static Form7 instance;

        public RichTextBox rtb;
        public Form7()
        {
            InitializeComponent();
            instance = this;
            rtb = richTextBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string added_description = rtb.Text;
            Close();
        }
    }
}
