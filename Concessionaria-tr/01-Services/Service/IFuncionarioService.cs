using Concessionaria_tr.Entidades;

namespace Concessionaria_tr.Services
{
    public interface IFuncionarioService
    {

        void Adicionar(Funcionario funcionario);
        void Remover(int id);
        List<Funcionario> Listar();
        Funcionario BuscarPorId(int id);
        void Editar(Funcionario editFuncionario);

    }
}
