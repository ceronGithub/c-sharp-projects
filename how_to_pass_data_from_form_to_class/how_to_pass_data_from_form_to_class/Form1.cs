using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace how_to_pass_data_from_form_to_class
{
    public partial class Form1 : Form
    {

        //calls the class file
        Class methods = new Class();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Class.StaticMethod();
            label2.Text = methods.NonStaticMethod();
        }

        private void button4_Click(object sender, EventArgs e) // boolean parameters
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) // double parameters
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) // int parameters
        {
            int PassDataInt = 0;
            // string PassDataString = "From Form 1";
            /* Pass string variable data to form3
             * via overloading the ShowDialog method
             */
            Form3 f3 = new Form3();
            // f3.ShowDialog(ref PassDataString); // pass data string
            // f3.ShowDialog(ref you can put textbox here directly); // pass data string
            f3.ShowDialog(ref PassDataInt);
        }


        //Pass data from this form to another form
        public static string PassDataString = "From Form 1";
        private void button1_Click(object sender, EventArgs e) // string parameters
        {                                   
            Form2 f2 = new Form2();
            f2.ShowDialog(); // prevents the form1 of stealing focus from form2.            
        }
    }
}
