using Concessionaria_tr.Entidades;

namespace Concessionaria_tr.Repositorios
{
    public interface IVendaRepository
    {

        void Adicionar(Venda venda);
        void Remover(int id);
        void Editar(Venda venda);
        List<Venda> Listar();
        Venda BuscarPorId(int id);

    }
}
