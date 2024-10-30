
namespace Concessionaria_tr.Entidades
{
    public class Agendamento
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdVeiculo { get; set; }
        public DateTime DataHora { get; set; }  
        public string Motivo { get; set; }
    }

}
