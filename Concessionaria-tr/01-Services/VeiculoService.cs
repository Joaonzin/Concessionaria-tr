using Concessionaria_tr.Entidades;
using Concessionaria_tr.Repositorios;

namespace Concessionaria_tr.Services
{
    public class VeiculoService :IVeiculoService
    {
        private readonly IVeiculoRepository repository;

        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
            repository = veiculoRepository;
        }

        public void Adicionar(Veiculo veiculo)
        {
            repository.Adicionar(veiculo);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Veiculo> Listar()
        {
            return repository.Listar();
        }

        public Veiculo BuscarPorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(Veiculo editVeiculo)
        {
            repository.Editar(editVeiculo);
        }
    }
}
