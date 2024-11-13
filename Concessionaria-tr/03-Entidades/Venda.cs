
using static System.Net.Mime.MediaTypeNames;

namespace Concessionaria_tr.Entidades
{
    public class Venda
    {
        public int Id { get; set; }
        public int VeiculoId { get; set; }  
        public int ClienteId { get; set; }  
        public int FuncionarioId { get; set; }
        public DateTime DataVenda { get; set; }
        public double ValorFinal { get; set; }
    }
}
