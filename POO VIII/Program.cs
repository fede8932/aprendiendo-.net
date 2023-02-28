using System;

namespace POO_EJ8
{
    class AlbumTest
    {
        static void Main(string[] args)
        {
            AlbumFotos miAlbum1 = new AlbumFotos();
            Console.WriteLine(miAlbum1.GetNumeroPaginas());
            AlbumFotos miAlbum2 = new AlbumFotos(24);
            Console.WriteLine(miAlbum2.GetNumeroPaginas());
            SuperAlbumFotos miGranAlbum1 = new SuperAlbumFotos();
            Console.WriteLine(miGranAlbum1.GetNumeroPaginas());
        }
    }
    public class AlbumFotos
    {
        protected int numPaginas;
        public AlbumFotos()
        {
            this.numPaginas = 16;
        }
        public int GetNumeroPaginas()
        {
            return this.numPaginas;
        }
        public AlbumFotos(int numPaginas)
        {
            this.numPaginas = numPaginas;
        }
    }
    public class SuperAlbumFotos : AlbumFotos
    {
        public SuperAlbumFotos()
        {
            numPaginas = 64;
        }
    }
}



/*Para empezar cree una clase llamada AlbumFotos con un atributo privado numPaginas de tipo int. Además debe tener un método público GetNumeroPaginas que devolverá el número de páginas del álbum de fotos.

El constructor predeterminado creará un álbum con 16 páginas. Habrá un constructor adicional, con el que podremos especificar el número de páginas que queremos en el álbum.*/