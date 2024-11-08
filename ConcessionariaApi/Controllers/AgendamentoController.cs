using AutoMapper;
using Concessionaria_tr.Services;
using Concessionaria_tr.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgendamentoController : ControllerBase
    {
        private readonly IAgendamentoService _service;
        private readonly IMapper _mapper;

        public AgendamentoController(IAgendamentoService agendamentoService, IMapper mapper)
        {
            _service = agendamentoService;
            _mapper = mapper;
        }

        /// <summary>
        /// Endpoint para Adicionar um Agendamento
        /// </summary>
        /// <param name="agendamento"></param>
        [HttpPost("adicionar-Agendamento")]
        public IActionResult AdicionarAgendamento(Agendamento agendamento)
        {
            try
            {
                _service.Adicionar(agendamento);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao adicionar um agendamento, " +
                    $"o erro foi \n {erro.Message}");
                throw;
            }
            
        }

        [HttpGet("listar-Agendamento")]
        public List<AgendamentoDTO> ListarAgendamento()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception erro)
            {
                throw new Exception($"Ocorreu um erro ao listar um agendamento, " +
                    $"o erro foi \n {erro.Message}");
            }
            
        }

        [HttpPut("editar-Agendamento")]
        public IActionResult EditarAgendamento(Agendamento agendamento)
        {

            try
            {
                _service.Editar(agendamento);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao editar um agendamento, " +
                   $"o erro foi \n {erro.Message}");
                throw;
            }

            
        }

        [HttpDelete("deletar-Agendamento")]
        public IActionResult DeletarAgendamento(int id)
        {
            try
            {

                _service.Remover(id);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao deletar um agendamento, " +
                   $"o erro foi \n {erro.Message}");
                throw;
            }

        }
    }
}


