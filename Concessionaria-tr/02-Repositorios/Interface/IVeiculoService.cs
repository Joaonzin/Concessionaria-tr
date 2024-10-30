using Concessionaria_tr.Entidades;

namespace Concessionaria_tr.Repositorios
{
    public interface IVeiculoService
    {
        void Adicionar(Veiculo veiculo);
        void Remover(int id);
        List<Veiculo> Listar();
        Veiculo BuscarPorId(int id);
        void Editar(Veiculo editVeiculo);


    }
}
