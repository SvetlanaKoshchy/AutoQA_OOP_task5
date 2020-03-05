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
                Console.WriteLine(Constants.errorValueIsWrong);
                return false;
            }
        }
        public bool IsPositive(int value) //method to check if value positive
        {
            if (value > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine(Constants.errorValueIsWrong);
                return false;
            }
        }

        public bool IsYesOrNo(string value)
        {            
            if (value.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            
            return false;
        }

        public int TimeFromDifficulty(Difficulty difficulty)
        {
            switch (difficulty)
            {
                case Difficulty.Hard:
                    return Constants.highHoursDifficulty;
                case Difficulty.Medium:
                    return Constants.mediumHoursDifficulty;
                case Difficulty.Easy:
                    return Constants.easyHoursDifficulty;
                default:
                    return 0;
            }
        }

    }
}
