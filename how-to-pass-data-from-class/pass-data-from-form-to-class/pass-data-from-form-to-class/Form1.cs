using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pass_data_from_form_to_class
{
    public partial class Form1 : Form
    {
        // call class file
        Class file = new Class();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Class.static_PassString();
            label2.Text = file.non_Static_PassString();
        }
    }
}