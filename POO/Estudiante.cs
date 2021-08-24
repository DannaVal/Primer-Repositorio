namespace POO
{

    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int Grado { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public Estudiante(string nombre, string apellido, int edad, int grado, double nota1, double nota2, double nota3)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Grado = grado;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public Estudiante(){}

        public void infoEstudiante()
        {
            System.Console.WriteLine("Nombre: " + Nombre);
            System.Console.WriteLine("Apellido: " + Apellido);
            System.Console.WriteLine("Edad: " + Edad);
            System.Console.WriteLine("Grado: " + Grado);
            System.Console.WriteLine("Primera nota: " + Nota1);
            System.Console.WriteLine("Segunda nota: " + Nota2);
            System.Console.WriteLine("Tercera nota: " + Nota3);
        }

        public double promedio()
        {
            double prom = (Nota1 + Nota2 + Nota3) / 3;
            return prom;
        }

        public void alertaPromedio(double prom)
        {
            if (prom >= 3.5)
            {
                System.Console.WriteLine("Aprobado");
            }

            else if (prom < 3.5)
            {
                System.Console.WriteLine("Reprobado");
            }
        }
    }
}
