using AutoMapper;
using Concessionaria_tr._01_Entidades;
using Concessionaria_tr._01_Services;
using Concessionaria_tr._03_Aplicacao;
using Concessionaria_tr._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaApi.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class EstoqueController : ControllerBase
    {
        private readonly EstoqueService _service;
        private readonly IMapper _mapper;

        public EstoqueController(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = new EstoqueService(_config);
            _mapper = mapper;
        }

        [HttpPost("adicionar-Estoque")]
        public void AdicionarEstoque(Estoque estoque)
        {
            _service.Adicionar(estoque);
        }

        [HttpGet("listar-Estoque")]
        public List<Estoque> ListarEstoque()
        {
            return _service.Listar();
        }

        [HttpPut("editar-Estoque")]
        public void EditarEstoque(Estoque estoque)
        {
            _service.Editar(estoque);
        }

        [HttpDelete("deletar-Estoque")]
        public void DeletarEstoque(int id)
        {
            _service.Remover(id);
        }
    }
}








