// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;
        public Calculadora(double dato = 0)
        { //sin parametro y dato se inicializa en 0 ó con parametro sin inicializar datoPorParametro = dato o = 0 como está escrito 
            this.dato = dato;
        }
        public void Sumar(double termino)
        {
            dato += termino;
        }
        public void Restar(double termino)
        {
            dato -= termino;
        }
        public void Producto(double termino)
        {
            dato = dato * termino;
        }
        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                dato = dato / termino;
            }
            else
            {
                System.Console.WriteLine("No es posible dividir en cero");
            }
        }
        public double GetResultado()
        {
            return dato;
        }
    }
}