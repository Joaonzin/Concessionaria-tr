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
        public void AdicionarCliente(Cliente cliente)
        {
            _service.Adicionar(cliente);
        }

        [HttpGet("listar-cliente")]
        public List<Cliente> ListarCliente()
        {
            return _service.Listar();
        }

        [HttpPut("editar-Cliente")]
        public void EditarCliente(Cliente cliente)
        {
            _service.Editar(cliente);
        }

        [HttpDelete("deletar-cliente")]
        public void DeletarCliente(int id)
        {
            _service.Remover(id);
        }
    }
}
