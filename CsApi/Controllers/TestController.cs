using CsApi.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        //[Route("")]
        [HttpGet]
        public String TestClass(string? a = null, string? b = null)
        {
            if (a != null && b != null)
            {
                return "a =" + a + " b = " + b;
            }
            else if (a != null)
            {
                return "a = " + a;
            }
            else if (b != null)
            {
                return "b = " + b;
            }
            else
            {
                Account account = new Account();
                account.Aaccount = "55688";
                return JsonSerializer.Serialize(account);
                //return account.ToString();
            }
        }
        //[HttpGet]
        //[Route("{a}/{b}")]
        //public String TestClass1(string a, string b)
        //{
        //    return a+b;
        //}
    }
}
