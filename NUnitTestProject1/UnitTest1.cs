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
    }
}