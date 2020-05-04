using NUnit.Framework;
using Quantity_Measurment;

namespace NUnitTestProject1
{
    public class Tests
    {
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
        [Test]
        public void checkForNull()
        {
            CheckEquals feet = new CheckEquals();
            Assert.IsFalse(feet.equals(null));
        }
        [Test]
        public void checkForWrongType()
        {
            CheckEquals feet = new CheckEquals();
            object o = new object();
            Assert.IsFalse(feet.equals(o));
        }
        [Test]
        public void checkForWrongRefrance()
        {
            CheckEquals feet = new CheckEquals();
            CheckEquals feet2 = new CheckEquals();
            Assert.IsFalse(feet.equals(feet2));
        }
        [Test]
        public void checkEqualse()
        {
            CheckEquals feet = new CheckEquals();
            feet.Feet = 5;
            Assert.IsTrue(feet.equals(feet));
        }
    }
}