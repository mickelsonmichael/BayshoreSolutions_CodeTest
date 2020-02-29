using Bayshore.Service.Interfaces;
using System;
using Xunit;

namespace Bayshore.Service.Test
{
    public class PallindromeServiceTests
    {
        private readonly IPalindromeService Service = new PalindromeService();

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

        [Theory]
        [InlineData(121), InlineData(1221), InlineData(1234321), InlineData(123321), InlineData(1)]
        public void IsPallindrome_WhenIsPallindrome_ReturnsTrue(int n)
        {
            Assert.True(Service.IsPallindrome(n));
        }

        [Theory]
        [InlineData(123), InlineData(1232), InlineData(123456)]
        public void IsPallindrome_WhenIsNotPallindrome_ReturnsFalse(int n)
        {
            Assert.False(Service.IsPallindrome(n));
        }
    }
}
