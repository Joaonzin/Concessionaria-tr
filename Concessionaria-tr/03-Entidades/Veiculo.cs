using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria_tr._01_Entidades
{
    public class Veiculo
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }
        public string Placa { get; set; }
        public bool Disponivel { get; set; }
    }
}
