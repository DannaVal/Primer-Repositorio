using System;

namespace Taller_CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            while (opcion != 3)
            {
                System.Console.WriteLine("1.Gestion de Empleados \n2. Gestion de proveedores \n3. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Empleado.menu();
                        break;
                    default:
                        break;

                    case 2:
                        Proveedor.menu();
                        break;
                }
            }
        }
    }
}
