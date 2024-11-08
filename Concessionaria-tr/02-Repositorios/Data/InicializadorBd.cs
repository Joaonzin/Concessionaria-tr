using System.Data.SQLite;

namespace Concessionaria_tr.Repositorios
{
    public static class InicializadorBd
    {
        private const string ConnectionString = "Data Source=Concessionaria.db";\
        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            { dddzddx
                connection.Open();f
                string commandoSQL = @"cf
                CREATE TABLE IF NOT EXISTS Clientes(cf
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,c cgb
                    Nome TEXT NOT NULL,c gc g                    Cpf TEXT NOT cvbULL,
                    Telefone TEXT NOT NULL
                );";bvbcvb

                commandoSQL += @"
                CREATE TABLE IF NOT EXISTS Veiculos(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Marca TEXT NOT NULL,
                    Modelo TEXT NOT NULL,
                    Ano INTEGER NOT NULL,
                    Preco REAL NOT NULL
                );";

                commandoSQL += @"
                CREATE TABLE IF NOT EXISTS Vendas(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    VeiculoId INTEGER NOT NULL,
                    ClienteId INTEGER NOT NULL,
                    VendedorId INTEGER NOT NULL,
                    DataVenda TEXT NOT NULL,
                    ValorFinal REAL NOT NULL,
                    FOREIGN KEY (VeiculoId) REFERENCES Veiculos(Id),
                    FOREIGN KEY (ClienteId) REFERENCES Clientes(Id),
                    FOREIGN KEY (VendedorId) REFERENCES Vendedores(Id)
                );";

                commandoSQL += @"
                CREATE TABLE IF NOT EXISTS Agendamentos(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ClienteId INTEGER NOT NULL,
                    VeiculoId INTEGER NOT NULL,
                    DataHora TEXT NOT NULL,
                    Motivo TEXT NOT NULL,
                    FOREIGN KEY (ClienteId) REFERENCES Clientes(Id),
                    FOREIGN KEY (VeiculoId) REFERENCES Veiculos(Id)
                );";

                commandoSQL += @"
                CREATE TABLE IF NOT EXISTS Estoque(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    VeiculoId INTEGER NOT NULL,
                    Quantidade INTEGER NOT NULL,
                    FOREIGN KEY (VeiculoId) REFERENCES Veiculos(Id)
                );";

                commandoSQL += @"
                CREATE TABLE IF NOT EXISTS Oficinas(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Endereco TEXT NOT NULL
                );";

                commandoSQL += @"
                CREATE TABLE IF NOT EXISTS Servicos(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Descricao TEXT NOT NULL,
                    Preco REAL NOT NULL
                );";

                commandoSQL += @"
                CREATE TABLE IF NOT EXISTS Funcionarios(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Cargo TEXT NOT NULL,
                    Salario REAL NOT NULL
                );";

                commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Enderecos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Rua  TEXT NOT NULL,
                 Bairro   TEXT NOT NULL,
                 Numero  INTEGER NOT NULL,
                 ClienteID  INTEGER NOT NULL
                 );";



                using (var command = new SQLiteCommand(commandoSQL, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

