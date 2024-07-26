using System;

namespace ClassesAtributosEMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();

            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Informe Nome da Pessoa 1: ");
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine("Informe idade da Pessoa 1: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe Nome da Pessoa 2: ");
            pessoa2.Nome = Console.ReadLine();

            Console.WriteLine("Informe idade da Pessoa 2: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("Pessoa Mais Velha: " + pessoa1.Nome);

            }else if (pessoa1.Idade == pessoa2.Idade)
            {
                Console.WriteLine("Mesma Idade");
            }
            else
            {
                Console.WriteLine("Pessoa Mais Velha: " + pessoa2.Nome);
            }


        }
    }
}