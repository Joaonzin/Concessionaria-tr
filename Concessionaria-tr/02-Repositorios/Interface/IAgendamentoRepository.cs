using Concessionaria_tr.Entidades;

namespace Concessionaria_tr.Repositorios
{
    public interface IAgendamentoRepository
    {
        void Adicionar(Agendamento agendamento);
        void Remover(int id);
        void Editar(Agendamento agendamento);
        List<AgendamentoDTO> Listar();
        Agendamento BuscarPorId(int id);


    }
}
