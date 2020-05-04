using NUnit.Framework;
using Quantity_Measurment;
using Quantity_Measurment;

namespace NUnitTestProject1
{
    public class Tests
    {
        CheckEquals data = new CheckEquals();
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
            bool sameOrNot = compare.compareInchToFeet(1, 12);
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
            CheckEquals data = new CheckEquals("inch",5);
            CheckEquals data2 = new CheckEquals("feet",5);
            Assert.IsFalse(data.equals(data2));
        }
        /// <summary>
        /// check for wrong type
        /// if send wrong datatype of objct
        /// </summary>
        [Test]
        public void checkForWrongType()
        {
            CheckEquals data = new CheckEquals("inch",5);
            object o = new object();
            Assert.IsFalse(data.equals(o));
        }
      /// <summary>
      /// check for same value
      /// </summary>
        [Test]
        public void checkEqualse()
        {
            CheckEquals data = new CheckEquals("inch",5);
           
            Assert.IsTrue(data.equals(data));
        }
        /// <summary>
        /// send null as argument
        /// </summary>
       
    }
}