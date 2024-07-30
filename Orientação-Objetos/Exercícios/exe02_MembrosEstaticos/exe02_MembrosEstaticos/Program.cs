using System;

namespace exe02_MembrosEstaticos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe Cotacao Dolar: ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe quantiadade de dolar desejado: ");
            double quantidadeDol = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser Pago em reais: " + ConversorDeMoeda
                .calcularTotalReal(cotacao, quantidadeDol)
                .ToString("F2"));
        }
    }
}