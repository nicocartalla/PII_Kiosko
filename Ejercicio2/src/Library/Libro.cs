using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; } 
        public string Codigo { get ;  } 

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(string estante, string sector)
        {
            Bibloteca b = new Bibloteca(sector,estante,this);

        }

                                                


    }
}
