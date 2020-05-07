using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{
    class conversionWeight
    {
        /// <summary>
        /// compare and convert kg to gram and gram to kg
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public dynamic ComparekgAndGram(CheckEquals e1, CheckEquals e2)
        {
            try
            {
                double data;
                //if unit containt kg then convert into gram
                if (e1.Unit.Contains("kg"))
                {
                    //store converted data in data
                    data = e1.Length * 1000;
                    return check(e2.Length, data);
                }
                //if unit containt gram then convert into kg
                else if (e1.Unit.Contains("gram"))
                {
                    //store converted data in data
                    data = e1.Length / 1000;
                    return check(e2.Length, data);
                }
                else
                {
                    //unit type is not inch or feet then throws exception
                    throw new QuantityMeasurmentException(QuantityMeasurmentException.ExceptionType.INVALID_UNIT, "enter proper unit kg or gram");
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
        /// covert all weights into kg
        /// </summary>
        /// <param name="e1"></param>
        /// <returns></returns>
        public dynamic convertTokg(CheckEquals e1)
        {
            try
            {
                //if unit containt kg then return same value
                if (e1.Unit.Contains("kg"))
                {
                    return e1.Length;
                }
                //if unit containt tonne then coverted into kg and return
                else if (e1.Unit.Contains("tonne"))
                {
                    return e1.Length * 1000;
                }
                //if unit containt tonne then coverted into kg and return
                else if (e1.Unit.Contains("gram"))
                {
                    return e1.Length / 1000;
                }
                else
                {
                    //unit type is not inch or feet then throws exception
                    throw new QuantityMeasurmentException(QuantityMeasurmentException.ExceptionType.INVALID_UNIT, "enter only weight units");
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
        /// <summary>
        /// convert kg to tonne and tonne to kg and compare
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public dynamic ComparekgAndTonne(CheckEquals e1, CheckEquals e2)
        {
            try
            {
                double data;
                //if unit containt kg then convert into tonne
                if (e1.Unit.Contains("kg"))
                {
                    //store converted data in data
                    data = e1.Length / 1000;
                    //check equality
                    return check(e2.Length, data);
                }
                //if unit containt tonne then convert into kg
                else if (e1.Unit.Contains("tonne"))
                {
                    //store converted data in data
                    data = e1.Length * 1000;
                    //check equality
                    return check(e2.Length, data);
                }
                else
                {
                    //unit type is not inch or feet then throws exception
                    throw new QuantityMeasurmentException(QuantityMeasurmentException.ExceptionType.INVALID_UNIT, "enter proper unit kg or tonne");
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
