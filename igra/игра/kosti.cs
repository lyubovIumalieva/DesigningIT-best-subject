using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace игра
{
    class kosti
    {
        public int kol;
        public kosti()
        {
            kol = 5;
        }
        public void add()
        {
            this.kol += 1;
        }
        public void dell()
        {
            this.kol -= 1;
        }
        public int info()
        {
            return this.kol;
        }

    }
}
