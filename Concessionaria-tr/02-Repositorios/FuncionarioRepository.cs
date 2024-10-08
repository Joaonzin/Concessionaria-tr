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
    public class FuncionarioRepository
    {
        private readonly string ConnectionString;

        public FuncionarioRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Adicionar(Funcionario funcionario)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(funcionario);
        }

        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Funcionario funcionario = BuscarPorId(id);
            connection.Delete(funcionario);
        }

        public void Editar(Funcionario funcionario)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Funcionario>(funcionario);
        }

        public List<Funcionario> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Funcionario>().ToList();
        }

        public Funcionario BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Funcionario>(id);
        }
    }

}
