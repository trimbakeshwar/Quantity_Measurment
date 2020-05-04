using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{
    //comparison
    class CompareLength
    {
        public int compareFeetInch(double feet, double inch)
        {
            //convert into feet for comparison
            double inchToFeet = inch / 12;

            //if feet and inchToFeet is same then return 1 else return 0
            if (feet == inchToFeet)
            {
                return 1;
            }
            return 0;
        }
    }
}
