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


    public class VeiculoRepository
    {
        private readonly string _connectionString;

        public VeiculoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Adicionar(Veiculo veiculo)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Insert<Veiculo>(veiculo);
        }

        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            Veiculo veiculo = BuscarPorId(id);
            connection.Delete<Veiculo>(veiculo);
        }

        public void Editar(Veiculo veiculo)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Update<Veiculo>(veiculo);
        }

        public List<Veiculo> Listar()
        {
            using var connection = new SQLiteConnection(_connectionString);
            return connection.GetAll<Veiculo>().ToList();
        }

        public Veiculo BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            return connection.Get<Veiculo>(id);
        }
    }
}









