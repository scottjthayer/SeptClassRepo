using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestLecture
{
    public class ArithmeticTests
    {

        [Fact]
        public void TwoNumbersAddedUpWillSum()
        {
            //Arrange
            Arthmetic sut = new Arthmetic();

            //Act
            int result = sut.Sum(2, 3);

            //Assert
            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(3, 2, 5)]
        [InlineData(1, 0, 1)]
        [InlineData(-3, -2, -5)]
        public void MultipleTestsTwoNumbersAddedUpWillSum(int num1, int num2, int expected)
        {
            //Arrange
            Arthmetic sut = new Arthmetic();

            //Act
            int result = sut.Sum(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

        //test a new subtract method
        //one test as a [Fact]
        //one test as a [Theory]
        //after creating the tests, then write your method
        //if tests pass, then good
        //if fail, fix the method

        [Fact]
        public void TwoNumbersSubtractedWillDifferent()
        {
            //Arrange
            Arthmetic sut = new Arthmetic();
            //act
            int result = sut.Sub(2, 3);

            //assert
            Assert.Equal(-1, result);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(0, 1, -1)]
        [InlineData(-1, -2, 1)]
        public void MultiTwoNumbersSubtractedWillDifferent(int numOne, int numTwo, int expected)
        {
            //arrange
            Arthmetic sut = new Arthmetic();

            //Act
            int result = sut.Sub(numOne, numTwo);

            //Assert
            Assert.Equal(expected, result);
        }


    }
}
