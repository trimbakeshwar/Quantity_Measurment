using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{
    class ConversionVolumes
    {
        /// <summary>
        /// compare and convert liter to galon or galon to liter
        /// </summary>
        /// <param name="e1">comparing object 1</param>
        /// <param name="e2">comparing object 2</param>
        /// <returns>return converted output</returns>
        public dynamic ComparevolumeInLiterAndGelon(CheckEquals e1, CheckEquals e2)
        {
            double data;
            try
            { //if unit containt liter then convert into galon
                if (e1.Unit.Contains("liter"))
                {
                    //store converted data in data
                    data = e1.Length / 3.78;
                    return check(e2.Length, data);
                }
                //if unit containt galon then convert into liter
                else if (e1.Unit.Contains("gelon"))
                {
                    //store converted data in data
                    data = e1.Length * 3.78;
                    return check(e2.Length, data);
                }
                else
                {
                    //unit type is not liter or gelon then throws exception
                    throw new QuantityMeasurmentException(QuantityMeasurmentException.ExceptionType.INVALID_UNIT, "enter proper unit liter or gelon");
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
        public dynamic ComparevolumeInLiterAndml(CheckEquals e1, CheckEquals e2)
        {
            try
            {
                double data;
                //if unit containt liter then convert into ml
                if (e1.Unit.Contains("liter"))
                {
                    //store converted data in data
                    data = e1.Length * 1000;
                    return check(e2.Length, data);
                }
                //if unit containt ml then convert into liter
                else if (e1.Unit.Contains("ml"))
                {
                    //store converted data in data
                    data = e1.Length / 1000;
                    return check(e2.Length, data);
                }
                else
                {
                    //unit type is not inch or feet then throws exception
                    throw new QuantityMeasurmentException(QuantityMeasurmentException.ExceptionType.INVALID_UNIT, "enter proper unit ml or liter");
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
        /// <summary>
        /// covert volume in liter
        /// </summary>
        /// <param name="e1"></param>
        /// <returns></returns>
        public dynamic convertToLiter(CheckEquals e1)
        {
            try
            {
                //if unit containt liter then send same volume
                if (e1.Unit.Contains("liter"))
                {
                    return e1.Length;
                }
                //if unit containt galon then convert in litter and return converted value
                else if (e1.Unit.Contains("gelon"))
                {
                    return e1.Length * 3.78;
                }
                //if unit containt ml then convert in litter and return converted value
                else if (e1.Unit.Contains("ml"))
                {
                    return e1.Length / 1000;
                }
                else
                {
                    //unit type is not inch or feet then throws exception
                    throw new QuantityMeasurmentException(QuantityMeasurmentException.ExceptionType.INVALID_UNIT, "enter only volume unit");
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


    }
}
