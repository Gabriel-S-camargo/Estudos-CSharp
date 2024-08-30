using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XadrezConsole.tabuleiro;

namespace XadrezConsole.xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tabuleiro.peca(pos);

            return p == null || p.cor != this.cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);

            // Acima

            pos.definirValores(posicao.linha-1, posicao.coluna);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // Diagonal Superior Direita

            pos.definirValores(posicao.linha - 1, posicao.coluna +1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // Direita

            pos.definirValores(posicao.linha, posicao.coluna +1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // Diagonal Inferior Direita

            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // baixo


            pos.definirValores(posicao.linha +1, posicao.coluna);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // Diagonal Inferior Esquerda

            pos.definirValores(posicao.linha +1, posicao.coluna -1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // Esquerda

            pos.definirValores(posicao.linha, posicao.coluna - 1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // Diagonal Superior Esquerda

            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }

    }
}
