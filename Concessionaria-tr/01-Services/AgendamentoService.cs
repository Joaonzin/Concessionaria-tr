using AutoMapper;
using Concessionaria_tr._03_Entidades.DTOs;
using Concessionaria_tr._03_Entidades;
using Concessionaria_tr._02_Repositorios;

namespace Concessionaria_tr._01_Services
{
    public class AgendamentoService
    {
        public AgendamentoRepository repository { get; set; }

        public AgendamentoService(string _config)
        {
            repository = new AgendamentoRepository( _config);
        }

        public void Adicionar(Agendamento agendamento)
        {
            repository.Adicionar(agendamento);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<AgendamentoDTO> Listar()
        {
            return repository.Listar();
        }

        public Agendamento BuscarPorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(Agendamento editAgendamento)
        {
            repository.Editar(editAgendamento);
        }
    }

}
