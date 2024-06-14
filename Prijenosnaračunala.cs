using System;

namespace Ispit.Konzola
{
    public class PrijenosnaRacunala : PrijenosnaRacunalaBaza
    {
        public void PrikaziDetalje(string nazivProcesora, int kolicinaRam, string kolicinaHdd, decimal cijena, Proizvodjac proizvodjac)
        {
            NazivProcesora = nazivProcesora;
            KolicinaRamGB = kolicinaRam;
            KolicinaHdd = kolicinaHdd;
            Cijena = cijena;
            Proizvodjac = proizvodjac;

            Console.WriteLine($"Procesor: {NazivProcesora}, RAM: {KolicinaRamGB}GB, HDD: {KolicinaHdd}, Cijena: {Cijena}kn, Proizvođač: {Proizvodjac}");
        }
    }
}
