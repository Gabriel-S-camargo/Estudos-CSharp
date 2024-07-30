using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe02_MembrosEstaticos
{
    internal class ConversorDeMoeda
    {
        public static double calcularTotalReal(double cotacao, double quantidadeDol)
        {

            double totalConvercao = (cotacao * quantidadeDol) + ((cotacao * quantidadeDol) * 0.06);

            return totalConvercao;
        }
    }
}
