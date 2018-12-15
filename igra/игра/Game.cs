using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace игра
{
    class Game
    {
        public Igrok[] I=new Igrok[0];
        public int vsego;
        public Game()
        {
           // I = new Igrok();
        }
        public Game(int kol)
        {
            vsego = kol;
            Array.Resize(ref I, kol);
            for (int i = 0; i < kol; i++)
                I[i] = new Igrok(i);
        }
        public int Len()
        {
            return vsego;
        }
       
    }
}
