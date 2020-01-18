using System;

namespace Task2
{
    /// <summary>
    /// This class is for finding correct number.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// This method is for finding gcd.
        /// </summary>
        /// <param name="a">
        /// It is a number a.
        /// </param>
        /// <param name="b">
        /// It is a number b.
        /// </param>
        /// <returns>
        /// It returns gcd.
        /// </returns>
        /// <exception cref="System.ArgumentException">
        /// Two numbers cannot be 0 at the same time.
        /// </exception>
        public static int GetGcd(int a, int b)
        {
            long first = a;
            long second = b;
            first = Math.Abs(first);
            second = Math.Abs(second);
            long gcd = 1;
            if (first == 0 || second == 0)
            {
                gcd = first + second;
            }

            if (first == 0 && second == 0)
            {
                throw new ArgumentException("cannot be 0 at the same time.");
            }

            while (first != 0 & second != 0)
            {
                if (first > second)
                {
                    first %= second;
                    if (first == 0)
                    {
                        gcd = second;
                        break;
                    }
                }
                else
                {
                    second %= first;
                    if (second == 0)
                    {
                        gcd = first;
                        break;
                    }
                }
            }

            if (gcd > int.MaxValue)
            {
                throw new ArgumentException("Too big return value ");
            }

            return (int)gcd;
        }
    }
}