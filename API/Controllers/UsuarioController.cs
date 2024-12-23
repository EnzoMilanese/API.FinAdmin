using Domain.Payloads.Usuario;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace API.Controllers
{
    public class UsuarioController(IUsuarioService _service) : BaseController
    {
        [HttpPost()]
        [Route("[controller]")]
        public IActionResult Create([FromBody] CreateUsuarioPayload payload) => Execute(() => _service.Create(payload));

        [HttpGet()]
        [Route("[controller]")]
        public IActionResult Get() => Execute(_service.Get);

        [HttpGet()]
        [Route("[controller]/{id}")]
        public IActionResult Get(int id) => Execute(() => _service.Get(id));

        [HttpPut()]
        [Route("[controller]")]
        public IActionResult Update([FromBody] UpdateUsuarioPayload payload) => Execute(() => _service.Update(payload));

        [HttpDelete()]
        [Route("[controller]/{id}")]
        public IActionResult Remove(int id) => Execute(() => _service.Remove(id));
    }
}
