using System;
using System.Text;

namespace Library
{
    public class Paciente
    {
        public Paciente(int id, String nombre, string apellido, int telefono, string direccion){

            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Direccion = direccion;
        }

        public int Id {get; set;}
        
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public int Telefono {get; set;}
        public string Direccion {get; set;}
    }

}
      