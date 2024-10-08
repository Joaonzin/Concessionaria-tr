using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria_tr._03_Entidades
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
