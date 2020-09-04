using System;

namespace SRP
{
    public class Bibloteca
    {
        public string SectorBiblioteca { get ; set; } 
        public string EstanteBiblioteca { get ; set; }
        public Libro Libro {get;}

        public Bibloteca(String sector, String estante, Libro libro)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
            this.Libro = libro;
        }


    }
}