using AutoMapper;
using Concessionaria_tr._01_Entidades;
using Concessionaria_tr._02_Repositorios;
using Concessionaria_tr._03_Aplicacao;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculoController : ControllerBase
    {
        private readonly VeiculoService _service;
        private readonly IMapper _mapper;

        public VeiculoController(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = new VeiculoService(_config);
            _mapper = mapper;
        }

        [HttpPost("adicionar-veiculo")]
        public IActionResult AdicionarVeiculo(Veiculo veiculo)
        {
            _service.Adicionar(veiculo);
            return Ok(); 
        }

        [HttpPut("editar-pessoa")]
        public void EditarPessoa(Veiculo v)
        {
            _service.Editar(v);
        }

        [HttpGet("listar-veiculos")]
        public IActionResult ListarVeiculos()
        {
            var veiculos = _service.Listar();
            return Ok(veiculos); 
        }


        [HttpDelete("remover-veiculo")]
        public IActionResult RemoverVeiculo(int id)
        {
            _service.Remover(id);
            return Ok(); 
        }
    }

}





