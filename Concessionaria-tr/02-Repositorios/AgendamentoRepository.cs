using Concessionaria_tr._03_Entidades.DTOs;
using Concessionaria_tr._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using AutoMapper;

namespace Concessionaria_tr._02_Repositorios
{
    public class AgendamentoRepository
    {
        private readonly string ConnectionString;
        public AgendamentoRepository( string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Adicionar(Agendamento agendamento)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(agendamento);
        }

        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Agendamento agendamento = BuscarPorId(id);
            connection.Delete(agendamento);
        }

        public void Editar(Agendamento agendamento)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Agendamento>(agendamento);
        }

        public List<AgendamentoDTO> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<AgendamentoDTO>().ToList();
        }

        public Agendamento BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Agendamento>(id);
        }
    }

}
