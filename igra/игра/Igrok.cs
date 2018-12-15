using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace игра
{
    class Igrok
    {
        public int schet;
        public int nomer;
        public kosti k;
        public Igrok(int i)
        {
            k = new kosti();
            nomer = i;
            schet = 33;
        }
        public void Plus(int s)
        {
            this.schet += s;
        }
        public void Minus(int s)
        {
           this.schet -= s;
        }
        public int infoIgrok()
        {
             return this.schet;
        }

    }
}
