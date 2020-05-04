using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace Quantity_Measurment
    {
        public class CheckEqualsForInch
        {
            //seter and geter of feet
            public double Inch { set; get; }


            /// <summary>
            /// constructor to initialize
            /// </summary>
            /// <param name="feet">value in feet</param>
            ///  /// <param name="inch">value in inch</param>
            public CheckEqualsForInch(double inch)
            {
                this.Inch = inch;

            }

            public CheckEqualsForInch()
            {
            }

            /// <summary>
            /// create equles method to check equality
            /// </summary>
            /// <param name="obj">value for check</param>
            /// <returns></returns>
            public Boolean equals(object obj)
            {
                //if object is null,refrence is different,type is diff,value is not same then return false 
                if ((obj == null) || (obj != this) || (obj.GetType() != this.GetType()))
                {
                    return false;
                }
                //downcasting in object to checkEqualse method
                CheckEqualsForInch c = (CheckEqualsForInch)obj;
                //if value same then return true
                return Inch == c.Inch;
            }
        }
    }

}
