using System;

namespace Quantity_Measurment
{
    class Program
    {
        public bool compareInchAndFeet(CheckEquals e1, CheckEquals e2)
        {
            double data;
            if (e1.Unit.Contains("inch"))
            {
                data = e1.Length / 12;
                return check(e2.Length, data);
            }
            else if (e1.Unit.Contains("feet"))
            {
                data = e1.Length * 12;
                return check(e2.Length, data);
            }
            return false;
            //convert into feet for comparison

        }
        public bool check(double data2, double data)
        {
            if (data2 == data)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {

            CheckEquals e1 = new CheckEquals("feet", 1);
            CheckEquals e2 = new CheckEquals("inch", 12);
           conversionLengths p = new conversionLengths();
            bool output = p.compareInchAndFeet(e1, e2);
            Console.WriteLine(""+output);
            CheckEquals e3 = new CheckEquals("inch", 12);
            CheckEquals e4 = new CheckEquals("feet", 1);
            Program p1= new Program();
            bool output1 = p1.compareInchAndFeet(e3, e4);
            Console.WriteLine("" + output1);
        }
    }
}
