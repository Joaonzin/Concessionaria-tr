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
        private readonly string ConnectionString;

        public VeiculoRepository(string connectionString)
        {
            ConnectionString = connectionString;
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









