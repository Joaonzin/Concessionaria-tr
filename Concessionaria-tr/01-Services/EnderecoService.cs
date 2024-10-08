using Concessionaria_tr._02_Repositorios;
using Concessionaria_tr._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria_tr._01_Services
{
    public class EnderecoService
    {
        public EnderecoRepository repository { get; set; }
        public EnderecoService(string _config)
        {
            repository = new EnderecoRepository(_config);
        }
        public void Adicionar(Endereco endereco)
        {
            repository.Adicionar(endereco);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Endereco> Listar()
        {
            return repository.Listar();
        }
        public List<Endereco> ListarEnderecoAluno(int ClienteId)
        {
            return repository.ListarEnderecoAluno(ClienteId);
        }
        public Endereco BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }
        public void Editar(Endereco editPessoa)
        {
            repository.Editar(editPessoa);
        }
    }
}
