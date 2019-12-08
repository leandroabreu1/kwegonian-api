using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KwegonianApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KwegoController : ControllerBase
    {
        Kwego kwego = new Kwego();
        
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Por favor passe como parâmetro um valor em kwegonian" ;
        }

        // GET kwego/value
        [HttpGet("{value}")]
        public ActionResult<string> Get(string value)
        {
            return kwego.KwegonianToDecimal(value);
        }

        //POST kwego/value
        [HttpPost]
        public ActionResult<string> Post([FromBody] Kwego value)
        {
            return kwego.KwegonianToDecimal(value.Input);
        }      

        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
