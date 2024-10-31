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

        [HttpPost("adicionar-Agendamento")]
        public void AdicionarAgendamento(Agendamento agendamento)
        {
            _service.Adicionar(agendamento);
        }

        [HttpGet("listar-Agendamento")]
        public List<AgendamentoDTO> ListarAgendamento()
        {
            return _service.Listar();
        }

        [HttpPut("editar-Agendamento")]
        public void EditarAgendamento(Agendamento agendamento)
        {
            _service.Editar(agendamento);
        }

        [HttpDelete("deletar-Agendamento")]
        public void DeletarAgendamento(int id)
        {
            _service.Remover(id);
        }
    }
}


