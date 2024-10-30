using Dapper.Contrib.Extensions;
using FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.UseCases
{
    public class ClienteUC
    {
        private readonly HttpClient _client;
        public string ConnectionString = "Data Source=Concessionaria.db";

        public ClienteUC(HttpClient cliente)
        {
            _client = cliente;
        }

        public List<Cliente> ListarVeiculos()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Cliente>().ToList();
        }

        public void Adicionar(Cliente cliente)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(cliente);
        }

        public Cliente BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Cliente>(id);
        }
    }

}
