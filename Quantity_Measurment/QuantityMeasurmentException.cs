using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_measurment
{
    public class QuantityMeasurmentException:Exception
    {
       public enum exceptionType
        {
            ENTER_VALID_INPUT
        }
        public exceptionType type;
       public  QuantityMeasurmentException(QuantityMeasurmentException.exceptionType type,string massage):base (massage)
        {
            this.type = type;
        }
    }
}
