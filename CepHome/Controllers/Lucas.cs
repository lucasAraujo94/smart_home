using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CepHome.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Lucas : ControllerBase
    {
        [HttpGet("sala")]
        public string Sala()
        {
            return "teste";
        }
    }
}
