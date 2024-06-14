using System;

namespace Ispit.Konzola
{
    public class PrijenosnaRacunalaBaza
    {
        public string NazivProcesora { get; set; }
        public int KolicinaRamGB { get; set; }
        public string KolicinaHdd { get; set; }
        public decimal Cijena { get; set; }
        public Proizvodjac Proizvodjac { get; set; }
    }
}
