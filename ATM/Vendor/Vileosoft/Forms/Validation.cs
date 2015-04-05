using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATM.Vendor.Vileosoft.Forms
{
    class Validation
    {
        public bool isRequired(string Object, string Message)
        {
            if (Object == "")
            {
                MessageBox.Show(Message);
                return false;
            }
            return true;
        }

        public bool isMinLength(string Object,int min,string Message)
        {
            if(Object.Length<min) 
            {
                MessageBox.Show(Message);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isEqual(string Object, string Object2, string Message)
        {
            if (Object != Object2)
            {
                MessageBox.Show(Message);
                return false;
            }
            return true;
        }
    }
}
