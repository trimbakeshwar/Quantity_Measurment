using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{
    public class CompareValuesOnTheBasisOfLength
    {
        //create object of conversion length class
        conversionLengths ConversionIntoLength = new conversionLengths();
        //create object of conversion temp class
        conversionTemperature conversionIntoTemp = new conversionTemperature();
        //create object of conversion weight class
        conversionWeight conversionIntoWeight = new conversionWeight();
        //create object of conversion volume class
        ConversionVolumes conversionIntoVolume = new ConversionVolumes();
        /// <summary>
        /// compare two dii lengths and return true or false
        /// </summary>
        /// <param name="objOne"></param>
        /// <param name="objTwo"></param>
        /// <returns></returns>
        public bool compareLength(CheckEquals objOne, CheckEquals objTwo)
        { 
            //if lenght is 0 univarsaly 0 not converted into other unit so return true
            if(objOne.Length==0 && objTwo.Length==0)
            {
                return true;
            }
            //check if object one cantaint inch or feet and obj 2 containt feet or inch call compareinch and feet method
            else if((objOne.Unit.Contains("inch")&& objTwo.Unit.Contains("feet"))|| (objOne.Unit.Contains("feet") && objTwo.Unit.Contains("inch")))
            {
                //if both object same then then return true if not same then return false
                return ConversionIntoLength.compareInchAndFeet(objOne, objTwo);
            }
            //check if object one cantaint inch or yard and obj 2 containt yard or inch call compareInchAndYard
            else if ((objOne.Unit.Contains("inch") && objTwo.Unit.Contains("yard")) || (objOne.Unit.Contains("yard") && objTwo.Unit.Contains("inch")))
            {
                //if both object same then then return true if not same then return false
                return ConversionIntoLength.compareInchAndYard(objOne, objTwo);
            }
            //check if object one cantaint yard or feet and obj 2 containt feet or yard call comparefeetAndYard
            else if ((objOne.Unit.Contains("feet") && objTwo.Unit.Contains("yard")) || (objOne.Unit.Contains("yard") && objTwo.Unit.Contains("feet")))
            {
                //if both object same then then return true if not same then return false
                return ConversionIntoLength.comparefeetAndYard(objOne, objTwo);
            }
            //check if object one cantaint inch or cm and obj 2 containt cm or inch call compareinchAndCM
            else if ((objOne.Unit.Contains("inch") && objTwo.Unit.Contains("cm")) || (objOne.Unit.Contains("cm") && objTwo.Unit.Contains("inch")))
            {
                //if both object same then then return true if not same then return false
                return ConversionIntoLength.compareinchAndCM(objOne, objTwo);
            }
                       
            return false;                        
        }
        /// <summary>
        /// compare volumes
        /// </summary>
        /// <param name="objOne"></param>
        /// <param name="objTwo"></param>
        /// <returns></returns>
        public bool compareVolume(CheckEquals objOne, CheckEquals objTwo)
        {
            if (objOne.Length == 0 && objTwo.Length == 0)
            {
                return true;
            }
            //check if object one cantaint gelon or liter and obj 2 containt liter or gelon call ComparevolumeInLiterAndGelon
            else if ((objOne.Unit.Contains("gelon") && objTwo.Unit.Contains("liter")) || (objOne.Unit.Contains("liter") && objTwo.Unit.Contains("gelon")))
            {
                //if both object same then then return true if not same then return false
                return conversionIntoVolume.ComparevolumeInLiterAndGelon(objOne, objTwo);
            }
            //check if object one cantaint liter or ml and obj 2 containt ml or liter call ComparevolumeInLiterAndml
            else if ((objOne.Unit.Contains("liter") && objTwo.Unit.Contains("ml")) || (objOne.Unit.Contains("ml") && objTwo.Unit.Contains("liter")))
            {
                //if both object same then then return true if not same then return false
                return conversionIntoVolume.ComparevolumeInLiterAndml(objOne, objTwo);
            }
            return false;
        }
        /// <summary>
        /// compare weights
        /// </summary>
        /// <param name="objOne"></param>
        /// <param name="objTwo"></param>
        /// <returns></returns>
        public bool compareWeight(CheckEquals objOne, CheckEquals objTwo)
        {
            if (objOne.Length == 0 && objTwo.Length == 0)
            {
                return true;
            }
            //check if object one cantaint kg or gram and obj 2 containt gram or kg call ComparekgAndGram
            else if ((objOne.Unit.Contains("kg") && objTwo.Unit.Contains("gram")) || (objOne.Unit.Contains("gram") && objTwo.Unit.Contains("kg")))
            {
                //if both object same then then return true if not same then return false
                return conversionIntoWeight.ComparekgAndGram(objOne, objTwo);
            }
            //check if object one cantaint tonne or kg and obj 2 containt tonne or kg call ComparekgAndTonne
            else if ((objOne.Unit.Contains("tonne") && objTwo.Unit.Contains("kg")) || (objOne.Unit.Contains("kg") && objTwo.Unit.Contains("tonne")))
            {
                //if both object same then then return true if not same then return false
                return conversionIntoWeight.ComparekgAndTonne(objOne, objTwo);
            }
            return false;
        }
        public bool equateTemparature(CheckEquals objOne, CheckEquals objTwo)
        {

            if (objOne.Length == 0 && objTwo.Length == 0)
            {
                return true;
            }
            //check if object one cantaint f or c and obj 2 containt c or f call equateFahrenheitAndCelsius
            else if ((objOne.Unit.Contains("F") && objTwo.Unit.Contains("c")) || (objOne.Unit.Contains("c") && objTwo.Unit.Contains("F")))
            {
                //if both object same then then return true if not same then return false
                return conversionIntoTemp.equateFahrenheitAndCelsius(objOne, objTwo);
            }
            return false;

        }
    }
}
