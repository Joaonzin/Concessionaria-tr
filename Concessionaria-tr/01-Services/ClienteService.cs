using Concessionaria_tr.Repositorios;
using Concessionaria_tr.Entidades;

namespace Concessionaria_tr.Services
{
    public class ClienteService :IClienteService
    {
        public IClienteRepository repository { get; set; }

        public ClienteService(string _config)
        {
            repository = new ClienteRepository(_config);
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
