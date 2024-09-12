using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria_tr._01_Entidades
{
    public class Venda
    {
        public Veiculo VeiculoVendido { get; set; }
        public string Cliente { get; set; }
        public string Vendedor { get; set; }
        public DateTime DataVenda { get; set; }
        public double ValorVenda { get; set; }
    }
}
