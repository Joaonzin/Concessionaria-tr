using Concessionaria_tr._01_Entidades;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria_tr._02_Repositorios
{
    public class VendaRepository
    {
        private readonly string _connectionString;

        public VendaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Adicionar(Venda venda)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Insert<Venda>(venda);
        }

        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            Venda venda = BuscarPorId(id);
            connection.Delete<Venda>(venda);
        }

        public void Editar(Venda venda)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Update<Venda>(venda);
        }

        public List<Venda> Listar()
        {
            using var connection = new SQLiteConnection(_connectionString);
            return connection.GetAll<Venda>().ToList();
        }

        public Venda BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            return connection.Get<Venda>(id);
        }
    }
}

