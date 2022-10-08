using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotelCsharpDIO.Models
{
    public class Suite
    {
        private string tipoSuite;
        public int capacidade;
        public decimal valorDiaria;
        public Suite(){}
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            this.tipoSuite = tipoSuite;
            this.capacidade = capacidade;
            this.valorDiaria = valorDiaria;
        }
    }
}