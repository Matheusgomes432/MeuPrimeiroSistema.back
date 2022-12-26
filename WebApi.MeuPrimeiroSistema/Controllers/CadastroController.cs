using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.MeuPrimeiroSistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
    
        // POST api/<CadastroController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
