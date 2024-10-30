using Dapper.Contrib.Extensions;
using FrontEnd.Models;
using System.Data.SQLite;

namespace FrontEnd.UseCases
{
    public class FuncionarioUC
    {
        private readonly HttpClient _client;
        public string ConnectionString = "Data Source=Concessionaria.db";

        public FuncionarioUC(HttpClient cliente)
        {
            _client = cliente;
        }

        public List<Funcionario> ListarVeiculos()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Funcionario>().ToList();
        }

        public void Adicionar(Funcionario funcionario)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(funcionario);
        }

        public Funcionario BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Funcionario>(id);
        }
    }

}
