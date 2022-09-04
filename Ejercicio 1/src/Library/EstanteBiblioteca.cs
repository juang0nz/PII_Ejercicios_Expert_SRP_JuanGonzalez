using System;

namespace SRP
{
    public class EstanteBiblioteca
    {
        //Se define como atributo
        private string estante;       
        public string Estante {get; set;}

        //Se crea el método constructor
        public EstanteBiblioteca (string Estante)
        {
            this.estante = Estante;
            
        }

    }


}