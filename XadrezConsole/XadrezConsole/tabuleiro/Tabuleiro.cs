﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XadrezConsole.tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[ linhas, colunas ];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        // Overload para pegar a peca pela posicao
        public Peca peca(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posicao Inexistente");
            }
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Ja existe uma peca nessa posicao");
            }
            
            // basicamente ta pegando uma peça da matriz de peças e dando uma posicao 
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public Peca retirarPeca(Posicao pos) {
            if (peca(pos) == null) {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }

        public bool posicaoValida(Posicao pos)
        {
            if(pos.linha < 0 || pos.linha >= linhas || pos.coluna <0 || pos.coluna >= colunas)
            {
                return false;
            }

            return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posicao Inválida");
            }
        }
    }
}
