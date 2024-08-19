using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.Collections.Generic;
//Permite o uso de coleções genéricas, como listas (List<T>), dicionários (Dictionary<TKey, TValue>), filas (Queue<T>)

//using System.Linq;
//Facilita a manipulação de dados com consultas estilo SQL usando LINQ (Language Integrated Query)

//using System.Text;
//Fornece classes e métodos para manipulação avançada de strings e codificações de caracteres. Inclui classes como StringBuilder, que é usada para construir e modificar strings de forma mais eficiente do que com strings imutáveis.

//using System.Threading.Tasks;
//Suporta programação assíncrona e paralela. Ele inclui a classe Task, que representa uma operação assíncrona, além de métodos como async e await.

// Pastas 

using XadrezConsole.tabuleiro;
using XadrezConsole.xadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(System.String[] args)
        {
            try
            {
            Tabuleiro tab = new Tabuleiro(8,8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));

            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(9,9));


            Tela.tabuleiroStart(tab);

            }catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}