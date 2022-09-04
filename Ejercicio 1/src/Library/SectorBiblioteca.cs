using System;

namespace SRP
{
    public class SectorBiblioteca
    {
        //Se define como atributo
        private string sector;       
        public string Sector {get; set;}

        //Se crea el método constructor
        public SectorBiblioteca (string Sector)
        {
            this.sector=Sector;
          
        }
    }


}