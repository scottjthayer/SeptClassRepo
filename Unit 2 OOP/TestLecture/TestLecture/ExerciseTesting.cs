using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace TestLecture
{
    public class ExerciseTesting
    {

        [Theory]
        [InlineData(32, "C", 0)]
        [InlineData(68, "C", 20)]
        [InlineData(100, "F", 212)]
        [InlineData(-40, "F", -40)]
        public void TempWillConvert(int temp, string unit, int expected)
        {
            //arrange
            Arthmetic sut = new Arthmetic();
            //act
            int result = sut.ConvertTemp(temp, unit);
            //assert
            Assert.Equal(expected, result);
        }
    }
}
