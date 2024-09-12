using Concessionaria_tr._01_Entidades;
using Concessionaria_tr._02_Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria_tr._01_Services
{
    public class VendaService
    {
        private readonly VendaRepository _repository;

        public VendaService(string config)
        {
            _repository = new VendaRepository(config);
        }

        public void Adicionar(Venda venda)
        {
            _repository.Adicionar(venda);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public void Editar(Venda venda)
        {
            _repository.Editar(venda);
        }

        public List<Venda> Listar()
        {
            return _repository.Listar();
        }

        public Venda BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }
    }

}
