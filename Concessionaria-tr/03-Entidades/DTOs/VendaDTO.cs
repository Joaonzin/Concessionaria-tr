
namespace Concessionaria_tr.Entidades
{
    public class VendaDTO
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public int ClienteId { get; set; }
        public int FuncionarioId { get; set; }
        public int VeiculoId { get; set; }
        public double ValorFinal { get; set; }
    }


}
