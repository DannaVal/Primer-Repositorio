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
                System.Console.WriteLine("1.Registrar empleado \n2.Eliminar empleado \n3.Editar empleado \n4.Consultar empleado \n5.Calcular bonificación \n6.Listar empleados \n7.Regresar al menú principal");

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

        public static void Registrar
        
        if (item.Nombre)   
    }
}