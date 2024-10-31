using Concessionaria_tr.Entidades;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;

namespace Concessionaria_tr.Repositorios
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly string ConnectionString;

        public FuncionarioRepository(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Funcionario funcionario)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(funcionario);
        }

        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Funcionario funcionario = BuscarPorId(id);
            connection.Delete(funcionario);
        }

        public void Editar(Funcionario funcionario)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Funcionario>(funcionario);
        }

        public List<Funcionario> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Funcionario>().ToList();
        }

        public Funcionario BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Funcionario>(id);
        }
    }

}
