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
    public partial class Form8 : Form
    {
        public static Form8 instance;
        public RichTextBox richtb;
        public Form8()
        {
            InitializeComponent();
            instance = this;
            richtb = richTextBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String added_description = richtb.Text;
            Close();

        }
    }
}
