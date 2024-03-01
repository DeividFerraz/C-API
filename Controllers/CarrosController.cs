using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EstudoAPI01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrosController : ControllerBase
    {
        // GET: api/<CarrosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Carro", "Carro1" };
        }

        // GET api/<CarrosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CarrosController>
        [HttpPost]
        public void Post([FromBody] Carro objParam)
        {
            var recuperar = objParam;
        }

        public class Carro
        {
            public string Marca { get; set; }
            public string Montadora {  get; set; }
            public string Ano {  get; set; }
        }

        // PUT api/<CarrosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CarrosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
