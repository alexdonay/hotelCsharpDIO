using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotelCsharpDIO.Models
{
    public class Reserva
    {
    private List<Pessoa> hospedes = new List<Pessoa>();
    private Suite suite = new Suite();
    private int diasReservados;
    public Reserva(int diasReservados)
    {
        this.diasReservados = diasReservados;
    }
    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if(hospedes.Count<this.suite.capacidade)
        {
    
            this.hospedes = hospedes;   
        }
        else
        {
            throw new Exception("Quantidade de hospedes excede capacidade da Suite");
            
        }
        
    }
    public void CadastrarSuite (Suite suite)
    {
        this.suite = suite;
    }
    public int ObterQuantidadeHospedes()
    {
        return this.hospedes.Count;
    }
    public decimal CalcularValorDiaria()
    {
        return ObterQuantidadeHospedes() * this.suite.valorDiaria;
    }
    }
}