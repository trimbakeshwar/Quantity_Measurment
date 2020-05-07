using NUnit.Framework;
using Quantity_Measurment;
using Quantity_Measurment;

namespace NUnitTestProject1
{
    public class Tests
    {
        CheckEquals data = new CheckEquals();
        CompareLength comp = new CompareLength();
        AddLengths add = new AddLengths();
        // conversion compare = new conversion();
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// compare feet or inch
        /// </summary>
        [Test]
        public void CompareFeetOrInch()
        {
            conversion compare = new conversion();
            //compare feet and inch
            //if same then return 1 else return 0
            CheckEquals data = new CheckEquals("inch", 12);
            CheckEquals data2 = new CheckEquals("feet", 1);
            bool sameOrNot = comp.compare(data, data2);
            Assert.IsTrue(sameOrNot);
        }
        /// <summary>
        /// send null as argument
        /// </summary>
        [Test]
        public void checkForNull()
        {
            CheckEquals data = new CheckEquals();
            Assert.IsFalse(data.equals(null));
        }
        /// <summary>
        /// check for wrong refrance
        /// </summary>
        [Test]
        public void checkForWrongRefrance()
        {
            CheckEquals data = new CheckEquals("inch", 5);
            CheckEquals data2 = new CheckEquals("feet", 5);
            Assert.IsFalse(data.equals(data2));
        }
        /// <summary>
        /// check for wrong type
        /// if send wrong datatype of objct
        /// </summary>
        [Test]
        public void checkForWrongType()
        {
            CheckEquals data = new CheckEquals("inch", 5);
            object o = new object();
            Assert.IsFalse(data.equals(o));
        }
        /// <summary>
        /// check for same value
        /// </summary>
        [Test]
        public void checkEqualse()
        {
            CheckEquals data = new CheckEquals("inch", 5);

            Assert.IsTrue(data.equals(data));
        }
        /// <summary>
        /// compareOneFeet with 1 inch
        /// </summary>
        [Test]
        public void compare_1ft_with_1inch()
        {
            CheckEquals data = new CheckEquals("feet", 1);
            CheckEquals data2 = new CheckEquals("inch", 1);
            Assert.IsFalse(comp.compare(data, data2));
        }
        /// <summary>
        /// compare 1 inch with 1 feet
        /// </summary>
        [Test]
        public void compare_1inch_With_1ft()
        {
            CheckEquals data = new CheckEquals("inch", 1);
            CheckEquals data2 = new CheckEquals("feet", 1);
            Assert.IsFalse(comp.compare(data, data2));
        }
        /// <summary>
        /// compare  1 feet with 12 inch 
        /// </summary>
        [Test]
        public void compare_1ft_With_12inch()
        {
            CheckEquals data = new CheckEquals("feet", 1);
            CheckEquals data2 = new CheckEquals("inch", 12);
            Assert.IsTrue(comp.compare(data, data2));
        }
        /// <summary>
        /// compare 12 inch with 1 feet
        /// </summary>
        [Test]
        public void compare_12inch_With_1ft()
        {
            CheckEquals data = new CheckEquals("inch", 12);
            CheckEquals data2 = new CheckEquals("feet", 1);
            Assert.IsTrue(comp.compare(data, data2));
        }
        /// <summary>
        /// compare  3 feet with 1 yard
        /// </summary>
        [Test]
        public void compare_3feet_With_1yard()
        {
            CheckEquals data = new CheckEquals("feet", 3);
            CheckEquals data2 = new CheckEquals("yard", 1);
            Assert.IsTrue(comp.compare(data, data2));
        }
        /// <summary>
        /// compare  3 feet with 1 yard
        /// </summary>
        [Test]
        public void compare_1feet_With_1yard()
        {
            CheckEquals data = new CheckEquals("feet", 1);
            CheckEquals data2 = new CheckEquals("yard", 1);
            Assert.IsFalse(comp.compare(data, data2));
        }
        /// <summary>
        /// compare  1 inch  with 1 yard
        /// </summary>
        [Test]
        public void compare_1inch_With_1yard()
        {
            CheckEquals data = new CheckEquals("inch", 1);
            CheckEquals data2 = new CheckEquals("yard", 1);
            Assert.IsFalse(comp.compare(data, data2));
        }

