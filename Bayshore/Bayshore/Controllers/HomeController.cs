using Bayshore.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Bayshore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public bool CheckPallindrome(long number, [FromServices] IPalindromeService palindromeService)
        {
            return palindromeService.IsPallindrome(number);
        }
    }
}
