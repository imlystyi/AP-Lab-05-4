// Lab_05_4_UT.cs
// Якубовський Владислав
// Unit-тест до програми Lab_05_4.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AP_Lab_05_4;

namespace AP_Lab_05_4_UT
{
    [TestClass]
    public class Lab_05_4_UT
    {
        [TestMethod]
        public void TestZeroSum()
        {
            double k = Lab_05_4.ZeroSum(5);

            Assert.AreEqual(4.759366, k, 0.001);
        }
    }
}
