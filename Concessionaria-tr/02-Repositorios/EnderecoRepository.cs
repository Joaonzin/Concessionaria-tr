using Concessionaria_tr._03_Entidades;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data.SQLite;

namespace Concessionaria_tr._02_Repositorios
{
    public class EnderecoRepository
    {
        private readonly string ConnectionString;
        public EnderecoRepository(string connectioString)
        {
            ConnectionString = connectioString;
        }
        public void Adicionar(Endereco endereco)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Endereco>(endereco);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Endereco endereco = BuscarPorId(id);
            connection.Delete<Endereco>(endereco);
        }
        public void Editar(Endereco endereco)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Endereco>(endereco);
        }
        public List<Endereco> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Endereco>().ToList();
        }
        public List<Endereco> ListarEnderecoAluno(int ClienteId)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            List<Endereco> list = connection.Query<Endereco>($"SELECT Id, Rua, Bairro, Numero, ClienteId FROM Enderecos WHERE ClienteId = {ClienteId}").ToList();
            return list;
        }
        public Endereco BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Endereco>(id);
        }
    }
}
