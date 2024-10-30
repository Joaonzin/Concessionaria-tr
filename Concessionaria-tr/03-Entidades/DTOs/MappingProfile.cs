using AutoMapper;

namespace Concessionaria_tr.Entidades
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

            // Mapeamento para Funcionario
            CreateMap<FuncionarioDTO, Funcionario>().ReverseMap();
        }
    }

}
