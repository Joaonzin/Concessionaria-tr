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
    public class AgendamentoUC
    {
        private readonly HttpClient _client;
        public string ConnectionString = "Data Source=Concessionaria.db";

        public AgendamentoUC(HttpClient cliente)
        {
            _client = cliente;
        }

        public List<Agendamento> ListarVeiculos()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Agendamento>().ToList();
        }

        public void Adicionar(Agendamento agendamento)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(agendamento);
        }

        public Agendamento BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Agendamento>(id);
        }
    }

}
