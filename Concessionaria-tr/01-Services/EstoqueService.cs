using Concessionaria_tr._02_Repositorios;
using Concessionaria_tr._03_Entidades;

namespace Concessionaria_tr._01_Services
{
    public class EstoqueService
    {
        public EstoqueRepository repository { get; set; }

        public EstoqueService(string _config)
        {
            repository = new EstoqueRepository(_config);
        }

        public void Adicionar(Estoque estoque)
        {
            repository.Adicionar(estoque);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Estoque> Listar()
        {
            return repository.Listar();
        }

        public Estoque BuscarPorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(Estoque editEstoque)
        {
            repository.Editar(editEstoque);
        }
    }

}
