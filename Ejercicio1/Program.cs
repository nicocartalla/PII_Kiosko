using System;

namespace Expert_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Alfajor a = new Alfajor(10, 8.5);
            Kiosco k = new Kiosco();
            if (k.PuedeComprar(a, 15, "$")) //Se debe de crear una clase saldo.cs para corroborar el credito de la persona
            {
                Console.WriteLine("Felicitaciones! Tiene suficiente dinero para comprar un alfajor :)");
            }
            else
            {
                Console.WriteLine("Mejor consiga un trabajo :(");
            }
        }
    }
}
