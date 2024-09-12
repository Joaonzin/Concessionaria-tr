using Concessionaria_tr._01_Entidades;
using Concessionaria_tr._01_Services;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace ConcessionariaApi.Controllers
{

     [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly VendaService _service;

        public VendaController(VendaService service)
        {
            _service = service;
        }

        [HttpPost("adicionar-venda")]
        public IActionResult Adicionar([FromBody] Venda venda)
        {
            _service.Adicionar(venda);
            return Ok();
        }
        
        [HttpPut("editar-venda")]
        public IActionResult Editar([FromBody] Venda venda)
        {
            _service.Editar(venda);
            return Ok();
        }
        
        [HttpGet("listar-venda")]
        public ActionResult<List<Venda>> Listar()
        {
            return _service.Listar();
        }

        [HttpDelete("remover-venda")]
        public IActionResult Remover(int id)
        {
            _service.Remover(id);
            return Ok();
        }

        

        

        [HttpGet("buscar-venda{id}")]
        public ActionResult<Venda> BuscarPorId(int id)
        {
            var venda = _service.BuscarPorId(id);
            if (venda == null)
            {
                return NotFound();
            }
            return venda;
        }
    }

}
