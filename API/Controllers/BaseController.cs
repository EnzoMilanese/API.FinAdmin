using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BaseController : Controller
    {

        public IActionResult Execute(Func<object> func)
        {
            try
            {
                return Ok(new Response(func()));
            }
            catch (Exception ex)
            {
                return BadRequest(new Response(ex));
            }
        }
    }
}
