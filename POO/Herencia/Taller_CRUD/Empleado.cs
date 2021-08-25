using System;

namespace Taller_CRUD
{
    public class Empleado : Usuario
    {
        int Edad { get; set; }
        string Cargo { get; set; }
        int Salario { get; set;}
        public Empleado(int documento, string nombre, string apellidos, string genero, string direccion, string correoElectronico, int telefono, int edad, string cargo, int salario) : base(documento, nombre, apellidos, genero, direccion, correoElectronico, telefono)
        {
            Edad = edad;
            Cargo = cargo;
            Salario = salario;
        }
        public static void menu()
        {
            int opcion = 0;
            while (opcion != 7)
            {
                System.Console.WriteLine("1. \n2. \n3. \n4. \n5. \n6. \n7.");

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