using System;
using System.Collections.Generic;
using System.Linq;

namespace Taller_CRUD
{
    public class Proveedor : Usuario
    {
        static List<Proveedor> proveedores = new List<Proveedor>();
        public Proveedor(int documento, string nombre, string apellidos, string genero, string direccion, string correoElectronico, int telefono) : base(documento, nombre, apellidos, genero, direccion, correoElectronico, telefono)
        {
        }

        public static void menu()
        {
            int opcion = 0;
            while (opcion != 6)
            {
                System.Console.WriteLine("1. Registrar proveedor \n2. Eliminar proveedor \n3. Editar proveedor \n4. Consultar proveedor \n5. Listar proveedores \n6. Regresar al menú principal");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: 
                        registar();
                    break;
                    case 2: 
                        eliminar();
                    break;
                    case 3: 
                        editar();
                    break;
                    case 4: 
                        consultar();
                    break;
                    case 5: 
                        listar();
                    break;
                    case 6: 
                        System.Console.WriteLine("Regresar");
                    break;
                    
                    default:
                    break;
                }
            }
        } 
        public void infoProveedor()
        {
            System.Console.WriteLine("Proveedor " + this.Nombre + " " + this.Apellidos + "\n");
            System.Console.WriteLine("Documento: " + this.Documento);
            System.Console.WriteLine("Nombre: " + this.Nombre);
            System.Console.WriteLine("Apellidos: " + this.Apellidos);
            System.Console.WriteLine("Género: " + this.Genero);
            System.Console.WriteLine("Dirección: " + this.Direccion);
            System.Console.WriteLine("Correo electrónico: " + this.CorreoElectronico);
            System.Console.WriteLine("Teléfono: " + this.Telefono);
        } 

        public static void registar()
        {
            System.Console.WriteLine("\n Ingresa el documento del proveedor");
            int documentoProveedor = int.Parse(Console.ReadLine());
            string nombreProveedor;
            string apellidosProveedor;
            string generoProveedor;
            string direccionProveedor;
            string correoElectronicoProveedor;
            int telefonoProveedor;

            if (proveedores.Count() > 0)
            {
                System.Console.WriteLine(proveedores.Count());
                foreach (var item in proveedores.ToList())
                {
                    if (item.Documento.Equals(documentoProveedor))
                    {
                        System.Console.WriteLine("El proveedor ya está registrado");
                    }
                    else
                    {
                        System.Console.WriteLine("Ingrese el nombre del proveedor");
                        nombreProveedor = Console.ReadLine();
                        System.Console.WriteLine("Ingrese los apellidos del proveedor");
                        apellidosProveedor = Console.ReadLine();
                        System.Console.WriteLine("Ingrese el género del proveedor");
                        generoProveedor = Console.ReadLine();
                        System.Console.WriteLine("Ingrese la dirección del proveedor");
                        direccionProveedor = Console.ReadLine();
                        System.Console.WriteLine("Ingrese el correo electrónico del proveedor");
                        correoElectronicoProveedor = Console.ReadLine();
                        Console.WriteLine("Ingrese el teléfono del proveedor");
                        telefonoProveedor = int.Parse(Console.ReadLine());

                        var proveedor = new Proveedor(documentoProveedor, nombreProveedor, apellidosProveedor, generoProveedor, direccionProveedor, correoElectronicoProveedor, telefonoProveedor);
                        proveedores.Add(proveedor);
                        System.Console.WriteLine("El registro fue éxitoso");

                    }
                }
            }
            else
            {
                System.Console.WriteLine("Ingrese el nombre del proveedor");
                nombreProveedor = Console.ReadLine();
                System.Console.WriteLine("Ingrese los apellidos del proveedor");
                apellidosProveedor = Console.ReadLine();
                System.Console.WriteLine("Ingrese el género del proveedor");
                generoProveedor = Console.ReadLine();
                System.Console.WriteLine("Ingrese la dirección del proveedor");
                direccionProveedor = Console.ReadLine();
                System.Console.WriteLine("Ingrese el correo electrónico del proveedor");
                correoElectronicoProveedor = Console.ReadLine();
                Console.WriteLine("Ingrese el teléfono del proveedor");
                telefonoProveedor = int.Parse(Console.ReadLine());
                        
                var proveedor = new Proveedor(documentoProveedor, nombreProveedor, apellidosProveedor, generoProveedor, direccionProveedor, correoElectronicoProveedor, telefonoProveedor);
                proveedores.Add(proveedor);
                System.Console.WriteLine("El registro fue éxitoso");
            }
        }
        public static void consultar()
        {
            System.Console.WriteLine("\n Ingrese el documento del proveedor");
            int documentoProveedor = int.Parse(Console.ReadLine());
            foreach (var item in proveedores)
            {
                if(documentoProveedor == item.Documento)
                {
                    item.infoProveedor();
                }
                else
                {
                    Console.WriteLine("No hay un proveedor registrado con ese documento");
                }
            }
        }
        public static void eliminar()
        {
            System.Console.WriteLine("\n Ingrese el documento del proveedor");
            int documentoProveedor = int.Parse(Console.ReadLine());

            int indice = 0;

            foreach (var item in proveedores)
            {
                if (documentoProveedor == item.Documento)
                {
                    indice = proveedores.IndexOf(item);
                }
            }
            proveedores.RemoveAt(indice);
        }

