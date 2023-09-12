using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6Ex
{
    class Autoturism
    {
        private readonly string marca;
        private string NrInmatriculare= string.Empty;
        private readonly int cc;

        public Autoturism( string marca,  int cc)
        {
            this.marca = marca;
          
            this.cc = cc;
        }
       public void SetNrInmatriculare( string nrInmt)
        {
            NrInmatriculare = nrInmt;
        }

        public void Tiparire()
        {
            Console.WriteLine($"Marca autoturismului : {this.marca}, numarul de inmatriculare:{this.NrInmatriculare}, Capacitate cilindrica{this.cc}");

        }
    }
}
