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
            CreateMap<CreateVeiculoDTO, Veiculo>().ReverseMap();
            CreateMap<CreateVendasDTO, Venda>().ReverseMap();
        }
    }
}
