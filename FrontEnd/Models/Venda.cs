public class Venda
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public int FuncionarioId { get; set; }
    public DateTime DataVenda { get; set; }
    public decimal ValorTotal { get; set; }

    public override string ToString()
    {
        return $"Id: {Id} - ClienteId: {ClienteId} - FuncionarioId: {FuncionarioId} - DataVenda: {DataVenda} - ValorTotal: {ValorTotal}";
    }
}