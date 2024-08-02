using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamentoDeMemoria
{
    struct Point
    {
        public double X;
        public double Y;

        override public string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}
