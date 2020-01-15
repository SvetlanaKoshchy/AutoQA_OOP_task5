using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task5
{
    class ValidationHelper
    {
        public bool IsNumeric(string value)
        {
            if (Int32.TryParse(value, out int result))
            {
                return true;
            }
            else
            {               
                return false;
            }
        }
        public bool IsPositive(double value) //method to check if value positive
        {
            if (value > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
