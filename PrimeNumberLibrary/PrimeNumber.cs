using System.ComponentModel.DataAnnotations;

namespace PrimeNumberLibrary
{
    public class PrimeNumber
    {
        public static int MIN_NATURAL_NUMBER = 1;

        public static bool ValidationNaturalNumber(int number)
        {
            return number >= MIN_NATURAL_NUMBER;
        }

        public static bool ValidationPrimeNumber(int number)
        {
            if (!ValidationNaturalNumber(number))
            {
                throw new ValidationException();
            }

            bool isPrime = true;

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}