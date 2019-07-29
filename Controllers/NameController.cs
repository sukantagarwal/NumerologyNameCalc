using Microsoft.AspNetCore.Mvc;
using NumerologyNameCalc.Services;


namespace NumerologyNameCalc.Controllers
{
    [Route("numerology/name")]
    [ApiController]
    public class NameController:ControllerBase
    {
        [HttpGet]
        public string pingNameService()
        {
            return "ping service available";
        }

        [HttpGet("{name}")]
        public int GetNumberForName(string name)
        {
            var service = new NameService();
            return service.CalulateNumerologyForName(name);
        }

    }
}
