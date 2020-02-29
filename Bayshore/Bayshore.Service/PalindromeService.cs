using System;
using System.Linq;

namespace Bayshore.Service
{
    public class PalindromeService : Interfaces.IPalindromeService
    {
        public bool IsPallindrome<T>(T n) where T : struct
        {
            // the shortest way to make sure T is a number. Could also do a series of type checks
            if (double.TryParse(n.ToString(), out var num))
            {
                if (num < 0) throw new ArgumentException("Number must be positive");

                var str = n.ToString();

                if (str.Length == 1) return true;

                var (front, back) = GetHalves(str);

                return front.SequenceEqual(back);
            }

            throw new ArgumentException("Number must be castable to a long", nameof(n));
        }

        private (char[] front, char[] back) GetHalves(string str)
        {
            var halfIndex = str.Length / 2;
            var firstHalf = str.Substring(0, halfIndex).ToCharArray();

            if (str.Length % 2 != 0) halfIndex++;

            var secondHalf = str.Substring(halfIndex).ToCharArray();

            Array.Reverse(secondHalf);

            return (firstHalf, secondHalf);
        }
    }

}
