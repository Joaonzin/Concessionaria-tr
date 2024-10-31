using Concessionaria_tr.Entidades;
using Concessionaria_tr.Repositorios;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Configuration.Internal;
using System.Data.SQLite;

namespace Concessionaria_tr.Repositorios
{


    public class VeiculoRepository :IVeiculoRepository
    {
        private readonly string ConnectionString;

        public VeiculoRepository(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Veiculo veiculo)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(veiculo);
        }

        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Veiculo veiculo = BuscarPorId(id);
            connection.Delete(veiculo);
        }

        public void Editar(Veiculo veiculo)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Veiculo>(veiculo);
        }

        public List<Veiculo> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Veiculo>().ToList();
        }

        public Veiculo BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Veiculo>(id);
        }
    }

}









