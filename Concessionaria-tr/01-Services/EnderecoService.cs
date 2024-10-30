using Concessionaria_tr.Repositorios;
using Concessionaria_tr.Entidades;

namespace Concessionaria_tr.Services
{
    public class EnderecoService :IEnderecoService
    {
        public IEnderecoRepository repository { get; set; }
        public EnderecoService(string _config)
        {
            repository = new EnderecoRepository(_config);
        }
        public void Adicionar(Endereco endereco)
        {
            repository.Adicionar(endereco);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Endereco> Listar()
        {
            return repository.Listar();
        }
        public List<Endereco> ListarEnderecoAluno(int ClienteId)
        {
            return repository.ListarEnderecoAluno(ClienteId);
        }
        public Endereco BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }
        public void Editar(Endereco editPessoa)
        {
            repository.Editar(editPessoa);
        }
    }
}
