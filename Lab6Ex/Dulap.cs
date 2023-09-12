using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6Ex
{
    class Dulap
    {
        private int lungime, latime, inaltime ;


        public Dulap()
        { }
        public Dulap(int Lungime, int Latime, int Inaltime) 
        {
            this.lungime = Lungime;
            this.latime = Latime;
            this.inaltime = Inaltime;
        }
        



        public int VolumDulap()
        {
            int volum;
            volum = inaltime * latime * lungime;
            return volum;
        }
    }
}
