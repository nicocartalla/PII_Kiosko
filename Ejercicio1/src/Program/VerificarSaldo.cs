using System;

namespace Expert_SRP
{

public class VerificarSaldo {
    Kiosco k = new Kiosco();
        public  VerificarSaldo(Alfajor a, double dinero)
            {

                if (k.PuedeComprar(a, dinero, "$"))
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