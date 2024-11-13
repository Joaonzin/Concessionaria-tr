using Concessionaria_tr.Repositorios;
using Concessionaria_tr.Entidades;

namespace Concessionaria_tr.Services
{
    public class EnderecoService :IEnderecoService
    {
        private readonly IEnderecoRepository repository;
        public EnderecoService(IEnderecoRepository enderecoRepository)
        {
            repository = enderecoRepository;
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
        public List<Endereco> ListarEnderecoCliente(int ClienteId)
        {
            return repository.ListarEnderecoCliente(ClienteId);
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