        /// <summary>
        /// compare  36 inch  with 1 yard
        /// </summary>
        [Test]
        public void compare_36inch_With_1yard()
        {
            CheckEquals data = new CheckEquals("inch", 36);
            CheckEquals data2 = new CheckEquals("yard", 1);
            Assert.IsTrue(comp.compare(data, data2));
        }
        /// <summary>
        /// compare  36 inch  with 1 yard
        /// </summary>
        [Test]
        public void compare_1yard_with_3feet()
        {
            CheckEquals data = new CheckEquals("yard", 1);
            CheckEquals data2 = new CheckEquals("feet", 3);
            Assert.IsTrue(comp.compare(data, data2));
        }
        /// <summary>
        /// compare  2 inch  with 5cm
        /// </summary>
        [Test]
        public void compare_2inch_with_5cm()
        {
            CheckEquals data = new CheckEquals("inch", 2);
            CheckEquals data2 = new CheckEquals("cm", 5);
            Assert.IsTrue(comp.compare(data, data2));
        }
        /// <summary>
        /// compare   5cm with 2inch
        /// </summary>
        [Test]
        public void compare_5cm_with_2inch()
        {
            CheckEquals data = new CheckEquals("cm", 5);
            CheckEquals data2 = new CheckEquals("inch", 2);
            Assert.IsTrue(comp.compare(data, data2));
        }
        /// <summary>
        /// Add 2 inch and 2 inch 
        /// </summary>
        [Test]
        public void Add_2in_and_2in()
        {
            CheckEquals data = new CheckEquals("inch", 2);
            CheckEquals data2 = new CheckEquals("inch", 2);
            double output = add.AddTwoLength(data, data2);
            Assert.AreEqual(4, output);
        }
        /// <summary>
        /// Add 2 inch and 2 inch 
        /// </summary>
        [Test]
        public void Add_1ft_and_2in()
        {
            CheckEquals data = new CheckEquals("feet", 1);
            CheckEquals data2 = new CheckEquals("inch", 2);
            double output = add.AddTwoLength(data, data2);
            Assert.AreEqual(14, output);
        }
        /// <summary>
        /// Add 1ft and 1ft 
        /// </summary>
        [Test]
        public void Add_1ft_and_1ft()
        {
            CheckEquals data = new CheckEquals("feet", 1);
            CheckEquals data2 = new CheckEquals("feet", 1);
            double output = add.AddTwoLength(data, data2);
            Assert.AreEqual(24, output);
        }
        /// <summary>
        /// Add 2 inch and 2.5 cm 
        /// </summary>
        [Test]
        public void Add_in_and_CM()
        {
            CheckEquals data = new CheckEquals("inch", 2);
            CheckEquals data2 = new CheckEquals("cm", 2.5);
            double output = add.AddTwoLength(data, data2);
            Assert.AreEqual(3, output);
        }
        /// <summary>
        /// compare   5cm with 2inch
        /// </summary>
        [Test]
        public void compare_gelon_with_liter()
        {
            CheckEquals data = new CheckEquals("gelon", 1);
            CheckEquals data2 = new CheckEquals("liter", 3.78);
            Assert.IsTrue(comp.compare(data, data2));
        }
        /// <su
        ///  /// <summary>
        /// compare   5cm with 2inch
        /// </summary>
        [Test]
        public void compare_liter_with_gelon()
        {
            CheckEquals data = new CheckEquals("liter", 3.78);
            CheckEquals data2 = new CheckEquals("gelon", 1);
            Assert.IsTrue(comp.compare(data, data2));
        }
        ///  /// <summary>
        /// compare   5cm with 2inch
        /// </summary>
        [Test]
        public void compare_liter_with_ml()
        {
            CheckEquals data = new CheckEquals("liter", 1);
            CheckEquals data2 = new CheckEquals("ml", 1000);
            Assert.IsTrue(comp.compare(data, data2));
        }

        ///  /// <summary>
        /// compare   5cm with 2inch
        /// </summary>
        [Test]
        public void compare_ml_with_liter()
        {
            CheckEquals data = new CheckEquals("ml", 1000);
            CheckEquals data2 = new CheckEquals("liter", 1);
            Assert.IsTrue(comp.compare(data, data2));
        }
        /// <summary>
        /// Add liter and gelon 
        /// </summary>
        [Test]
        public void Add_liter_and_gelon()
        {
            CheckEquals data = new CheckEquals("gelon", 1);
            CheckEquals data2 = new CheckEquals("liter", 3.78);
            double output = add.AddTwoVolumeInLiter(data, data2);
            Assert.AreEqual(7.56, output);
        }
        /// <summary>
        /// Add liter and gelon 
        /// </summary>
        [Test]
        public void Add_liter_and_ml()
        {
            CheckEquals data = new CheckEquals("liter", 1);
            CheckEquals data2 = new CheckEquals("ml", 1000);
            double output = add.AddTwoVolumeInLiter(data, data2);
            Assert.AreEqual(2, output);
        }
    }
}