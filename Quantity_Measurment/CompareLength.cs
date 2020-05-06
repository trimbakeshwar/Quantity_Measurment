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



            return false;                        
        }
    }
}
