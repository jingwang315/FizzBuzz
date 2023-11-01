using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public static string CountOff(int givenNumber)
        {
            if (givenNumber % 3 == 0)
            {
                if (givenNumber % 5 == 0)
                {
                    return "FizzBuzz";
                }
                else
                {
                    return "Fizz";
                }
            }
            else if (givenNumber % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return givenNumber.ToString();
            }
        }
    }
}
