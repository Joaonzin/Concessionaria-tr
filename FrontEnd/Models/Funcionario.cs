public class Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"Id: {Id} - Nome: {Nome} - Cargo: {Cargo} - Email: {Email}";
    }
}