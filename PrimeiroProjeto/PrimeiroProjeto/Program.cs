using System;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo trianguloX = new Triangulo();

            Triangulo trianguloY = new Triangulo();

            Console.WriteLine("Digite os lados do triangulo X: ");
            trianguloX.A = double.Parse(Console.ReadLine());
            trianguloX.B = double.Parse(Console.ReadLine());
            trianguloX.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite os lados do triangulo Y: ");
            trianguloY.A = double.Parse(Console.ReadLine());
            trianguloY.B = double.Parse(Console.ReadLine());
            trianguloY.C = double.Parse(Console.ReadLine());

            double p = (trianguloX.A + trianguloX.B + trianguloX.C) / 2.0;

            double areaX = Math.Sqrt(p * (p - trianguloX.A) * (p - trianguloX.B) * (p - trianguloX.C));

            p = (trianguloY.A + trianguloY.B + trianguloY.C) / 2.0;

            double areaY = Math.Sqrt(p * (p - trianguloY.A) * (p - trianguloY.B) * (p - trianguloY.C));

            Console.WriteLine("Area de X: " + areaX.ToString("F"));
            Console.WriteLine("Area de Y: " + areaY.ToString("F"));

            if(areaX > areaY)
            {
                Console.WriteLine("Maior Area : X ");
            }
            else
            {
                Console.WriteLine("Maior Area : Y");
            }

        }
    }
}