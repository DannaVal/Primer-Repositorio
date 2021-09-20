namespace Linq
{
    public class Curso
    {
        public int ID { get; set; }
        public string NombreCurso { get; set; }
        
        public Curso(int id, string nombreCurso)
        {
            ID = id;
            NombreCurso = nombreCurso;
        }
    }
}