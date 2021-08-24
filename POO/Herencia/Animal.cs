namespace Herencia
{
    public class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int CantidadPatas { get; set; }
        public string Color { get; set; }

        public Animal(string nombre, int edad, int cantidadPatas, string color){
            Nombre = nombre;
            Edad = edad;
            CantidadPatas = cantidadPatas;
            Color = color;
        }

        public void infoAnimal(){
            System.Console.WriteLine("Nombre = " +Nombre);
            System.Console.WriteLine("Edad = " +Edad);
            System.Console.WriteLine("Cantidad de patas = " +CantidadPatas);
            System.Console.WriteLine("Color = " +Color);
        }

        public void suscripcionVeterinaria(bool suscripcion){
        System.Console.WriteLine("** Estado de la suscripción");
        }

    }

    
}