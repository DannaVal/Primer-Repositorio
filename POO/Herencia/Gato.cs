namespace Herencia
{
    public class Gato : Animal
    {
        string Raza { get; set; }
        public Gato(string nombre, int edad, int cantidadPatas, string color, string raza) : base(nombre, edad, cantidadPatas, color)
        {
            Raza = raza;
        }

        public void maullar() {
            System.Console.WriteLine($"{this.Nombre} está maullando");
        }
    }
}