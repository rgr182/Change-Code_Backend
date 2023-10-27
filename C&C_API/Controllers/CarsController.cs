using Microsoft.AspNetCore.Mvc;
using C_C_API.Utils;

namespace C_C_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {

        [HttpGet(Name = "GetCarr")]
        public string GetCarr()
        {
            LLantas ll = new LLantas();
            return ll.GetLLanta();
        }
    }
}

