using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{
    public class CheckEquals
    {
        //seter and geter of feet
        public double Feet{set; get;}
       

        /// <summary>
        /// constructor to initialize
        /// </summary>
        /// <param name="feet">value in feet</param>
        ///  /// <param name="inch">value in inch</param>
        public CheckEquals(double feet,double inch)
        {
            this.Feet = feet;
          
        }

        public CheckEquals()
        {
        }

        /// <summary>
        /// create equles method to check equality
        /// </summary>
        /// <param name="obj">value for check</param>
        /// <returns></returns>
        public  Boolean equals(object obj)
        {
            //if object is null,refrence is different,type is diff,value is not same then return false 
            if ((obj == null) || (obj != this) || (obj.GetType() != this.GetType()))
            {
                return false;
            }
            //downcasting in object to checkEqualse method
            CheckEquals c = (CheckEquals)obj;
           //if value same then return true
            return Feet == c.Feet;
        }
    }
}
