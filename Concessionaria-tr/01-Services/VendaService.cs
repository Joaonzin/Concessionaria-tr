
using Concessionaria_tr.Entidades;
using Concessionaria_tr.Repositorios;

namespace Concessionaria_tr.Services
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _repository;

        public VendaService(IVendaRepository vendaRepository)
        {
            _repository = vendaRepository;
        }

        
        public void Adicionar(Venda venda)
        {
            _repository.Adicionar(venda);
        }

        
        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        
        public List<Venda> Listar()
        {
            return _repository.Listar();  
        }

        
        public Venda BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);  
        }

        
        public void Editar(Venda venda)
        {
            _repository.Editar(venda);
        }
    }
}

