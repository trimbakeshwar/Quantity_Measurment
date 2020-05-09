using Quantity_measurment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_measurment
{
    public class Additions
    {
        Measurment measure = new Measurment();
        public double Addition(double unit,double value,double unitTwo, double valueTwo)
        {
            try
            {
                if (value == 0 || valueTwo == 0)
                {
                    throw new QuantityMeasurmentException(QuantityMeasurmentException.exceptionType.ENTER_VALID_INPUT, "value is zero or invalid");
                }
                double dataOne = measure.UnitConversion(unit, value);
                double dataTwo = measure.UnitConversion(unitTwo, valueTwo);
                return dataOne + dataTwo;
            }
            catch(QuantityMeasurmentException e)
            {
                throw new QuantityMeasurmentException(QuantityMeasurmentException.exceptionType.ENTER_VALID_INPUT, "value is zero or invalid");
            }
        }
    }
}
