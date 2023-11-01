using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_the_number_given_when_countOff_given_normal_case()
        {
            // Given
            int givenNumber = 1;
            // When
            string result = FizzBuzzGame.CountOff(givenNumber);
            //Then
            Assert.Equal("1", result);
        }

        [Fact]
        public void Should_return_Fizz_when_countOff_given_multiple_of_3()
        {
            // Given
            int givenNumber = 3;
            // When
            string result = FizzBuzzGame.CountOff(givenNumber);
            //Then
            Assert.Equal("Fizz", result);
        }
    }
}