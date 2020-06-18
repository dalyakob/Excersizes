using System;
using BONUS_1;
using Xunit;

namespace BONUS_1_UnitTest
{
    public class UnitTest1
    {
        [Theory]

        [InlineData(88,"A")]
        [InlineData(100,"A")]
        [InlineData(90,"A")]

        [InlineData(87,"B")]
        [InlineData(80,"B")]
        [InlineData(85,"B")]

        [InlineData(79,"C")]
        [InlineData(67,"C")]
        [InlineData(70,"C")]

        [InlineData(66,"D")]
        [InlineData(60,"D")]
        [InlineData(65,"D")]

        [InlineData(55,"E")]
        [InlineData(0,"E")]
        [InlineData(40,"E")]

        [InlineData(-1, null)]
        [InlineData(101, null)]



        public void GraderTests(int input, string expected)
        {
            //Arrange
            var grader = new Grader();

            //Act
            var result = grader.GetGrades(input);

            //Assert
            Assert.Equal(result, expected);
        }
    }
}
