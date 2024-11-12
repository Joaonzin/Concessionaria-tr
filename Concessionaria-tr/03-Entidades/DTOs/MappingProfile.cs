using AutoMapper;

namespace Concessionaria_tr.Entidades
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapeamento para Veiculo
            CreateMap<CreateVeiculoDTO, Veiculo>().ReverseMap();

            CreateMap<Venda, VendaDTO>().ReverseMap();

            // Mapeamento para Agendamento
            CreateMap<AgendamentoDTO, Agendamento>().ReverseMap();

            // Mapeamento para Funcionario
            CreateMap<FuncionarioDTO, Funcionario>().ReverseMap();
        }
    }

}
