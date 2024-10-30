using FrontEnd.Models;
using System.Net.Http.Json;
using System.Data.SQLite;
using Dapper.Contrib.Extensions;

namespace FrontEnd.UseCases
{
    public class VeiculoUC
    {
        private readonly HttpClient _client;

        public string ConnectionString = "Data Source=Concessionaria.db";

        public VeiculoUC(HttpClient cliente)
        {
            _client = cliente;
        }

        public List<Veiculo> ListarVeiculos()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Veiculo>().ToList();
        }

        public void Adicionar(Veiculo veiculo)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(veiculo);
        }

        public Veiculo BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Veiculo>(id);
        }
    }

}
