using System;
using TempConverter;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        //[Theory]
        //[InlineData(86, 30)]
        public void FtoC(int expected, int temp)
        {
            //ARRANGE

            var sut = new TestingClass();
            //ACT

            var actual = sut.FahrenheitConvert(temp);


            //ASSERT
            Assert.Equal(expected, actual);
        }
        //[Theory]
        //[InlineData(212, 100)]
        public void CtoF(int expected, int temp)
        {
            //ARRANGE

            var sut = new TestingClass();
            //ACT

            var actual = sut.FahrenheitConvert(temp);


            //ASSERT
            Assert.Equal(expected, actual);
        }

        [Theory]
        //[InlineData("Fizz", 31)]
       // [InlineData("FizzBuzz", 53)]
       // [InlineData("Baz", 71)]
        [InlineData("FizzBuzz", 15)]
       // [InlineData("FizzBuzzBaz", 35)]
        public void FizzBuzzBazz(string expected, int num)
        {
            //ARRANGE

            var sut = new TestingClass();
            //ACT

            var actual = sut.FizzBuzzBaz(num);


            //ASSERT
            Assert.Equal(expected, actual);
        }
    }
}
