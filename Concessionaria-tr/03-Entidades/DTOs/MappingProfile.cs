using AutoMapper;
using Concessionaria_tr._01_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria_tr._03_Entidades.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapeamento para Veiculo
            CreateMap<CreateVeiculoDTO, Veiculo>().ReverseMap();

            // Mapeamento para Venda
            CreateMap<VendaDTO, Venda>().ReverseMap();

            // Mapeamento para Agendamento
            CreateMap<AgendamentoDTO, Agendamento>().ReverseMap();

            // Mapeamento para Estoque
            CreateMap<EstoqueDTO, Estoque>().ReverseMap();

            // Mapeamento para Funcionario
            CreateMap<FuncionarioDTO, Funcionario>().ReverseMap();
        }
    }

}
