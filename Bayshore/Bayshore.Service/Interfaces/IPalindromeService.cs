namespace Bayshore.Service.Interfaces
{
    public interface IPalindromeService
    {
        bool IsPallindrome<T>(T n) where T : struct;
    }
}
