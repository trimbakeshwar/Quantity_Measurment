using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{

    //comparison
    public class conversion
    {

        public bool compareInchAndFeet(CheckEquals e1, CheckEquals e2)
        {
            double data;
            if (e1.Unit.Contains("inch"))
            {
                data = e1.Length / 12;
                return check(e2.Length, data);
            }
            else if (e1.Unit.Contains("feet"))
            {
                data = e1.Length * 12;
                return check(e2.Length, data);
            }
            return false;
            //convert into feet for comparison

        }
        public bool compareInchAndYard(CheckEquals e1, CheckEquals e2)
        {
            double data;
            if (e1.Unit.Contains("inch"))
            {
                 data = e1.Length / 36;
                return check(e2.Length, data);
            }
            else if (e1.Unit.Contains("yard"))
            {
                data = e1.Length * 36;
                return check(e2.Length, data);
            }
            return false;
            //convert into feet for comparison

        }
        public bool comparefeetAndYard(CheckEquals e1, CheckEquals e2)
        {
            double data;
            if (e1.Unit.Contains("feet"))
            {
                data = e1.Length / 3;
                return check(e2.Length, data);
            }
            else if (e1.Unit.Contains("yard"))
            {
                data = e1.Length * 3;
                return check(e2.Length, data);
            }
            return false;
            //convert into feet for comparison

        }
        public bool check(double data2, double data)
        {
            if (data2 == data)
            {
                return true;
            }
            return false;
        }

        /*public double conversionLength(string unit, double length)
        {
            if (unit.Contains("inch"))
            {
                return length;
            }
            if (unit.Contains("Feet"))
            {
                return length*12;
            }
             if (unit.Contains("yard"))
            {
                return length * 12 * 3;
            }
            return 0;
        }
        public bool compareInchToFeet(double inch, double feet)
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
            double FeetToInch = feet * 12;

            //if feet and inchToFeet is same then return 1 else return 0
            if (inch == FeetToInch)
            {
                return true;
            }
            return false;
        }
        public bool compareInchToYard(double inch, double yard)
        {
            //convert into yard for comparison
            double inchToYard = inch/36;

            //if feet and inchToFeet is same then return 1 else return 0
            if (yard == inchToYard)
            {
                return true;
            }
            return false;

        }
        public bool compareYardToInch(double yard, double inch)
        {
            //convert into inch for comparison
            double yardToInch = yard * 36;

            //if feet and inchToFeet is same then return 1 else return 0
            if (inch == yardToInch)
            {
                return true;
            }
            return false;
        }
        public bool compareFeetToYard(double feet, double yard)
        {
            //convert into yard for comparison
            double feetToYard = feet / 3;

            //if feet and inchToFeet is same then return 1 else return 0
            if (yard == feetToYard)
            {
                return true;
            }
            return false;

        }
        public bool compareYardToFeet(double yard, double feet)
        {
            //convert into inch for comparison
            double yardTofeet = yard/3;

            //if feet and inchToFeet is same then return 1 else return 0
            if (feet == yardTofeet)
            {
                return true;
            }
            return false;
        }*/
    }
}
