using CalculatorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace CalculatorTest
{
    public class CalculatorTest
    {
        private readonly Calculator _sut = new ();
        private readonly ITestOutputHelper _outHelper;

        //Setup goes here
        public CalculatorTest(ITestOutputHelper outHelper)
        {
            _outHelper = outHelper;
            _outHelper.WriteLine("Hello from ctor");
        }

        [Fact]
        public void Add_ShouldAddTwoNumbers_WheTwoNumbersAreIntegers()
        {

            //Act
            var result = _sut.Add(5, 4);

            //Assert
            Assert.Equal(9, result);
        }

        [Theory]
        [InlineData(5,5,10)]
        [InlineData(-5,5,0)]
        [InlineData(-15,-5,-20)]
        public void Add_ShouldAddTwoNumbers_WheTwoNumbersAreIntegers2(int a, int b, int expected)
        {

            //Act
            var result = _sut.Add(a, b);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact(Skip = "This is just a test")]
        public void Substract_ShouldSubstractTwoNumbers_WheTwoNumbersAreIntegers()
        {

            //Act
            var result = _sut.Add(10, 5);

            //Assert
            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(5,5,0)]
        [InlineData(15,5,10)]
        [InlineData(-5,-5,0)]
        [InlineData(-15,-5,-10)]
        [InlineData(5,10,-5)]
        public void Substract_ShouldSubstractTwoNumbers_WheTwoNumbersAreIntegers2(int a, int b, int expected)
        {

            //Act
            var result = _sut.Substract(a, b);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(50, 0, 0)]
        [InlineData(-5, 5, -25)]
        public void Multiply_ShouldMultiplyTwoNumbers_WheTwoNumbersAreIntegers(int a, int b, int expected)
        {

            //Act
            var result = _sut.Multiply(a, b);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 5, 1)]
        [InlineData(15, 5, 3)]
        public void Divide_ShouldDivideTwoNumbers_WheTwoNumbersAreFloats(float a, float b, float expected)
        {
            //Act
            var result = _sut.Divide(a, b);

            //Assert
            Assert.Equal(expected, result);
        }
        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task DisposeAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task InitializeAsync()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
