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
    public class EstoqueRepository
    {
        private readonly string ConnectionString;

        public EstoqueRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Adicionar(Estoque estoque)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(estoque);
        }

        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Estoque estoque = BuscarPorId(id);
            connection.Delete(estoque);
        }

        public void Editar(Estoque estoque)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Estoque>(estoque);
        }

        public List<Estoque> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Estoque>().ToList();
        }

        public Estoque BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Estoque>(id);
        }
    }

}
