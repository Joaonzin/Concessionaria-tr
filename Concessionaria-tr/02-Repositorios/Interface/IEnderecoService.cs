using Concessionaria_tr.Entidades;

namespace Concessionaria_tr.Repositorios
{
    public interface IEnderecoService
    {
        void Adicionar(Endereco endereco);
        void Remover(int id);
        List<Endereco> Listar();
        List<Endereco> ListarEnderecoAluno(int ClienteId);
        Endereco BuscarTimePorId(int id);
        void Editar(Endereco editPessoa);

    }
}
