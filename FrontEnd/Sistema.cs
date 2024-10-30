using FrontEnd.Models;

namespace FrontEnd
{
    public class Sistema
    {
        private List<Venda> _vendas;
        private int _proximoIdVenda;

        public Sistema()
        {
            _proximoIdVenda = 1; // Inicia com o ID 1
        }

        public void RealizarVenda(int clienteId, int funcionarioId, int veiculoId, decimal valorTotal)
        {

            // Cria a venda
            Venda venda = new Venda
            {
                Id = _proximoIdVenda++,
                ClienteId = clienteId,
                FuncionarioId = funcionarioId,
                DataVenda = DateTime.Now,
                ValorTotal = valorTotal
            };

            _vendas.Add(venda);
            Console.WriteLine($"Venda realizada com sucesso");
        }
    }
}

