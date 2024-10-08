using AutoMapper;
using Concessionaria_tr._01_Entidades;
using Concessionaria_tr._02_Repositorios;
using Concessionaria_tr._03_Entidades.DTOs;

namespace Concessionaria_tr._01_Services
{
    public class VendaService
    {
        public VendaRepository Repository { get; set; }

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
