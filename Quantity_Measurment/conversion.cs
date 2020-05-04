using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{

    //comparison
    public class conversion
    {


        public double conversionLength(string unit, double length)
        {
            if (unit.Contains("feet"))
            {
                return length;
            }
            else if (unit.Contains("inch"))
            {
                return length * 12;
            }
            return 0;
        }
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
