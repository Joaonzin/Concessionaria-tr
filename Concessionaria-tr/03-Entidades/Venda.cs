
using static System.Net.Mime.MediaTypeNames;

namespace Concessionaria_tr.Entidades
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public Veiculo VeiculoVendido { get; set; }  
        public Cliente Cliente { get; set; }  
        public Funcionario Funcionario { get; set; }  
        public double ValorVenda { get; set; }
    }
}
