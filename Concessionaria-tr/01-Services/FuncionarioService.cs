using Concessionaria_tr.Repositorios;
using Concessionaria_tr.Entidades;

namespace Concessionaria_tr.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository repository;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository)
        {
            repository = funcionarioRepository;
        }

        public void Adicionar(Funcionario funcionario)
        {
            repository.Adicionar(funcionario);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Funcionario> Listar()
        {
            return repository.Listar();
        }

        public Funcionario BuscarPorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(Funcionario editFuncionario)
        {
            repository.Editar(editFuncionario);
        }
    }

}
