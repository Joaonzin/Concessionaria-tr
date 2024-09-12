using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria_tr._03_Entidades.DTOs
{
    public class CreateVendasDTO
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int VeiculoId { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal Valor { get; set; }
    }

}
