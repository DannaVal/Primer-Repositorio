using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Pepe";
            persona1.Apellido = "Perez";
            persona1.Edad = 30;
            persona1.Estatura = 1.75;
            persona1.Peso = 80.7;

            persona1.infoPersona();

            Persona persona2 = new Persona();
            persona2.Nombre = "Pepa";
            persona2.Apellido = "Perez";
            persona2.Edad = 28;
            persona2.Estatura = 1.78;
            persona2.Peso = 60.5;
            persona2.Salario = 3000000;

            persona2.infoPersona();

            System.Console.WriteLine(persona1.indiceMasaC());
            System.Console.WriteLine(persona2.indiceMasaC());

            persona1.alertaIMC(persona1.indiceMasaC());
            persona2.alertaIMC(persona2.indiceMasaC());

            Persona persona3 = new Persona("Daniel", "Benavides", 30, 1.70, 65, 0);
            persona3.infoPersona();
            persona3.alertaIMC(persona3.indiceMasaC());



            Estudiante estudiante1 = new Estudiante();
            estudiante1.Nombre = "Maria";
            estudiante1.Apellido = "Gonzalez";
            estudiante1.Edad = 14;
            estudiante1.Grado = 5;
            estudiante1.Nota1 = 4;
            estudiante1.Nota2 = 3;
            estudiante1.Nota3 = 2;
            estudiante1.infoEstudiante();

            System.Console.WriteLine(estudiante1.promedio());
            estudiante1.alertaPromedio(estudiante1.promedio());

            Estudiante estudiante2 = new Estudiante();
            estudiante2.Nombre = "Julián";
            estudiante2.Apellido = "Perez";
            estudiante2.Edad = 16;
            estudiante2.Grado = 10;
            estudiante2.Nota1 = 3;
            estudiante2.Nota2 = 3;
            estudiante2.Nota3 = 4;
            estudiante2.infoEstudiante();

            
            System.Console.WriteLine(estudiante2.promedio());
            estudiante2.alertaPromedio(estudiante2.promedio());
        }
    }


}
