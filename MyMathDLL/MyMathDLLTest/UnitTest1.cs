using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMathDLL;

namespace MyMathDLLTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            Assert.AreEqual(MyMath.Add(1, 2), 3);
        }

        [TestMethod]
        public void SubtractTest()
        {
            Assert.AreEqual(MyMath.Subtract(1, 2), -1);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            Assert.AreEqual(MyMath.Multiply(1, 2), 2);
        }

        [TestMethod]
        public void DivideTest()
        {
            Assert.AreEqual(MyMath.Divide(1, 2), 0.5);
        }
    }
}
