namespace Ejercicio
{
    public class Taxi : Vehiculo
    {
        
       int ValorCupo {get; set;}
       string EmpresaAfiliada {get; set;}
       public Taxi(string placa, string seguro, int combustible, int cantidadLlantas, int capacidadPersonas, string modelo, int valorCupo, string empresaAfiliada) : base(placa, seguro, combustible, cantidadLlantas, capacidadPersonas, modelo){
           ValorCupo = valorCupo;
           EmpresaAfiliada = empresaAfiliada;
       }

        public Taxi()
        {
        }

        public Taxi(int valorCupo, string empresaAfiliada)
        {
            ValorCupo = valorCupo;
            EmpresaAfiliada = empresaAfiliada;
        }

        public  overwrite acelerar(){
           System.Console.WriteLine("El taxi está acelerando");
       }

       public void suscripcionSeguro(bool seguro){
            if(seguro)
            {
                System.Console.WriteLine("Tiene seguro");
            }

            else
            {
                System.Console.WriteLine("No tiene seguro");
            }
        }

    }
}