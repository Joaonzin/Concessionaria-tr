using Concessionaria_tr.Entidades;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;

namespace Concessionaria_tr.Repositorios
{
    public class VendaRepository : IVendaRepository
    {
        private readonly string ConnectionString;

        public VendaRepository(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Venda venda)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(venda);
        }

        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Venda venda = BuscarPorId(id);
            connection.Delete(venda);
        }

        public void Editar(Venda venda)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Venda>(venda);
        }

        public List<Venda> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Venda>().ToList();
        }

        public Venda BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Venda>(id);
        }
    }

}

