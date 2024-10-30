using AutoMapper;
using Concessionaria_tr._01_Entidades;
using Concessionaria_tr._01_Services;
using Concessionaria_tr._02_Repositorios.Interface;
using Concessionaria_tr._03_Aplicacao;
using Concessionaria_tr._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _service;
        private readonly IMapper _mapper;

        public ClienteController(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = new ClienteService(_config);
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
