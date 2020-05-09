using NUnit.Framework;
using Quantity_measurment;
using sdkd;
using static Quantity_measurment.Measurment;

namespace NUnitTestProject1
    {
        public class Tests
        {
        Measurment measure = new Measurment();
        Additions add = new Additions();
        // conversion compare = new conversion();
        [SetUp]
            public void Setup()
            {
            }
            /// <summary>
            /// compare feet or inch
            /// </summary>
            [Test]
            public void CompareFeetToInch()
            {
                double output=measure.UnitConversion(Unit.FEET_TO_INCH, 1);
                Assert.AreEqual(12, output);
            }
            /// <summary>
            /// cgeck for invalid input
            /// </summary>
                [Test]
            public void checkForInvalidInput()
            {
                try
                {
                    double output = add.Addition(Unit.GALLON_TO_LITRE, 1, Unit.LITRE, 3.78);
                }
                catch(QuantityMeasurmentException exception)
                {
                    Assert.AreEqual("value is zero or invalid", exception.Message);
                }
                
            }
        /// <summary>
        /// send null as argument
        /// </summary>
        [Test]
            public void checkForNull()
            {
                
                Assert.IsFalse(measure.Equals(null));
            }
            /// <summary>
            /// check for wrong refrance
            /// </summary>
            [Test]
            public void checkForWrongRefrance()
            {
                Measurment measureOne = new Measurment();
                measureOne.UnitConversion(Unit.FEET_TO_INCH, 12);
                Measurment measureTwo = new Measurment();
                measureTwo.UnitConversion(Unit.FEET_TO_INCH, 12);
                Assert.IsFalse(measureOne.Equals(measureTwo));
            }
            /// <summary>
            /// check for wrong type
            /// if send wrong datatype of objct
            /// </summary>
            [Test]
            public void checkForWrongType()
            {
                Measurment measureOne = new Measurment();
                object o = new object();
                Assert.IsFalse(measureOne.Equals(o));
            }
            /// <summary>
            /// check for same value
            /// </summary>
            [Test]
            public void checkEqualse()
            {
                Measurment measureOne = new Measurment();
                double valueOne=measureOne.UnitConversion(Unit.FEET_TO_INCH, 12);
                double valueTwo = measureOne.UnitConversion(Unit.FEET_TO_INCH, 12);
                Assert.IsTrue(valueOne.Equals(valueTwo));
            }
            /// <summary>
            /// compareOneFeet with 1 inch
            /// </summary>
            [Test]
            public void compare_1ft_with_1inch()
            {
                
                double output=measure.UnitConversion(Unit.FEET_TO_INCH, 1);
                Assert.AreNotEqual(1, output);
               
            }
            /// <summary>
            /// compare 1 inch with 1 feet
            /// </summary>
            [Test]
            public void compare_1inch_With_1ft()
            {
                double output = measure.UnitConversion(Unit.INCH_TO_FEET, 1);
                Assert.AreNotEqual(1, output);
            }
            /// <summary>
            /// compare  1 feet with 12 inch 
            /// </summary>
            [Test]
            public void compare_1ft_With_12inch()
            {
                double output = measure.UnitConversion(Unit.FEET_TO_INCH, 1);
                Assert.AreEqual(12, output);
            }
            /// <summary>
            /// compare 12 inch with 1 feet
            /// </summary>
            [Test]
            public void compare_12inch_With_1ft()
            {

                double output = measure.UnitConversion(Unit.INCH_TO_FEET, 12);
                Assert.AreEqual(1, output);
            }
            /// <summary>
            /// compare  3 feet with 1 yard
            /// </summary>
            [Test]
            public void compare_3feet_With_1yard()
            {

                double output = measure.UnitConversion(Unit.FEET_TO_YARD, 3);
                Assert.AreEqual(1, output);
            }
            /// <summary>
            /// compare  3 feet with 1 yard
            /// </summary>
            [Test]
            public void compare_1feet_With_1yard()
            {

                double output = measure.UnitConversion(Unit.FEET_TO_YARD, 1);
                Assert.AreNotEqual(1, output);
            }
            /// <summary>
            /// compare  1 inch  with 1 yard
            /// </summary>
            [Test]
            public void compare_1inch_With_1yard()
            {

                double output = measure.UnitConversion(Unit.INCH_TO_YARD, 1);
                Assert.AreNotEqual(1, output);
            }

            /// <summary>
            /// compare  36 inch  with 1 yard
            /// </summary>
            [Test]
            public void compare_36inch_With_1yard()
            {

                double output = measure.UnitConversion(Unit.INCH_TO_YARD, 36);
                Assert.AreEqual(1, output);
            }
            /// <summary>
            /// compare  36 inch  with 1 yard
            /// </summary>
            [Test]
            public void compare_1yard_with_3feet()
            {

                double output = measure.UnitConversion(Unit.YARD_TO_FEET, 1);
                Assert.AreEqual(3, output);
            }
            /// <summary>
            /// compare  2 inch  with 5cm
            /// </summary>
            [Test]
            public void compare_2inch_with_5cm()
            {
                double output = measure.UnitConversion(Unit.INCH_TO_CM, 2);
                Assert.AreEqual(5, output);
            }
            /// <summary>
            /// compare   5cm with 2inch
            /// </summary>
            [Test]
            public void compare_5cm_with_2inch()
            {
                double output = measure.UnitConversion(Unit.CM_TO_INCH, 5);
                Assert.AreEqual(2, output);
            }
            /// <summary>
            /// Add 2 inch and 2 inch 
            /// </summary>
            [Test]
            public void Add_2in_and_2in()
            {
                double output = add.Addition(Unit.INCH, 2, Unit.INCH, 2);
                Assert.AreEqual(4, output);
            }
            /// <summary>
            /// Add 2 inch and 2 inch 
            /// </summary>
            [Test]
            public void Add_1ft_and_2in()
            {
                double output=add.Addition(Unit.FEET_TO_INCH, 1, Unit.INCH, 2);
                Assert.AreEqual(14, output);
            }
            /// <summary>
            /// Add 1ft and 1ft 
            /// </summary>
            [Test]
            public void Add_1ft_and_1ft()
            {          
                double output = add.Addition(Unit.FEET_TO_INCH, 1, Unit.FEET_TO_INCH, 1);
                Assert.AreEqual(24, output);
            }
           
            /// <summary>
            /// Add 2 inch and 2.5 cm 
            /// </summary>
            [Test]
            public void Add_in_and_CM()
            {
                double output = add.Addition(Unit.CM_TO_INCH, 2.5, Unit.INCH, 1);
                Assert.AreEqual(2, output);
            }
            /// <summary>
            /// compare   gelon with liter
            /// </summary>
            [Test]
            public void compare_gelon_with_liter()
            {
                double output = measure.UnitConversion(Unit.GALLON_TO_LITRE, 1);
                Assert.AreEqual(3.78, output);
            }
            /// <su
            ///  /// <summary>
            /// compare   liter with gelon
            /// </summary>
        [Test]
            public void compare_liter_with_gelon()
            {
                double output = measure.UnitConversion(Unit.LITRE_TO_GALLON, 3.78);
                Assert.AreEqual(1, output);
            }
            ///  /// <summary>
            /// compare   liter with ml
            /// </summary>
            [Test]
            public void compare_liter_with_ml()
            {
                double output = measure.UnitConversion(Unit.LITRE_TO_MILLILITER, 1);
                Assert.AreEqual(1000, output);
            }

            ///  /// <summary>
            /// compare   5cm with 2inch
            /// </summary>
            [Test]
            public void compare_ml_with_liter()
            {
                double output = measure.UnitConversion(Unit.MILLILITER_TO_LITRE, 1000);
                Assert.AreEqual(1, output);
            }
            /// <summary>
            /// Add liter and gelon 
            /// </summary>
            [Test]
            public void Add_liter_and_gelon()
            {
                double output = add.Addition(Unit.GALLON_TO_LITRE,1, Unit.LITRE, 3.78);
                Assert.AreEqual(7.56, output);
            }
            /// <summary>
            /// Add liter and ml 
            /// </summary>
            [Test]
            public void Add_liter_and_ml()
            {
                double output = add.Addition(Unit.MILLILITER_TO_LITRE, 1000, Unit.LITRE, 1);
                Assert.AreEqual(2, output);
            }
            
            /// <summary>
            /// Add kg and gram 
            /// </summary>
            [Test]
            public void comp_kg_and_gram()
            {

                double output=measure.UnitConversion(Unit.GRAMS_TO_KILOGRAM, 1000);
                Assert.AreEqual(1, output);
            }
            /// <summary>
            /// compare kg and tonne 
            /// </summary>
            [Test]
            public void comp_kg_and_tonne()
            {
                double output = measure.UnitConversion(Unit.TONNE_TO_KILOGRAM, 1);
                Assert.AreEqual(1000, output);
            }

            /// <summary>
            /// Add tonne and gram in kg 
            /// </summary>
            [Test]
            public void Add_in_kg()
            {
                double output=add.Addition(Unit.TONNE_TO_KILOGRAM, 1, Unit.GRAMS_TO_KILOGRAM, 1000);
                Assert.AreEqual(1001, output);

            }
        /// <summary>
        /// CompareFeraniteAndCelcius
        /// </summary>         
        [Test]
            public void CompareFeraniteAndCelcius()
            {

                double output=measure.UnitConversion(Unit.FAHRENHEIT_TO_CELSIUS, 212);
                Assert.AreEqual(100, output);
            }
            
    }
}