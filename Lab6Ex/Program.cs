using System;

namespace Lab6Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
        }

        static void Ex1()
        {

            AfisareVolumDulap(CitireDulap());
           
            
        }
        static void Ex2()
        {
            Console.WriteLine("Introduceti Marca Autoturismului:");
            string marca = (Console.ReadLine());
            Console.WriteLine("Introduceti numarul de inmatirculare Autoturismului:");
            string NrInmatriculare = Console.ReadLine();
            Console.WriteLine("Introduceti capaciteatea cilindrica Autoturismului:");
            int cc = int.Parse(Console.ReadLine());
            Autoturism Golf6 = new Autoturism(marca, cc);
            Golf6.SetNrInmatriculare(NrInmatriculare);
            Golf6.Tiparire();
        }
        static Dulap CitireDulap()
        {
            Console.WriteLine("Introduceti lungime dulapului:");
            int Lungime = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti lungime dulapului:");
            int Latime = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti lungime dulapului:");
            int Inaltime = int.Parse(Console.ReadLine());
            Dulap Sifonier = new Dulap(Lungime, Latime, Inaltime);
            return Sifonier;
            
        }

        static void AfisareVolumDulap(Dulap dulap)
        {
            Console.WriteLine($"Volumul dulapului:{dulap.VolumDulap()}");
        }
    }
}
