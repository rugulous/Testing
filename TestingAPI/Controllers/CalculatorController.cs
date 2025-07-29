using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("add")]
        public string Add(string a, string b)
        {
            return a + b;
        }

        [HttpGet("subtract")]
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        [HttpGet("multiply")]
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        [HttpGet("divide")]
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
