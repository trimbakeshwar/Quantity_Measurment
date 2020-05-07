using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{
    public class QuantityMeasurmentException:Exception
    {
        public enum ExceptionType
        {
            INVALID_UNIT
        }
        public ExceptionType type;
        public QuantityMeasurmentException(QuantityMeasurmentException.ExceptionType type,string massage):base(massage)
        {
            this.type = type;
        }
    }
}
