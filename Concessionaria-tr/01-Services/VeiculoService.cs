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
        private readonly VeiculoRepository _repository;

        public VeiculoService(string config)
        {
            _repository = new VeiculoRepository(config);
        }

        public void Adicionar(Veiculo veiculo)
        {
            _repository.Adicionar(veiculo);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public void Editar(Veiculo veiculo)
        {
            _repository.Editar(veiculo);
        }

        public List<Veiculo> Listar()
        {
            return _repository.Listar();
        }

        public Veiculo BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }
    }


}
