using System;

namespace Ispit.Konzola
{
    class Program
    {
        static void Main(string[] args)
        {
            PrijenosnaRacunala prijenosnoRacunalo = new PrijenosnaRacunala();

            Console.WriteLine("Unesite naziv procesora:");
            string nazivProcesora = Console.ReadLine();

            Console.WriteLine("Unesite količinu RAM-a (GB):");
            int kolicinaRam = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite količinu HDD-a:");
            string kolicinaHdd = Console.ReadLine();

            Console.WriteLine("Unesite cijenu:");
            decimal cijena = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Odaberite proizvođača (0: Dell, 1: HP, 2: Lenovo):");
            Proizvodjac proizvodjac = (Proizvodjac)int.Parse(Console.ReadLine());

            prijenosnoRacunalo.PrikaziDetalje(nazivProcesora, kolicinaRam, kolicinaHdd, cijena, proizvodjac);
        }
    }
}
