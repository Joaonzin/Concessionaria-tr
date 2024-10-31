using AutoMapper;
using Concessionaria_tr.Entidades;
using Concessionaria_tr.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly IVendaService _service;
        private readonly IMapper _mapper;

        public VendaController(IVendaService vendaService, IMapper mapper)
        {
            _service = vendaService;
            _mapper = mapper;
        }

        [HttpPost("adicionar-venda")]
        public void AdicionarVenda(Venda venda)
        {
            _service.Adicionar(venda);
        }

        [HttpGet("listar-venda")]
        public List<VendaDTO> ListarVenda()
        {
            return _service.Listar();
        }

        [HttpPut("editar-venda")]
        public void EditarVenda(Venda venda)
        {
            _service.Editar(venda);
        }

        [HttpDelete("deletar-venda")]
        public void DeletarVenda(int id)
        {
            _service.Remover(id);
        }
    }
}

