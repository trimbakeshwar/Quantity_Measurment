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

        
    }
}
