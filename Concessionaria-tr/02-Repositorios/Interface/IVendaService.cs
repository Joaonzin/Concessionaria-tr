using Concessionaria_tr.Entidades;

namespace Concessionaria_tr.Repositorios
{
    public interface IVendaService
    {
        void Adicionar(Venda venda);
        void Remover(int id);
        List<VendaDTO> Listar();
        Venda BuscarPorId(int id);
        void Editar(Venda editVenda);
    }
}
