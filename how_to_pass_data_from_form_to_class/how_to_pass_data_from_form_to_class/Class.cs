using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace how_to_pass_data_from_form_to_class
{
    internal class Class
    {

        public static string StaticMethod()
        {
            return "Static Method";
        }

        public string NonStaticMethod()
        {
            return "Non-Static Method";
        }
            
        public string NonStaticMethod2(string Svalue) { 
            if(Svalue == "Recieved from Form1")
            {
                return "Retrieved, from class.";
            }
            else
            {
                return "didnt recieved any data from form!.";
            }
        }
    }
}
