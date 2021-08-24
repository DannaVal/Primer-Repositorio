using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro p1 = new Perro("Firulais", 10, 4, "Gris", 4);
            p1.ladrar();

            Gato g1 = new Gato("Michi", 6, 4, "Blanco", "Persa" );
            g1.maullar();

            p1.infoAnimalPerro();

            p1.suscripcionVeterinaria(true);

            p1.correr(p1.Nombre, 50);
        }
    }
}
