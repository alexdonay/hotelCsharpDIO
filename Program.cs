using System;
using hotelCsharpDIO.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

List<Pessoa> hospedes = new();

Pessoa p1 = new("Alexsander", "Donay");
Pessoa p2 = new("Nicolas", "Cage");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new("Presidencial",1,1500);
Reserva reserva = new Reserva(31);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"No total são {reserva.ObterQuantidadeHospedes()} hospedes");
Console.WriteLine($"C:{reserva.CalcularValorDiaria()}");


