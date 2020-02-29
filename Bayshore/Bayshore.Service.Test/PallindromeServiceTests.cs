using Bayshore.Service.Interfaces;
using System;
using Xunit;

namespace Bayshore.Service.Test
{
    public class PallindromeServiceTests
    {
        private IPalindromeService Service = new PalindromeService();

        [Theory]
        [InlineData(-1), InlineData(int.MinValue)]
        public void IsPallindrome_WhenNegative_ThrowArgumentException(int n)
        {
            Assert.Throws<ArgumentException>(() => Service.IsPallindrome(n));
        }
    }
}
