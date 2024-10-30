using Concessionaria_tr.Entidades;

namespace Concessionaria_tr.Repositorios
{
    public interface IEnderecoRepository
    {
        void Adicionar(Endereco endereco);
        void Remover(int id);
        void Editar(Endereco endereco);
        List<Endereco> Listar();
        List<Endereco> ListarEnderecoAluno(int ClienteId);
        Endereco BuscarPorId(int id);

    }
}
