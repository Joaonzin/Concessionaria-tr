using Concessionaria_tr.Entidades;
using System.Data.SQLite;
using Dapper.Contrib.Extensions;

namespace Concessionaria_tr.Repositorios
{
    public class AgendamentoRepository : IAgendamentoRepository
    {
        private readonly string ConnectionString;
        public AgendamentoRepository( string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Adicionar(Agendamento agendamento)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(agendamento);
        }

        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Agendamento agendamento = BuscarPorId(id);
            connection.Delete(agendamento);
        }

        public void Editar(Agendamento agendamento)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Agendamento>(agendamento);
        }

        public List<AgendamentoDTO> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<AgendamentoDTO>().ToList();
        }

        public Agendamento BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Agendamento>(id);
        }
    }

}
