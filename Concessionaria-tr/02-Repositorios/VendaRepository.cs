using Concessionaria_tr.Entidades;
using Concessionaria_tr.Repositorios;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria_tr.Repositorios
{
    public class VendaRepository : IVendaRepository
    {
        private readonly string ConnectionString;

        public VendaRepository(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Venda venda)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(venda);
        }

        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Venda venda = BuscarPorId(id);
            connection.Delete(venda);
        }

        public void Editar(Venda venda)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Venda>(venda);
        }

        public List<VendaDTO> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<VendaDTO>().ToList();
        }

        public Venda BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Venda>(id);
        }
    }

}

