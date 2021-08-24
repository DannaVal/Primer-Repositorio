using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi t1 = new Taxi("JHL-887", "Sura", 23000, 4, 4, "taxi", 2000, "Sura");
            t1.acelerar();
            t1.suscripcionSeguro(true);
        }
    }
}
