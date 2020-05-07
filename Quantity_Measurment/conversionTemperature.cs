using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{
    class conversionTemperature
    {
        /// <summary>
        /// convert f to cand c to f and check equality
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public dynamic equateFahrenheitAndCelsius(CheckEquals e1, CheckEquals e2)
        {
            try
            {
                double data;
                //convert f to c
                if (e1.Unit.Contains("F"))
                {
                    //store converted data
                    data = ((e1.Length - 32.0) * 5.0 / 9.0);
                    //check equality
                    return check(e2.Length, data);
                }
                //convert c to f
                else if (e1.Unit.Contains("c"))
                {
                    //store converted data
                    data = ((e1.Length * 9 / 5) + 32);
                    //check equality
                    return check(e2.Length, data);
                }
                else
                {
                    //unit type is not inch or feet then throws exception
                    throw new QuantityMeasurmentException(QuantityMeasurmentException.ExceptionType.INVALID_UNIT, "enter proper f or c");
                }
            }
            catch (QuantityMeasurmentException e)
            {

                throw new QuantityMeasurmentException(QuantityMeasurmentException.ExceptionType.INVALID_UNIT, e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        //check two value ame or not
        public bool check(double dataTwo, double data)
        {
            if (dataTwo == data)
            {
                return true;
            }
            return false;
        }
    }
}
