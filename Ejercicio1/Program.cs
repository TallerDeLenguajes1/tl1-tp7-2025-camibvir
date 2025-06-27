// See https://aka.ms/new-console-template for more information

using EspacioCalculadora;
using System;
class Program
{
    static void Main(string[] args)
    {
        Calculadora miCalculadora = new Calculadora();
        miCalculadora.Sumar(10);
        miCalculadora.Sumar(50);
        miCalculadora.Sumar(2);
        miCalculadora.Dividir(0);
        miCalculadora.Dividir(2);
        Console.WriteLine($"El resultado es:{miCalculadora.GetResultado()} ");
    }
}