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
    public class VendaUC
    {
        private readonly HttpClient _client;
        public string ConnectionString = "Data Source=Concessionaria.db";

        public VendaUC(HttpClient cliente)
        {
            _client = cliente;
        }

        public List<Venda> ListarVeiculos()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Venda>().ToList();
        }

        public void Adicionar(Venda venda)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(venda);
        }

        public Venda BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Venda>(id);
        }
    }

}
