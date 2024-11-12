using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace how_to_retrieve_data_from_class
{
    public partial class Form1 : Form
    {

        // calls Class file
        Class file = new Class();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Class.StaticString();
            label2.Text = file.NonStaticString();
        }
    }
}
