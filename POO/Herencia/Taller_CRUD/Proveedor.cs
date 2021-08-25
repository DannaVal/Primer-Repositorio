using System;

namespace Taller_CRUD
{
    public class Proveedor : Usuario
    {
        public Proveedor(int documento, string nombre, string apellidos, string genero, string direccion, string correoElectronico, int telefono) : base(documento, nombre, apellidos, genero, direccion, correoElectronico, telefono)
        {
        }

        public static void menu()
        {
            int opcion = 0;
            while (opcion != 5)
            {
                System.Console.WriteLine("1. \n2. \n3. \n4. \n5.");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: 
                    break;
                    
                    default:
                    break;
                }
            }
        }  
    }
}