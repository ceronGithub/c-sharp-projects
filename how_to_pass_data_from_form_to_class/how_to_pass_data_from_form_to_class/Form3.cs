using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace how_to_pass_data_from_form_to_class
{
    public partial class Form3 : Form
    {

        // calls the class file
        Class methods = new Class();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        // public void ShowDialog(ref String recieved) // recieved data string from form1
        // public void ShowDialog(ref TextBox recieved) // recieved data from textbox directly from form1
        public void ShowDialog(ref int recieved)
        {
            label2.Text = "" + recieved;
            if (recieved == 0)
            {
                label5.Text = "Recieved from Form1:" + recieved;
                label6.Text = "Received data from class :" + Class.StaticMethod1(recieved);
            }
            else
            {
                label5.Text = "Didnt Recieved any from Form1";
                label6.Text = "Received data from class :" + Class.StaticMethod1(recieved);
            }
            this.ShowDialog(); //Display and activate this form (Form3)
        }
    }
}
