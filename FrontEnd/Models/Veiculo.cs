public class Veiculo
{
    public int Id { get; set; }
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public string Placa { get; set; }

    public override string ToString()
    {
        return $"Id: {Id} - Modelo: {Modelo} - Marca: {Marca} - Placa: {Placa}";
    }
}