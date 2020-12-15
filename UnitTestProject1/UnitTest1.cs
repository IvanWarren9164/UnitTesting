using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FtoC(bool expected, int age)
        {
            //ARRANGE
            var sut = new FahrenheitConvert();
            //ACT
            //ASSERT
        }
    }
}
