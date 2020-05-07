using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{
    public class CompareLength
    {
        conversion CoversionObject = new conversion();
        

        public bool compare(CheckEquals objOne, CheckEquals objTwo)
        { 
            if(objOne.Length==0 && objTwo.Length==0)
            {
                return true;
            }
            else if((objOne.Unit.Contains("inch")&& objTwo.Unit.Contains("feet"))|| (objOne.Unit.Contains("feet") && objTwo.Unit.Contains("inch")))
            {
                return CoversionObject.compareInchAndFeet(objOne, objTwo);
            }
            else if ((objOne.Unit.Contains("inch") && objTwo.Unit.Contains("yard")) || (objOne.Unit.Contains("yard") && objTwo.Unit.Contains("inch")))
            {
                return CoversionObject.compareInchAndYard(objOne, objTwo);
            }
            else if ((objOne.Unit.Contains("feet") && objTwo.Unit.Contains("yard")) || (objOne.Unit.Contains("yard") && objTwo.Unit.Contains("feet")))
            {
                return CoversionObject.comparefeetAndYard(objOne, objTwo);
            }
            else if ((objOne.Unit.Contains("inch") && objTwo.Unit.Contains("cm")) || (objOne.Unit.Contains("cm") && objTwo.Unit.Contains("inch")))
            {
                return CoversionObject.compareinchAndCM(objOne, objTwo);
            }
            else if ((objOne.Unit.Contains("gelon") && objTwo.Unit.Contains("liter")) || (objOne.Unit.Contains("liter") && objTwo.Unit.Contains("gelon")))
            {
                return CoversionObject.ComparevolumeInLiterAndGelon(objOne, objTwo);
            }
            else if ((objOne.Unit.Contains("liter") && objTwo.Unit.Contains("ml")) || (objOne.Unit.Contains("ml") && objTwo.Unit.Contains("liter")))
            {
                return CoversionObject.ComparevolumeInLiterAndml(objOne, objTwo);
            }
            else if ((objOne.Unit.Contains("kg") && objTwo.Unit.Contains("gram")) || (objOne.Unit.Contains("gram") && objTwo.Unit.Contains("kg")))
            {
                return CoversionObject.ComparekgAndGram(objOne, objTwo);
            }
            else if ((objOne.Unit.Contains("tonne") && objTwo.Unit.Contains("kg")) || (objOne.Unit.Contains("tonne") && objTwo.Unit.Contains("kg")))
            {
                return CoversionObject.ComparekgAndTonne(objOne, objTwo);
            }
            else if ((objOne.Unit.Contains("F") && objTwo.Unit.Contains("c")) || (objOne.Unit.Contains("c") && objTwo.Unit.Contains("F")))
            {
                return CoversionObject.equateFahrenheitAndCelsius(objOne, objTwo);
            }
          
            return false;                        
        }
    }
}
