namespace Ejercicio
{
    public class Vehiculo
    {
    }
}namespace Ejercicio.obj
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string Seguro { get; set; }
        public int Combustible { get; set; }
        public int CantidadLlantas { get; set; }
        public int CapacidadPersonas { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(string placa, string seguro, int combustible, int cantidadLlantas, int capacidadPersonas, string modelo){
            Placa = placa;
            Seguro = seguro;
            Combustible = combustible;
            CantidadLlantas = cantidadLlantas;
            CapacidadPersonas = capacidadPersonas;
            Modelo = modelo;
        }

        public virtual void acelerar(){
            System.Console.WriteLine("El vehículo está acelerando");
        }
    }
}