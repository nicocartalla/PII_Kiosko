using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; } 
        public string Codigo { get ;  } 
        public string SectorBiblioteca { get ; set; } // Hay que crear un nuevo Objeto bibloteca y en ella se debe almacenar el libro, por lo tanto se crea una nueva clase Bibloteca.cs
        public string EstanteBiblioteca { get ; set; }
                                                    // Se debe de crear un objeto y clase Autor
        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }
                                                
        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
