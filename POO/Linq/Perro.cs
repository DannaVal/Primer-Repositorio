namespace Linq
{
    public class Perro
    {
        public string Nombre { get; set; }
        public int Raza { get; set; }
        public int Edad { get; set; }
        public bool Vacunado { get; set; }

        public Perro(string nombre, int raza, int edad, bool vacunado)
        {
            Nombre = nombre;
            Raza = raza;
            Edad = edad;
            Vacunado = vacunado;
        }
    }
}