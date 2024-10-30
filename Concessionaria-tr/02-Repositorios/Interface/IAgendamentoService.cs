using Concessionaria_tr.Entidades;

namespace Concessionaria_tr.Repositorios
{
    public interface IAgendamentoService
    {
        void Adicionar(Agendamento agendamento);
        void Remover(int id);
        List<AgendamentoDTO> Listar();
        Agendamento BuscarPorId(int id);
        void Editar(Agendamento editAgendamento);
    }


}
