using NUnit.Framework;
using Quantity_Measurment;
using Quantity_Measurment.Quantity_Measurment;

namespace NUnitTestProject1
{
    public class Tests
    {
        CheckEqualsForInch feet = new CheckEqualsForInch();
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
            CompareLength compare = new CompareLength();
            //compare feet and inch
            //if same then return 1 else return 0
            int sameOrNot = compare.compareFeetInch(1, 12);
            Assert.AreEqual(1, sameOrNot);
        }
        /// <summary>
        /// send null as argument
        /// </summary>
        [Test]
        public void checkForNullForFeet()
        {
            CheckEquals feet = new CheckEquals();
            Assert.IsFalse(feet.equals(null));
        }
        /// <summary>
        /// check for wrong refrance
        /// </summary>
        [Test]
        public void checkForWrongRefranceForFeet()
        {
            CheckEquals feet = new CheckEquals();
            CheckEquals feet2 = new CheckEquals();
            Assert.IsFalse(feet.equals(feet2));
        }
        /// <summary>
        /// check for wrong type
        /// if send wrong datatype of objct
        /// </summary>
        [Test]
        public void checkForWrongTypeForFeet()
        {
            CheckEquals feet = new CheckEquals();
            object o = new object();
            Assert.IsFalse(feet.equals(o));
        }
      /// <summary>
      /// check for same value
      /// </summary>
        [Test]
        public void checkEqualse()
        {
            CheckEquals feet = new CheckEquals();
            feet.Feet = 5;
            Assert.IsTrue(feet.equals(feet));
        }
        /// <summary>
        /// send null as argument
        /// </summary>
        [Test]
        public void checkForNullForInch()
        {
           
            Assert.IsFalse(feet.equals(null));
        }
        /// <summary>
        /// check for wrong refrance
        /// </summary>
        [Test]
        public void checkForWrongRefranceForInch()
        {
            CheckEqualsForInch feet2 = new CheckEqualsForInch();
            Assert.IsFalse(feet.equals(feet2));
        }
        /// <summary>
        /// check for wrong type
        /// if send wrong datatype of objct
        /// </summary>
        [Test]
        public void checkForWrongTypeForInch()
        {
           
            object o = new object();
            Assert.IsFalse(feet.equals(o));
        }
        /// <summary>
        /// check for same value
        /// </summary>
        [Test]
        public void checkEqualseForInch()
        {
            CheckEqualsForInch feet = new CheckEqualsForInch();
            feet.Feet = 5;
            Assert.IsTrue(feet.equals(feet));
        }
    }
}