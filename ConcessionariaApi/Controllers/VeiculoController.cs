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

        /// <summary>
        /// Endpoint para Adicionado um Veiculo
        /// </summary>
        /// <param name="veiculo"></param>
        [HttpPost("adicionar-veiculo")]
        public IActionResult AdicionarVeiculo(Veiculo veiculo)
        {
            try
            {
                _service.Adicionar(veiculo);
                return Ok();

            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao adicionar um Veiculo, " +
                   $"o erro foi \n {erro.Message}");
                throw;
            }

        }
        /// <summary>
        /// Endpoint para Listando um Veiculo
        /// </summary>
        /// <param name="veiculo"></param>

        [HttpGet("listar-veiculo")]
        public List<Veiculo> ListarVeiculo()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception erro)
            {
                throw new Exception($"Ocorreu um erro ao listar um veiculo, " +
                                    $"o erro foi \n {erro.Message}");
            }

        }
        /// <summary>
        /// Endpoint para Editando um Veiculo
        /// </summary>
        /// <param name="veiculo"></param>

        [HttpPut("editar-veiculo")]
        public IActionResult EditarVeiculo(Veiculo veiculo)
        {
            try
            {
                _service.Editar(veiculo);
                return Ok();

            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao editar um Veiculo, " +
                   $"o erro foi \n {erro.Message}");
                throw;
            }

        }
        /// <summary>
        /// Endpoint para Deletando um Veiculo
        /// </summary>
        /// <param name="veiculo"></param>

        [HttpDelete("deletar-veiculo")]
        public IActionResult DeletarVeiculo(int id)
        {
            try
            {
                _service.Remover(id);
                return Ok();

            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao deletar um Veiculo, " +
                   $"o erro foi \n {erro.Message}");
                throw;
            }

        }
    }
}