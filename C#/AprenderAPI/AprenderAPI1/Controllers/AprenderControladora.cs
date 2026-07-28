using Microsoft.AspNetCore.Mvc;

namespace AprenderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AprenderControladora : ControllerBase
    {

        [HttpGet ]
        public string Rota()
        {


            return "Você acabou de rodar um API ?";
        }

        [HttpGet ("bosta") ]
        public string Bosta()
        {
            return "Que merda";
        }




    }
}
