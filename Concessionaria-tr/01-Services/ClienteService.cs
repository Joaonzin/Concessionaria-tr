using Concessionaria_tr.Repositorios;
using Concessionaria_tr.Entidades;

namespace Concessionaria_tr.Services
{
    public class ClienteService :IClienteService
    {
        private readonly IClienteRepository repository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            repository = clienteRepository;
        }

        public void Adicionar(Cliente cliente)
        {
            repository.Adicionar(cliente);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Cliente> Listar()
        {
            return repository.Listar();
        }

        public Cliente BuscarPorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(Cliente editCliente)
        {
            repository.Editar(editCliente);
        }
    }

}
