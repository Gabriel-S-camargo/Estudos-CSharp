using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XadrezConsole.tabuleiro;


namespace XadrezConsole
{
    class Tela
    {
        public static void tabuleiroStart(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for(int j = 0; j < tab.colunas; j++)
                {
                    if(tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {

                    Console.Write(tab.peca(j, i) + " ");
                    }

                }

                Console.WriteLine();
            }
        }
    }
}
