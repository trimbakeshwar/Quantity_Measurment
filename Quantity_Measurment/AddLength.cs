using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{
    public class AddLengths
    {
        conversionLengths ConversionIntoLength = new conversionLengths();
        conversionWeight conversionIntoWeight = new conversionWeight();
        ConversionVolumes conversionIntoVolume = new ConversionVolumes();
        /// <summary>
        /// add two length differnt length units
        /// </summary>
        /// <param name="objectOne"></param>
        /// <param name="objectTwo"></param>
        /// <returns></returns>
        public double AddTwoLength(CheckEquals objectOne, CheckEquals objectTwo)
        {
            //convert length into inch and store in volume 1
            double valueOne = ConversionIntoLength.convertToInch(objectOne);
            //convert object two in inch and store in value 2
            double valueTwo = ConversionIntoLength.convertToInch(objectTwo);
            //add and return
            return valueOne + valueTwo;
        }
        /// <summary>
        /// add two volume differnt length
        /// </summary>
        /// <param name="objectOne"></param>
        /// <param name="objectTwo"></param>
        /// <returns></returns>
        public double AddTwoVolumeInLiter(CheckEquals objectOne, CheckEquals objectTwo)
        {
            //convert into liter and store in value 1
            double valueOne = conversionIntoVolume.convertToLiter(objectOne);
            //convert into liter and store in value 2
            double valueTwo = conversionIntoVolume.convertToLiter(objectTwo);
            //add and return
            return valueOne + valueTwo;
        }
        /// <summary>
        /// add two wight as diff init
        /// </summary>
        /// <param name="objectOne"></param>
        /// <param name="objectTwo"></param>
        /// <returns></returns>
        public double AddTwoweight(CheckEquals objectOne, CheckEquals objectTwo)
        {
            //convert into weight and store in value 1
            double valueOne = conversionIntoWeight.convertTokg(objectOne);
            //convert into weight and store in value 1
            double valueTwo = conversionIntoWeight.convertTokg(objectTwo);
            //add and return
            return valueOne + valueTwo;
        }
    }
}
