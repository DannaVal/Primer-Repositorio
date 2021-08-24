namespace Herencia
{
    public class Perro : Animal
    {
        int CantColmillos { get; set; }
        public Perro(string nombre, int edad, int cantidadPatas, string color, int cantColmillos) : base(nombre, edad, cantidadPatas, color)
        {
            CantColmillos = cantColmillos;
        }

        public void ladrar() {
            System.Console.WriteLine($"{this.Nombre} está ladrando");
        }

        public void infoAnimalPerro() {
            System.Console.WriteLine("** Información del perro " +Nombre + "**");
            base.infoAnimal();
            System.Console.WriteLine("Cantidad colmillos: " +CantColmillos);
        }

        public new void suscripcionVeterinaria(bool suscripcion){
            if(suscripcion)
            {
                System.Console.WriteLine("Suscripción activa");
            }

            else
            {
                System.Console.WriteLine("Suscripción inactiva");
            }
        }

        public void correr(){
            System.Console.WriteLine("El perro está corriendo");
        }

        public void correr(string nombrePerro){
            System.Console.WriteLine($"El perro {nombrePerro} está corriendo");
        }

        public void correr(string nombrePerro, int velocidad){
            System.Console.WriteLine($"El perro {nombrePerro} está corriendo a una velocidad de {velocidad}");
        }
    }
}