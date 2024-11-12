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
    public partial class Form2 : Form
    {
        // calls class file
        Class method = new Class();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.PassDataString;
            if(label2.Text == "From Form 1")
            {
                label5.Text = "Recieved from Form1";
                label6.Text = method.NonStaticMethod2(label5.Text);
            }
            else
            {
                label5.Text = "Didnt Recieved any from Form1";
                label6.Text = method.NonStaticMethod2(label5.Text);
            }            
        }
    }
}
