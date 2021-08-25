using System;

namespace Taller_CRUD
{
    public class Usuario
    {
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set;}
        public string Genero { get; set;}
        public string Direccion { get; set;}
        public string CorreoElectronico { get; set;}
        public int Telefono { get; set;}
        public Usuario(int documento, string nombre, string apellidos, string genero, string direccion, string correoElectronico, int telefono)
        {
            Documento = documento;
            Nombre = nombre;
            Apellidos = apellidos;
            Genero = genero;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
        }
    }
}