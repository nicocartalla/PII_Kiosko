using System;
using System.Text;

namespace Library
{
    public class Medico
    {
        public Medico(int id, String nombre, string apellido, int telefono,string  especialidad, string direccion){

            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Especialidad = especialidad;
        }

        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public int Telefono {get; set;}
        public string Especialidad {get; set;}
        public string Direccion {get; set;}
    }

}
      