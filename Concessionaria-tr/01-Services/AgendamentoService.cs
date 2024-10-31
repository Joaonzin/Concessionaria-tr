using Concessionaria_tr.Entidades;
using Concessionaria_tr.Repositorios;

namespace Concessionaria_tr.Services
{
    public class AgendamentoService : IAgendamentoService
    {
        private readonly IAgendamentoRepository repository;

        public AgendamentoService(IAgendamentoRepository agendamentoRepository)
        {
            repository = agendamentoRepository;
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
