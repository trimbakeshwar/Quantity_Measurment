using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{
    //comparison
    public class CompareLength
    {
        public bool compareInchToFeet(double feet, double inch)
        {
            //convert into feet for comparison
            double inchToFeet = inch / 12;

            //if feet and inchToFeet is same then return 1 else return 0
            if (feet == inchToFeet)
            {
                return true;
            }
            return false;
        }
        public bool compareFeetToInch(double feet, double inch)
        {
            //convert into inch for comparison
            double FeetToInch = inch * 12;

            //if feet and inchToFeet is same then return 1 else return 0
            if (feet == FeetToInch)
            {
                return true;
            }
            return false;
        }
    }
}
