using Quantity_measurment;
using System;
using static Quantity_measurment.Measurment;


namespace sdkd
{
    class Program
{
    static void Main(string[] args)
    {
            Measurment c = new Measurment();
            double output = c.UnitConversion(Unit.FEET_TO_INCH, 12);
            Console.WriteLine("o->" + output);
    }
}
}
