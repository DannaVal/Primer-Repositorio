using System;

namespace Laboratorio_Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1-Un proveedor de computadores ofrece descuento del 10%, si cuesta $1.000.000 o
            más. Determinar cuánto pagará, con IVA incluido (19%), un cliente si la compra
            cumple con esta condición.*/
            
            System.Console.WriteLine("Introduzca el precio de su computador");
            double precio = double.Parse(Console.ReadLine());
            //double descuento = precio * 0.10; //120000
            double descuento = 0;
            double IVA = precio * 0.19; //228000
            
           // IVA = (int)(precio * IVA);
            precio = precio + IVA; //1428000
            if (precio >= 1000000)
            {
                descuento = precio * 0.10;
                precio = precio - descuento;
            }
            
            System.Console.WriteLine("El precio a pagar por el cliente es: " +precio+
            " Y su descuento fue de " +descuento);
            System.Console.WriteLine("El IVA tuvo un valor de " + IVA);

             /*2-Realizar un algoritmo que lea un número y si éste es superior o igual a 10,
            imprimir su cubo.*/

            System.Console.WriteLine("Dígite un número");
            int numero = int.Parse(Console.ReadLine());
            int cubo = 0;

            if (numero >= 10)
            {
                cubo = numero*numero*numero;
                System.Console.WriteLine(numero+ " al cubo es: " +cubo);
            }

            else
            {
                System.Console.WriteLine("El número es menor de 10");
            }

            /*3-Un alumno desea saber cuál será su calificación final en la materia de Algoritmos.
            Dicha calificación se compone de los siguientes porcentajes:
            55% del promedio de sus tres calificaciones parciales.
            30% de la calificación del examen final.
            15% de la calificación de un trabajo final*/


            System.Console.WriteLine("Ingrese su primera nota parcial");
            double nota1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese su segunda nota parcial");
            double nota2 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese su tercera nota parcial");
            double nota3 = double.Parse(Console.ReadLine());

            double promNotas = (nota1 + nota2 + nota3) / 3; //4
            double porcentajeNotas = promNotas * 0.55; 

            System.Console.WriteLine("Ingrese la nota de su examen final");
            double examen = double.Parse(Console.ReadLine());
            double porcentajeExamen = examen * 0.30;

            System.Console.WriteLine("Ingrese la nota de su trabajo final");
            double trabajo = double.Parse(Console.ReadLine());
            double procentajeTrabajo = trabajo * 0.15;

            double calificacionFinal = porcentajeNotas + porcentajeExamen + procentajeTrabajo;

            System.Console.WriteLine("Su nota final es: " + calificacionFinal);

            /*4-Pedir al usuario que ingrese una letra cualquiera del abecedario y mostrar por
            consola si se trata de un vocal o una consonante.*/

            System.Console.WriteLine("Ingrese una letra en minúscula aleatoria del abecedario");
            string letra = Console.ReadLine();

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                System.Console.WriteLine("La letra es vocal");
            }

            else
            {
                System.Console.WriteLine("La letra es consonante");
            }

            /*5-Calcular el número de pulsaciones que una persona debe tener por cada 10
            segundos de ejercicio, si la fórmula es:
            num_pulsaciones = (220 - edad)/10 */

            System.Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());

            double numPulsaciones = (220 - edad)/10 ;
            
            System.Console.WriteLine("El número de pulsaciones que debe tener una persona de " +edad+ " años en 10 segundos es: " +numPulsaciones);

            /*6-La presión, el volumen y la temperatura de una masa de aire se relacionan por la
            fórmula:
            masa = (presión * volumen) / (0.37 * (temperatura + 460)).
            mostrar el resultado de dicha operación.*/

            System.Console.WriteLine("Ingrese la presión del aire");
            int presion = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Ingrese el volumen del aire");
            int volumen = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Ingrese la temperatura del aire");
            int temperatura = int.Parse(Console.ReadLine());

            double masa = (presion * volumen) / (0.37 * (temperatura + 460));

            System.Console.WriteLine("La masa de aire es: " +masa);

            /*7-Un hombre desea saber cuánto dinero se genera por concepto de intereses sobre
            la cantidad que tiene en inversión en el banco. El decidirá reinvertir los intereses
            siempre y cuando estos excedan a $7000, y en ese caso desea saber cuánto
            dinero tendrá finalmente en su cuenta.*/

            System.Console.WriteLine("Ingrese la inversión que tiene en el banco");
            int inversion = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Ingrese cuántos son los intereses");
            int intereses = int.Parse(Console.ReadLine());

            int interesesGenerados = inversion*intereses;

            if (interesesGenerados >= 7000)
            {
                Console.WriteLine("Usted reinvirtió sus intereses");
            }

            int dineroFinal = inversion - interesesGenerados;

            /*8-Crea un array de 10 posiciones, pide los valores por consola y muestra el array.*/
       
            string[] animales = new string[10];

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Ingrese un animal que le guste");
                string animal = Console.ReadLine();
                animales[i] = animal;
            }

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(+i+ ": " +animales[i]);
            }

            /*9-Almacena N cantidad de números en un array, muestra por consola el mayor y el
            menor.*/

            System.Console.WriteLine("Ingresa la cantidad de números");
            int cantidad = int.Parse(Console.ReadLine());
            int[] numeros = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                System.Console.WriteLine("Ingrese el número " +(i+1));
                int numeroA = int.Parse(Console.ReadLine());
                numeros[i] = numeroA;
            }

            int numMayor = numeros[0];
            int numMenor = numeros[0];

            for (int i = 0; i < cantidad; i++)
            {
                if (numeros[i] > numMayor)
                {
                    numMayor = numeros[i];
                }
                if (numeros[i] < numMenor)
                {
                    numMenor = numeros[i];
                }
            }

            System.Console.WriteLine("El número mayor es: " +numMayor + " y el número menor es: " +numMenor);
        
            /*10-Solicita el ingreso de 10 números, almacénalos en un vector. Recorre el vector y
            muestra por consola si el numero es par o impar.*/
       
            double[] parEimpar = new double[10];

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Ingrese el número " +(i+1));
                int numeroPI = int.Parse(Console.ReadLine());
                parEimpar[i] = numeroPI;
            }

            for (int i = 0; i < 10; i++)
            {
                if (parEimpar[i]%2==0)
                {
                    System.Console.WriteLine("El número " +parEimpar[i]+ " es par");
                }
                else
                {
                    System.Console.WriteLine("El número " +parEimpar[i]+ " es impar");
                }
            }
        }
    }
}
