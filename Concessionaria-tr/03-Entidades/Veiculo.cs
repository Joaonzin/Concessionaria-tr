﻿
namespace Concessionaria_tr.Entidades
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }
        public string Placa { get; set; }
        public bool Disponivel { get; set; }
    }
}
