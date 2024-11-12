using Concessionaria_tr.Entidades;

namespace Concessionaria_tr.Repositorios
{
    public interface IVeiculoRepository
    {
         void Adicionar(Veiculo veiculo);
        void Remover(int id);
        void Editar(Veiculo veiculo);
         List<Veiculo> Listar();
         Veiculo BuscarPorId(int id);

    }
}
