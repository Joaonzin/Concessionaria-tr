
namespace Concessionaria_tr.Entidades
{
    public class AgendamentoDTO
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string ClienteNome { get; set; }  // Nome do cliente para simplificar
        public int VeiculoId { get; set; }
        public string VeiculoModelo { get; set; }  // Modelo do veículo
        public DateTime DataHora { get; set; }
        public string Motivo { get; set; }
    }

}
