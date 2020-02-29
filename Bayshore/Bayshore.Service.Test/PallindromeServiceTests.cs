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

        [Fact]
        public void IsPallindrome_WhenNotANumber_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Service.IsPallindrome(true));
        }

        [Fact]
        public void IsPallindrome_WhenNumber_ReturnsValue()
        {
            var result =  Service.IsPallindrome(1);

            Assert.IsType<bool>(result);
        }
    }
}
