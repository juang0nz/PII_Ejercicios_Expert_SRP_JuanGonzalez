using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        //estos dos atributos no van a ser necesarios en la clase-
       /* public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }*/

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

// este método deberia estar en dos  clases aparte, ya que la clase libro no tiene que tener la responsabilidad
//de conocer el sector ni la estanteria. y estos ademas presentan motivos de cambio, no estando de esta manera alineado a SRP.

       /* public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }*/

    }
}
