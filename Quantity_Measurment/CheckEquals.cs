using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{
    class CheckEquals
    {
        public double Feet{set; get;}
        public CheckEquals(double feet)
        {
            this.Feet = feet;
        }
        public Boolean equals(object feet)
        {
            if(feet==null)
            {
                return false;
            }
        }
    }
}
