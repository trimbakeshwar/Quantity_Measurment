﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurment
{

    //comparison
    public class conversion
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
        public bool compareInchAndYard(CheckEquals e1, CheckEquals e2)
        {
            double data;
            if (e1.Unit.Contains("inch"))
            {
                 data = e1.Length / 36;
                return check(e2.Length, data);
            }
            else if (e1.Unit.Contains("yard"))
            {
                data = e1.Length * 36;
                return check(e2.Length, data);
            }
            return false;
            //convert into feet for comparison

        }
        public bool comparefeetAndYard(CheckEquals e1, CheckEquals e2)
        {
            double data;
            if (e1.Unit.Contains("feet"))
            {
                data = e1.Length / 3;
                return check(e2.Length, data);
            }
            else if (e1.Unit.Contains("yard"))
            {
                data = e1.Length * 3;
                return check(e2.Length, data);
            }
            return false;
            //convert into feet for comparison

        }
        public bool compareinchAndCM(CheckEquals e1, CheckEquals e2)
        {
            double data;
            if (e1.Unit.Contains("inch"))
            {
                data = e1.Length * 2.5;
                return check(e2.Length, data);
            }
            else if (e1.Unit.Contains("cm"))
            {
                data = e1.Length / 2.5;
                return check(e2.Length, data);
            }
            return false;
            //convert into feet for comparison

        }
        public bool check(double dataTwo, double data)
        {
            if (dataTwo == data)
            {
                return true;
            }
            return false;
        }
        public double convertToInch(CheckEquals e1)
        {
            if(e1.Unit.Contains("inch"))
            {
                return e1.Length;
            }
            else if(e1.Unit.Contains("feet"))
            {
                return e1.Length * 12;
            }
            else if (e1.Unit.Contains("yard"))
            {
                return e1.Length * 12 * 3;
            }
            else if (e1.Unit.Contains("cm"))
            {
                return e1.Length / 2.5;
            }
            return 0;
        }
        public bool ComparevolumeInLiterAndGelon(CheckEquals e1, CheckEquals e2)
        {
            double data;
            if (e1.Unit.Contains("liter"))
            {
                data = e1.Length/3.78;
                return check(e2.Length, data);
            }
            else if (e1.Unit.Contains("gelon"))
            {
                data = e1.Length*3.78;
                return check(e2.Length, data);
            }
            return false;
            //convert into feet for comparison

        }
        public bool ComparevolumeInLiterAndml(CheckEquals e1, CheckEquals e2)
        {
            double data;
            if (e1.Unit.Contains("liter"))
            {
                data = e1.Length * 1000;
                return check(e2.Length, data);
            }
            else if (e1.Unit.Contains("ml"))
            {
                data = e1.Length/1000;
                return check(e2.Length, data);
            }
            return false;
            //convert into feet for comparison

        }
        public bool ComparekgAndGram(CheckEquals e1, CheckEquals e2)
        {
            double data;
            if (e1.Unit.Contains("kg"))
            {
                data = e1.Length * 1000;
                return check(e2.Length, data);
            }
            else if (e1.Unit.Contains("gram"))
            {
                data = e1.Length / 1000;
                return check(e2.Length, data);
            }
            return false;
            //convert into feet for comparison

        }
        public bool ComparekgAndTonne(CheckEquals e1, CheckEquals e2)
        {
            double data;
            if (e1.Unit.Contains("kg"))
            {
                data = e1.Length * 1000;
                return check(e2.Length, data);
            }
            else if (e1.Unit.Contains("tonne"))
            {
                data = e1.Length / 1000;
                return check(e2.Length, data);
            }
            return false;
            //convert into feet for comparison

        }

        public double convertToLiter(CheckEquals e1)
        {
            if (e1.Unit.Contains("liter"))
            {
                return e1.Length;
            }
            else if (e1.Unit.Contains("gelon"))
            {
                return e1.Length*3.78;
            }
            else if (e1.Unit.Contains("ml"))
            {
                return e1.Length/1000;
            }
           
            return 0;

        }

        public double convertTokg(CheckEquals e1)
        {
            if (e1.Unit.Contains("kg"))
            {
                return e1.Length;
            }
            else if (e1.Unit.Contains("tonne"))
            {
                return e1.Length * 1000;
            }
            else if (e1.Unit.Contains("gram"))
            {
                return e1.Length / 1000;
            }

            return 0;

        }

    }
}
