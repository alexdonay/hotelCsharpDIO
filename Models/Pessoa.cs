using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotelCsharpDIO.Models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }
    }
}