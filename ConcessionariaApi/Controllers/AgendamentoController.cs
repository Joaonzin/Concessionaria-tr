using AutoMapper;
using Concessionaria_tr._01_Services;
using Concessionaria_tr._03_Entidades;
using Concessionaria_tr._03_Entidades.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgendamentoController : ControllerBase
    {
        private readonly AgendamentoService _service;
        private readonly IMapper _mapper;

        public AgendamentoController(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = new AgendamentoService(_config);
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


