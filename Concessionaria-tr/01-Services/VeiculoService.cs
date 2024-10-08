using Concessionaria_tr._01_Entidades;
using Concessionaria_tr._02_Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria_tr._03_Aplicacao
{
    public class VeiculoService
    {
        public VeiculoRepository repository { get; set; }

        public VeiculoService(string _config)
        {
            repository = new VeiculoRepository(_config);
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
