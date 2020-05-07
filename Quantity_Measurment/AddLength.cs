using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{
    public class AddLengths
    {
        conversion convert = new conversion();
        public double AddTwoLength(CheckEquals object1, CheckEquals object2)
        {
            double value1 = convert.convertToInch(object1);
            double value2 = convert.convertToInch(object2);
            return value1 + value2;
        }
    }
}
