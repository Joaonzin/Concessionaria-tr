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

        /// <summary>
        /// Endpoint para Adicionado um Venda
        /// </summary>
        /// <param name="venda"></param>
        /// 
        [HttpPost("adicionar-venda")]
        public IActionResult AdicionarVenda(Venda venda)
        {
            try
            {
                _service.Adicionar(venda);
                return Ok();

            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao adicionar um venda, " +
                   $"o erro foi \n {erro.Message}");
                throw;
            }

        }

        /// <summary>
        /// Endpoint para Listando um Venda
        /// </summary>
        /// <param name="venda"></param>

        [HttpGet("listar-venda")]
        public List<Venda> ListarVenda()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception erro)
            {
                throw new Exception($"Ocorreu um erro ao listar as vendas: {erro.Message}");
            }
        }
        /// <summary>
        /// Endpoint para Editando um Venda
        /// </summary>
        /// <param name="venda"></param>

        [HttpPut("editar-venda")]
        public IActionResult EditarVenda(Venda venda)
        {
            try
            {
                _service.Editar(venda);
                return Ok();

            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao editar um venda, " +
                   $"o erro foi \n {erro.Message}");
                throw;
            }

        }

        /// <summary>
        /// Endpoint para Deletando um Venda
        /// </summary>
        /// <param name="venda"></param>

        [HttpDelete("deletar-venda")]
        public IActionResult DeletarVenda(int id)
        {
            try
            {
                _service.Remover(id);
                return Ok();

            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao deletar uma venda, " +
                   $"o erro foi \n {erro.Message}");
                throw;
            }

        }
    }
}