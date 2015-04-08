using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Vendor.Vileosoft.Text
{
    class Numeric
    {
        public string Digit(int val, int digit)
        {
            string dig = "";
            for (int i = 0; i < digit; i++)
            {
                dig += "0";
            }
            return dig;
        }
    }
}
