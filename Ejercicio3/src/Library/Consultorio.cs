using System;
using System.Text;

namespace Library
{
    public class Consultorio
    {
        public Consultorio(int id, String nombre, string direccion, int telefono){

            this.Id = id;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Direccion = direccion;
        }

        public int Id {get; set;}
        public string Nombre {get; set;}
        public int Telefono {get; set;}
        public string Direccion {get; set;}
    }

}