using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{
    public class CompareLength
    {
        conversion CoversionObject = new conversion();

        public bool compare(double objOne, string unitOne, dynamic objTwo, string unitTwo)
        {
            dynamic valueOne = CoversionObject.conversionLength(unitOne, objOne);
            dynamic valueTwo = CoversionObject.conversionLength(unitTwo, objTwo);
            if (valueOne == valueTwo)
            {
                return true;
            }
            return false;
        }
    }
}
