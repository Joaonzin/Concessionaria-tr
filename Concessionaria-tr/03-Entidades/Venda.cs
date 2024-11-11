
using static System.Net.Mime.MediaTypeNames;

namespace Concessionaria_tr.Entidades
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
