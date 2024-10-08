using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria_tr._03_Entidades.DTOs
{
    public class EstoqueDTO
    {
        public int Id { get; set; }
        public int VeiculoId { get; set; }
        public string VeiculoModelo { get; set; }  // Modelo do veículo
        public int Quantidade { get; set; }
    }

}
