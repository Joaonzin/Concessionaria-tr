using Concessionaria_tr.Entidades;

namespace Concessionaria_tr.Repositorios
{
    public interface IClienteService
    {

        void Adicionar(Cliente cliente);
        void Remover(int id);
        List<Cliente> Listar();
        Cliente BuscarPorId(int id);
        void Editar(Cliente editCliente);
    }
}
