﻿using System;
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
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.tabuleiroStart(partida.tab);

                    Console.WriteLine();

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}