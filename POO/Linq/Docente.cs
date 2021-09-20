namespace Linq
{
    public class Docente
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Curso { get; set; }
        public int Salario { get; set; }
        public int Edad { get; set; }

        public Docente(string nombre, string apellidos, int curso, int salario, int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Curso = curso;
            Salario = salario;
            Edad = edad;
        }
    }
}