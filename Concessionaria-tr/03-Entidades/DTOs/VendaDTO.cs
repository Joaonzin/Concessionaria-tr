
namespace Concessionaria_tr.Entidades
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
