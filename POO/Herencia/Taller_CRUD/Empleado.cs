using System;
using System.Collections.Generic;
using System.Linq;

namespace Taller_CRUD
{
    public class Empleado : Usuario
    {
        int Edad { get; set; }
        string Cargo { get; set; }
        int Salario { get; set;}
        static List<Empleado> empleados = new List<Empleado>();
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
                System.Console.WriteLine("Menú empleados \n1.Registrar empleado \n2.Eliminar empleado \n3.Editar empleado \n4.Consultar empleado \n5.Calcular bonificación \n6.Listar empleados \n7.Regresar al menú principal");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: 
                        registar();
                    break; 
                    case 2: 
                        eliminar();
                    break;
                    case 3: 
                        editar();
                    break;
                    case 4: 
                        consultar();
                    break;
                    case 5: 
                        bonificacion();
                    break;
                    case 6: 
                        listar();
                    break;
                    case 7: 
                        System.Console.WriteLine("Regresar");
                    break;
                    default:
                    break;
                }
            }
        } 

        public void infoEmpleado()
        {
            System.Console.WriteLine("Empleado " + this.Nombre + " " + this.Apellidos + "\n");
            System.Console.WriteLine("Documento: " + this.Documento);
            System.Console.WriteLine("Nombre: " + this.Nombre);
            System.Console.WriteLine("Apellidos: " + this.Apellidos);
            System.Console.WriteLine("Género: " + this.Genero);
            System.Console.WriteLine("Dirección: " + this.Direccion);
            System.Console.WriteLine("Correo electrónico: " + this.CorreoElectronico);
            System.Console.WriteLine("Teléfono: " + this.Telefono);
            System.Console.WriteLine("Edad: " + this.Edad);
            System.Console.WriteLine("Cargo: " + this.Cargo);
            System.Console.WriteLine("Salario: " + this.Salario);
        }

        public static void registar()
        {
            System.Console.WriteLine("\n Ingresa el documento del empleado");
            int documentoEmpleado = int.Parse(Console.ReadLine());
            string nombreEmpleado;
            string apellidosEmpleado;
            string generoEmpleado;
            string direccionEmpleado;
            string correoElectronicoEmpleado;
            int telefonoEmpleado;
            int edadEmpleado;
            string cargoEmpleado;
            int salarioEmpleado;

            if (empleados.Count() > 0)
            {
                System.Console.WriteLine(empleados.Count());
                foreach (var item in empleados.ToList())
                {
                    if (item.Documento.Equals(documentoEmpleado))
                    {
                        System.Console.WriteLine("El empleado ya está registrado");
                    }
                    else
                    {
                        System.Console.WriteLine("Ingrese el nombre del empleado");
                        nombreEmpleado = Console.ReadLine();
                        System.Console.WriteLine("Ingrese los apellidos del empleado");
                        apellidosEmpleado = Console.ReadLine();
                        System.Console.WriteLine("Ingrese el género del empleado");
                        generoEmpleado = Console.ReadLine();
                        System.Console.WriteLine("Ingrese la dirección del empleado");
                        direccionEmpleado = Console.ReadLine();
                        System.Console.WriteLine("Ingrese el correo electrónico del empleado");
                        correoElectronicoEmpleado = Console.ReadLine();
                        Console.WriteLine("Ingrese el teléfono del empleado");
                        telefonoEmpleado = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la edad del empleado");
                        edadEmpleado = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el cargo del empleado");
                        cargoEmpleado = Console.ReadLine();
                        Console.WriteLine("Ingrese el salario del empleado");
                        salarioEmpleado = int.Parse(Console.ReadLine());
                        
                        var empleado = new Empleado(documentoEmpleado, nombreEmpleado, apellidosEmpleado, generoEmpleado, direccionEmpleado, correoElectronicoEmpleado, telefonoEmpleado, edadEmpleado, cargoEmpleado, salarioEmpleado);
                        empleados.Add(empleado);
                        System.Console.WriteLine("El registro fue éxitoso");

                    }
                }
            }
            else
            {
                System.Console.WriteLine("Ingrese el nombre del empleado");
                nombreEmpleado = Console.ReadLine();
                System.Console.WriteLine("Ingrese los apellidos del empleado");
                apellidosEmpleado = Console.ReadLine();
                System.Console.WriteLine("Ingrese el género del empleado");                    generoEmpleado = Console.ReadLine();
                System.Console.WriteLine("Ingrese la dirección del empleado");                        direccionEmpleado = Console.ReadLine();
                System.Console.WriteLine("Ingrese el correo electrónico del empleado");
                correoElectronicoEmpleado = Console.ReadLine();
                Console.WriteLine("Ingrese el teléfono del empleado");                    telefonoEmpleado = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la edad del empleado");
                edadEmpleado = int.Parse(Console.ReadLine());                        Console.WriteLine("Ingrese el cargo del empleado");
                cargoEmpleado = Console.ReadLine();
                Console.WriteLine("Ingrese el salario del empleado");
                salarioEmpleado = int.Parse(Console.ReadLine());
                        
                var empleado = new Empleado(documentoEmpleado, nombreEmpleado, apellidosEmpleado, generoEmpleado, direccionEmpleado, correoElectronicoEmpleado, telefonoEmpleado, edadEmpleado, cargoEmpleado, salarioEmpleado);
                empleados.Add(empleado);
                System.Console.WriteLine("El registro fue éxitoso");
            }
        }

        public static void consultar()
        {
            System.Console.WriteLine("\n Ingrese el documento del empleado");
            int documentoEmpleado = int.Parse(Console.ReadLine());
            foreach (var item in empleados)
            {
                if(documentoEmpleado == item.Documento)
                {
                    item.infoEmpleado();
                }
                else
                {
                    Console.WriteLine("No hay un empleado registrado con ese documento");
                }
            }
        }

        public static void eliminar()
        {
            System.Console.WriteLine("\n Ingrese el documento del empleado");
            int documentoEmpleado = int.Parse(Console.ReadLine());

            int indice = 0;

            foreach (var item in empleados)
            {
                if (documentoEmpleado == item.Documento)
                {
                    indice = empleados.IndexOf(item);
                }
            }
            empleados.RemoveAt(indice);
        }

        public static void editar()
        {
            System.Console.WriteLine("\n Ingrese el documento del empleado");
            int documentoEmpleado = int.Parse(Console.ReadLine());

            foreach (var item in empleados)
            {
                if (documentoEmpleado == item.Documento)
                {
                    System.Console.WriteLine("Ingrese el nombre del empleado");
                    string nombreEmpleado = Console.ReadLine();
                    item.Nombre = nombreEmpleado;
                    System.Console.WriteLine("Ingrese los apellidos del empleado");
                    string apellidosEmpleado = Console.ReadLine();
                    item.Apellidos = apellidosEmpleado;
                    System.Console.WriteLine("Ingrese el género del empleado"); 
                    string generoEmpleado = Console.ReadLine();
                    item.Genero = generoEmpleado;
                    System.Console.WriteLine("Ingrese la dirección del empleado");                       
                    string direccionEmpleado = Console.ReadLine();
                    item.Direccion = direccionEmpleado;
                    System.Console.WriteLine("Ingrese el correo electrónico del empleado");
                    string correoElectronicoEmpleado = Console.ReadLine();
                    item.CorreoElectronico = correoElectronicoEmpleado;
                    Console.WriteLine("Ingrese el teléfono del empleado");                    
                    int telefonoEmpleado = int.Parse(Console.ReadLine());
                    item.Telefono = telefonoEmpleado;
                    Console.WriteLine("Ingrese la edad del empleado");
                    int edadEmpleado = int.Parse(Console.ReadLine());  
                    item.Edad = edadEmpleado;                   
                    Console.WriteLine("Ingrese el cargo del empleado");
                    string cargoEmpleado = Console.ReadLine();
                    item.Cargo = cargoEmpleado;
                    Console.WriteLine("Ingrese el salario del empleado");
                    int salarioEmpleado = int.Parse(Console.ReadLine());
                    item.Salario = salarioEmpleado;

                    System.Console.WriteLine("El empleado se ha actualizado correctamente");
                }
            }
        }

        public static void bonificacion()
        {
            System.Console.WriteLine("\n Ingrese el documento del empleado");
            int documentoEmpleado = int.Parse(Console.ReadLine());

            foreach (var item in empleados)
            {
                if (documentoEmpleado == item.Documento)
                {
                    item.infoEmpleado();
                    System.Console.WriteLine("Ingrese la cantidad de horas trabajadas por el empleado");
                    int horasEmpleado = int.Parse(Console.ReadLine());
                    if (horasEmpleado > 176)
                    {
                        int bonificacionEmpleado = 100000;
                        System.Console.WriteLine("El empleado obtuvo una bonificación de " + bonificacionEmpleado + "\n Su total a recibir es de: " + (item.Salario + bonificacionEmpleado));
                    }
                    else
                    {
                        System.Console.WriteLine("El empleado no cumplió con las horas requeridas para recibir bonificación");
                    }
                }
                else
                {
                    System.Console.WriteLine("El documento no ha sido registrado para ningún empleado");
                }
            }
        }

        public static void listar()
        {
            int contador = empleados.Count();

            if (contador > 0)
            {
              foreach (var empleado in empleados)
              {
                 System.Console.WriteLine("El documento del empleado " +contador+ " es: " +empleado.Documento);
                 System.Console.WriteLine("El Nombre del empleado " +contador+ " es: " +empleado.Nombre); 
                 System.Console.WriteLine("Los apellidos del empleado " +contador+ " son: " +empleado.Apellidos);
                 System.Console.WriteLine("El género del empleado " +contador+ " es: " +empleado.Genero);
                 System.Console.WriteLine("La dirección del empleado " +contador+ " es: " +empleado.Direccion);
                 System.Console.WriteLine("El correo electrónico del empleado " +contador+ " es: " +empleado.CorreoElectronico);
                 System.Console.WriteLine("El teléfono del empleado " +contador+ " es: " +empleado.Telefono);
                 System.Console.WriteLine("La edad del empleado " +contador+ " es: " +empleado.Edad);
                 System.Console.WriteLine("El cargo del empleado " +contador+ " es: " +empleado.Cargo);
                 System.Console.WriteLine("El salario del empleado " +contador+ " es: " +empleado.Salario);

              }  
            }
            else
            {
                System.Console.WriteLine("No hay empleados registrados");
            }
        }

    }
}