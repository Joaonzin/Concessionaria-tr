using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria_tr._03_Entidades.DTOs
{
    public class VendaDTO
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public int ClienteId { get; set; }
        public string ClienteNome { get; set; }  // Apenas o nome do cliente para simplificação
        public int VendedorId { get; set; }
        public string VendedorNome { get; set; }  // Apenas o nome do vendedor
        public int VeiculoId { get; set; }
        public string VeiculoModelo { get; set; }  // Modelo do veículo
        public double ValorFinal { get; set; }
    }


}
