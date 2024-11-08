using AutoMapper;
using Concessionaria_tr.Entidades;
using Concessionaria_tr.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _service;
        private readonly IMapper _mapper;

        public ClienteController(IClienteService clienteService, IMapper mapper)
        {
            _service = clienteService;
            _mapper = mapper;
        }

        [HttpPost("adicionar-cliente")]
        public IActionResult AdicionarCliente(Cliente cliente)
        {
            try
            {
                _service.Adicionar(cliente);
                return Ok();

            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao adicionar um Cliente, " +
                   $"o erro foi \n {erro.Message}");
                throw;
            }
            
        }

        [HttpGet("listar-cliente")]
        public List<Cliente> ListarCliente()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception erro)
            {
                throw new Exception($"Ocorreu um erro ao listar um Cliente, " +
                                    $"o erro foi \n {erro.Message}");
            }
            
        }

        [HttpPut("editar-Cliente")]
        public IActionResult EditarCliente(Cliente cliente)
        {
            try
            {
                _service.Editar(cliente);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao editar um Cliente, " +
                                   $"o erro foi \n {erro.Message}");
                throw;
            }
            
        }

        [HttpDelete("deletar-cliente")]
        public IActionResult DeletarCliente(int id)
        {
            try
            {
                _service.Remover(id);
                return Ok();
            } 
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao deletar um Cliente, " +
                                   $"o erro foi \n {erro.Message}");
                throw;

            }
            
        }
    }
}