        public static void editar()
        {
            System.Console.WriteLine("\n Ingrese el documento del proveedor");
            int documentoProveedor = int.Parse(Console.ReadLine());

            foreach (var item in proveedores)
            {
                if (documentoProveedor == item.Documento)
                {
                    System.Console.WriteLine("Ingrese el nombre del proveedor");
                    string nombreProveedor = Console.ReadLine();
                    item.Nombre = nombreProveedor;
                    System.Console.WriteLine("Ingrese los apellidos del proveedor");
                    string apellidosProveedor = Console.ReadLine();
                    item.Apellidos = apellidosProveedor;
                    System.Console.WriteLine("Ingrese el género del proveedor"); 
                    string generoProveedor = Console.ReadLine();
                    item.Genero = generoProveedor;
                    System.Console.WriteLine("Ingrese la dirección del proveedor");                       
                    string direccionEmpleado = Console.ReadLine();
                    item.Direccion = direccionEmpleado;
                    System.Console.WriteLine("Ingrese el correo electrónico del proveedor");
                    string correoElectronicoProveedor = Console.ReadLine();
                    item.CorreoElectronico = correoElectronicoProveedor;
                    Console.WriteLine("Ingrese el teléfono del proveedor");                    
                    int telefonoProveedor = int.Parse(Console.ReadLine());
                    item.Telefono = telefonoProveedor;

                    System.Console.WriteLine("El proveedor se ha actualizado correctamente");
                }
            }
        }
        public static void listar()
        {
            int contador = proveedores.Count();

            if (contador > 0)
            {
              foreach (var proveedor in proveedores)
              {
                 System.Console.WriteLine("El documento del proveedor " +contador+ " es: " +proveedor.Documento);
                 System.Console.WriteLine("El Nombre del proveedor " +contador+ " es: " +proveedor.Nombre); 
                 System.Console.WriteLine("Los apellidos del proveedor " +contador+ " son: " +proveedor.Apellidos);
                 System.Console.WriteLine("El género del proveedor " +contador+ " es: " +proveedor.Genero);
                 System.Console.WriteLine("La dirección del proveedor " +contador+ " es: " +proveedor.Direccion);
                 System.Console.WriteLine("El correo electrónico del proveedor " +contador+ " es: " +proveedor.CorreoElectronico);
                 System.Console.WriteLine("El teléfono del proveedor " +contador+ " es: " +proveedor.Telefono);
              }  
            }
            else
            {
                System.Console.WriteLine("No hay proveedores registrados");
            }
        }
    }
}