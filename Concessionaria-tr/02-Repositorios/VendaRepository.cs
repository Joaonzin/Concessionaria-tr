﻿using Concessionaria_tr._01_Entidades;
using Concessionaria_tr._03_Entidades.DTOs;
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
        private readonly string ConnectionString;

        public VendaRepository(string connectionString)
        {
            ConnectionString = connectionString;
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

