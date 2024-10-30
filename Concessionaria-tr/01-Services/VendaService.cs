using AutoMapper;
using Concessionaria_tr.Entidades;
using Concessionaria_tr.Repositorios;

namespace Concessionaria_tr.Services
{
    public class VendaService :IVendaService
    {
        public IVendaRepository Repository { get; set; }

        public VendaService(string _config)
        {
            Repository = new VendaRepository(_config);
        }

        public void Adicionar(Venda venda)
        {
            Repository.Adicionar(venda);
        }

        public void Remover(int id)
        {
            Repository.Remover(id);
        }

        public List<VendaDTO> Listar()
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
