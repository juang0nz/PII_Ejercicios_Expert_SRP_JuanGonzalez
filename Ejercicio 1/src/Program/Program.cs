using System;

namespace SRP
{

    class Program
    {
        static void Main(string [] args)
        {
            //Se crean los objetos estante para cada libro
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            EstanteBiblioteca estante1= new EstanteBiblioteca("7");
            SectorBiblioteca sector1 = new SectorBiblioteca("A");

            Book book2 = new Book("Pro C#","Troelsen","001-035");
            EstanteBiblioteca estante2= new EstanteBiblioteca("3");
            SectorBiblioteca sector2 = new SectorBiblioteca("B");
           
            
            /*book1.EstanteBiblioteca("A","7");
            book2.EstanteBiblioteca("B","3");*/

            /*Se decidió concederle a la clase AlmacenLibro el privilegio de conocer el libro, el estante y sector a almacenar 
            ya que en el caso de poner el método almacenar en cualquiera de las otras clases no estariamos cumpliendo con el principio Expert*/


            AlmacenLibro almacenaje1 = new AlmacenLibro(book1 , estante1, sector1);
            AlmacenLibro almacenaje2= new AlmacenLibro(book2, estante2, sector2);
            

            

        }
    }
}