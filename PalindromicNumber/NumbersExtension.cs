using System;

namespace PalindromicNumberTask
{
    /// <summary>
    /// Provides static method for working with integers.
    /// </summary>
    public static class NumbersExtension
    {
        /// <summary>
        /// Determines if a number is a palindromic number, see https://en.wikipedia.org/wiki/Palindromic_number.
        /// </summary>
        /// <param name="number">Verified number.</param>
        /// <returns>true if the verified number is palindromic number; otherwise, false.</returns>
        /// <exception cref="ArgumentException"> Thrown when source number is less than zero. </exception>
        public static bool IsPalindromicNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Wrong number", nameof(number));
            }

            if (number >= 0 && number <= 9)
            {
                return true;
            }

            if (GetFirstDigit(number) == number % 10)
            {
                number %= GetDigits(number);
                number /= 10;
                return IsPalindromicNumber(number);
            }

            return false;
        }

        private static int GetFirstDigit(int number)
        {
            while (number >= 10)
            {
                number /= 10;
            }

            return number;
        }

        private static int GetDigits(int number)
        {
            int counter = 1;
            while (number >= 10)
            {
                number /= 10;
                counter *= 10;
            }

            return counter;
        }
    }
}
