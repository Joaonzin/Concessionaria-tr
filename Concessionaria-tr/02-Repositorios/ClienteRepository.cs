using Concessionaria_tr._03_Entidades;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria_tr._02_Repositorios
{
    public class ClienteRepository
    {
        private readonly string ConnectionString;

        public ClienteRepository(string connectionString)
        {
            ConnectionString = connectionString;
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

