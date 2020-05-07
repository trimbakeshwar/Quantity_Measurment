using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{
    public class CheckEquals
    {
        //seter and geter of feet
        public double Length{set; get;}
        // public string Unit { set; get; }
        public string Unit { set; get; }
        CompareValuesOnTheBasisOfLength compare = new CompareValuesOnTheBasisOfLength();
        /// <summary>
        /// constructor to initialize
        /// </summary>
        /// <param name="feet">value in feet</param>
        ///  /// <param name="inch">value in inch</param>
        public  CheckEquals(string Unit,double length)
        {
            //value is assign in length
            this.Length = length;
            //unit is assign unit
            this.Unit = Unit;
          
        }

        public CheckEquals()
        {
        }

        /// <summary>
        /// create equles method to check equality
        /// </summary>
        /// <param name="obj">value for check</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //if object is null,refrence is different,type is diff,value is not same then return false 
            if ((obj == null) || (obj != this) || (obj.GetType() != this.GetType()))
            {
                return false;
            }
            //downcasting in object to checkEqualse method
            CheckEquals c = (CheckEquals)obj;
           //if value same then return true
            return (Length == c.Length)&&(Unit==c.Unit);
        }
    }
}
