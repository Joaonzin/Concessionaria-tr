
using Concessionaria_tr.Entidades;
using Concessionaria_tr.Repositorios;

namespace Concessionaria_tr.Services
{
    public class VendaService :IVendaService
    {
        private readonly IVendaRepository Repository;

        public VendaService(IVendaRepository vendaRepository)
        {
            Repository = vendaRepository;
        }

        public void Adicionar(Venda venda)
        {
            Repository.Adicionar(venda);
        }

        public void Remover(int id)s
        {
            Repository.Remover(id);
        }

        public List<Venda> Listar()
        {
            return Repository.Listar();
        }

        public Venda BuscarPorId(int id)
        {
            return Repository.BuscarPorId(id);
        }

        public void Editar(Venda editVenda)
        {
            Repository.Editar(editVenda);
        }
    }
}
