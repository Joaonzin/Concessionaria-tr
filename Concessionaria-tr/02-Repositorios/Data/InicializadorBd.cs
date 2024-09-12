using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria_tr._02_Repositorios.Data
{
    public static class InicializadorBd
    {

        public static void Inicializar()
        {
            using var connection = new SQLiteConnection("Data Source=Concessionaria.db");
            connection.Open();

           
            string criarTabelaVeiculos = @"
            CREATE TABLE IF NOT EXISTS Veiculos (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Marca TEXT NOT NULL,
                Modelo TEXT NOT NULL,
                Ano INTEGER NOT NULL,
                Preco REAL NOT NULL,
                Placa TEXT NOT NULL,
                Disponivel INTEGER NOT NULL
            );";

           
            string criarTabelaVenda = @"
            CREATE TABLE IF NOT EXISTS Venda (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                VeiculoId INTEGER NOT NULL,
                Cliente TEXT NOT NULL,
                Vendedor TEXT NOT NULL,
                DataVenda TEXT NOT NULL, 
                ValorVenda REAL NOT NULL,
                FOREIGN KEY (VeiculoId) REFERENCES Veiculos(Id)
            );";

            using var command = new SQLiteCommand(criarTabelaVeiculos, connection);
            command.ExecuteNonQuery();

            command.CommandText = criarTabelaVenda;
            command.ExecuteNonQuery();
        }
    }


}
    
