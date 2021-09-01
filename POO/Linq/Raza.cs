namespace Linq
{
    public class Raza
    {
        public int ID { get; set; }
        public string NombreRaza { get; set; }
        public Raza(int id, string nombreRaza)
        {
                ID = id;
                NombreRaza = nombreRaza;
        }
    }
}