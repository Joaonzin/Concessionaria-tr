using AutoMapper;
using Concessionaria_tr.Entidades;
using Concessionaria_tr.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoService _service;
        private readonly IMapper _mapper;

        public VeiculoController(IVeiculoService veiculoService, IMapper mapper)
        {
            _service = veiculoService;
            _mapper = mapper;
        }

        [HttpPost("adicionar-veiculo")]
        public void AdicionarVeiculo(Veiculo veiculo)
        {
            _service.Adicionar(veiculo);
        }

        [HttpGet("listar-veiculo")]
        public List<Veiculo> ListarVeiculo()
        {
            return _service.Listar();
        }

        [HttpPut("editar-veiculo")]
        public void EditarVeiculo(Veiculo veiculo)
        {
            _service.Editar(veiculo);
        }

        [HttpDelete("deletar-veiculo")]
        public void DeletarVeiculo(int id)
        {
            _service.Remover(id);
        }
    }
}






