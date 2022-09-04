using System;

namespace SRP
{
    public class AlmacenLibro
    {
        private Book LibroAGuardar {get; set;}
        private EstanteBiblioteca EstanteAGuardar{get; set;}
        private SectorBiblioteca SectorAGuardar {get; set;}

        public AlmacenLibro (Book libroAGuardar, EstanteBiblioteca estanteAGuardar, SectorBiblioteca sectorAGuardar)
        {
            this.LibroAGuardar=libroAGuardar;
            this.EstanteAGuardar=estanteAGuardar;
            this.SectorAGuardar=sectorAGuardar;
        }
    }
}