using Concessionaria_tr.Repositorios;
using Concessionaria_tr.Entidades;
using Dapper.Contrib.Extensions;
using System.Data.SQLite;
using Microsoft.Extensions.Configuration;

namespace Concessionaria_tr.Repositorios
{
    public class ClienteRepository :IClienteRepository
    {
        private readonly string ConnectionString;

        public ClienteRepository(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Cliente cliente)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(cliente);
        }

        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Cliente cliente = BuscarPorId(id);
            connection.Delete(cliente);
        }

        public void Editar(Cliente cliente)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Cliente>(cliente);
        }

        public List<Cliente> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Cliente>().ToList();
        }

        public Cliente BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Cliente>(id);
        }
    }
    
}

