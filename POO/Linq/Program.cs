using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
           /* List<int> numeros = new List<int>{1, 5, 9, 8, 6, 7, 4};
            int suma = 0;
           for (int i = 0; i < numeros.Count; i++)
           {
               System.Console.WriteLine(numeros[i]);
           }

           foreach (var item in numeros)
           {
               System.Console.WriteLine(item);
               suma += item;
           }

           //var seleccionNumeros = numeros.Select(n => n);
           var seleccionNumeros = numeros.Where(n => n > 5);
           var sumaNumeros = numeros.Sum();

            foreach (var item in seleccionNumeros)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine(sumaNumeros);*/

            List<Perro> perros = new List<Perro>()
            {
                new Perro("Firulai", 1, 3, true),
                new Perro("Rambo", 2, 2, true),
                new Perro("Lulu", 3, 5, false),
                new Perro("Lila", 2,8, true),
                new Perro("Rocky", 3,8, false)
            };

            List<Raza> razas = new List<Raza>()
            {
                new Raza(1, "Labrador"),
                new Raza(2, "Bulldog"),
                new Raza(3, "Pomerania")
            };

            var seleccionPerros = (from sp in perros select sp.Nombre + " " + sp.Raza);
            var seleccionPerros2 = perros.Select(sp => sp.Nombre + " " + sp.Raza);

            var ordenPerros = (from op in perros orderby op.Nombre select op.Nombre).ToString();
            var ordenPerros2 = perros.OrderBy(op => op.Nombre). Select(op => op.Nombre);
            var ordenPerros3 = perros.OrderBy(op => op.Nombre).ThenBy(op => op.Vacunado).Select(op => op.Nombre);

            var filtroRaza = (from fr in perros where fr.Raza == 3 select fr.Nombre);
            var filtroVacuna = (from fr in perros where fr.Vacunado == true select fr.Nombre);
            var filtro2 = perros.Where(fr => fr.Vacunado == false).Select(fr => fr.Nombre);
            var filtro3 = (from fr in perros where fr.Raza == 2 && fr.Vacunado == true select fr.Nombre);
            var filtro4 = perros.Where(fr => fr.Vacunado == false && fr.Raza == 2).Select(fr => fr.Nombre);
            var filtroRaza2 = (from fr in razas where fr.ID == 2 select fr.NombreRaza);

            var numRegistros = (from n in perros select n.Nombre).Take(2);
            var numRegistros2 = perros.Take(2).Select(n => n.Nombre);
            var numRegistros3 = perros.OrderBy(n => n.Nombre).Take(2).Select(n => n.Nombre);
            
            var contiene = (from c in perros select c.Nombre).Contains("Firulai");
            var contiene2 = perros.Select(c => c.Nombre).Contains("Firulai");
            
            var union = (from p in perros join r in razas on p.Raza equals r.ID select new{p.Nombre, r.NombreRaza, p.Edad, p.Vacunado});
            var union2 = perros.Join(razas, p => p.Raza, r => r.ID, (p,r) => new {p.Nombre, r.NombreRaza, p.Edad, p.Vacunado});
            
            var promedio = (from p in perros select p.Edad).Average();
            var promedio2 = perros.Average(p => p.Edad);

            var grupo = (from p in perros group p by p.Raza);
            
            System.Console.WriteLine(promedio);

            foreach (var item in grupo)
            {
                System.Console.WriteLine($"Raza: {item.Key}");
                foreach (var v in item)
                {
                    System.Console.WriteLine($"{v.Nombre}, {v.Vacunado}");
                }
            }
        }
    }
}
