using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{

    /// <summary>
    /// convert in other unit and compare
    /// </summary>
    public class conversionLengths
    {
        /// <summary>
        /// compare inch and feet 
        ///
        /// </summary>
        /// <param name="e1">object of checkEqualse in this object containt unit and length</param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public dynamic compareInchAndFeet(CheckEquals e1, CheckEquals e2)
        {
            try 
            {
                double data;
                //if my first object e1.unit containt inch then inch convert into feet
                if (e1.Unit.Contains("inch"))
                {
                    //inch convert into feet by using this formula
                    data = e1.Length / 12;
                    //and check both are equals or not
                    return check(e2.Length, data);
                }
                //if first object unit containt feet then convert into inch 
                else if (e1.Unit.Contains("feet"))
                {
                    //feet covert into inch
                    data = e1.Length * 12;
                    //check boot are equal
                    return check(e2.Length, data);
                }
                else
                {
                    //unit type is not inch or feet then throws exception
                    throw new QuantityMeasurmentException(QuantityMeasurmentException.ExceptionType.INVALID_UNIT, "enter proper unit inch or feet"); 
                }               
            }
            catch(QuantityMeasurmentException e)
            {

                throw new QuantityMeasurmentException(QuantityMeasurmentException.ExceptionType.INVALID_UNIT, e.Message);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
           
        }
        /// <summary>
        /// convert inch to yard or yard to inch
        /// </summary>
        /// <param name="e1">object 1 of unit an length</param>
        /// <param name="e2">object 2</param>
        /// <returns></returns>
        public dynamic compareInchAndYard(CheckEquals e1, CheckEquals e2)
        {
            double data;
            try
            { //if unit containt inch then covert into yard
                if (e1.Unit.Contains("inch"))
                {
                    //convert inch to yard
                    data = e1.Length / 36;
                    //check both are same or not
                    return check(e2.Length, data);
                }
                //if unit containt yard then convert into inch
                else if (e1.Unit.Contains("yard"))
                {
                    // convert yard to inch 
                    data = e1.Length * 36;
                    //check both are same or not
                    return check(e2.Length, data);
                }
                else
                {
                    //unit type is not inch or feet then throws exception
                    throw new QuantityMeasurmentException(QuantityMeasurmentException.ExceptionType.INVALID_UNIT, "enter proper unit inch or yard");
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
        /// compare and convert yard to feet or feet to yard
        /// </summary>
        /// <param name="e1">compare object 1</param>
        /// <param name="e2">compare object 2</param>
        /// <returns></returns>
        public dynamic comparefeetAndYard(CheckEquals e1, CheckEquals e2)
        {
            double data;
            try
            {
                //if unit containt feet then convert into yard
                if (e1.Unit.Contains("feet"))
                {
                    //convert into yard and store in data
                    data = e1.Length / 3;
                    //check equal or not
                    return check(e2.Length, data);
                }
                //if unit containt yard then convert into feet
                else if (e1.Unit.Contains("yard"))
                {
                    //convert into feet and store in data
                    data = e1.Length * 3;
                    //check equal or not
                    return check(e2.Length, data);
                }
                else
                {
                    //unit type is not inch or feet then throws exception
                    throw new QuantityMeasurmentException(QuantityMeasurmentException.ExceptionType.INVALID_UNIT, "enter proper unit feet or yard");
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
        /// compare and convert inch to cm cm to inch
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public dynamic compareinchAndCM(CheckEquals e1, CheckEquals e2)
        {
            double data;
            try
            {//convert inch to cm 
                if (e1.Unit.Contains("inch"))
                {
                    //convert and store in data
                    data = e1.Length * 2.5;
                    //check quality
                    return check(e2.Length, data);
                }
                //convert cm into inch
                else if (e1.Unit.Contains("cm"))
                {
                    //store convertted data 
                    data = e1.Length / 2.5;
                    //check equality
                    return check(e2.Length, data);
                }
                else
                {
                    //unit type is not inch or feet then throws exception
                    throw new QuantityMeasurmentException(QuantityMeasurmentException.ExceptionType.INVALID_UNIT, "enter proper unit inch or cm");
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
        /// if we send feet,yard overt into inch
        /// </summary>
        /// <param name="e1"></param>
        /// <returns></returns>
        public dynamic convertToInch(CheckEquals e1)
        {
            try
            { //if unit containt inch then return length and return 
                if (e1.Unit.Contains("inch"))
                {
                    return e1.Length;
                }
                //if unit containt feet then convert into inch and return
                else if (e1.Unit.Contains("feet"))
                {
                    return e1.Length * 12;
                }
                //if unit containt yard then convert into inch
                else if (e1.Unit.Contains("yard"))
                {
                    return e1.Length * 12 * 3;
                }
                //if unit containt cm then convert into inch
                else if (e1.Unit.Contains("cm"))
                {
                    return e1.Length / 2.5;
                }
                else
                {
                    //unit type is not inch or feet then throws exception
                    throw new QuantityMeasurmentException(QuantityMeasurmentException.ExceptionType.INVALID_UNIT, "enter only length unit");
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
