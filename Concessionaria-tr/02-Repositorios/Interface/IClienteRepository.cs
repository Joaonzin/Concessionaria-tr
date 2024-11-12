using Concessionaria_tr.Entidades;

namespace Concessionaria_tr.Repositorios
{
    public interface IClienteRepository
    {
         void Adicionar(Cliente cliente);

         void Remover(int id);

         void Editar(Cliente cliente);

         List<Cliente> Listar();

         Cliente BuscarPorId(int id);
    }
}
