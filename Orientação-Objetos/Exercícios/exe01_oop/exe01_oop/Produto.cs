using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe01_oop
{
    class Produto
    {
        private int _id; 
        private string _nome  = string.Empty;
        private double _preco;
        private int _quantidade; 

        public Produto(int id, string nome, double preco, int quantidade)
        {
            this._id = id;
            this._nome = nome;
            this._preco = preco;
            this._quantidade = quantidade;
        }

        public int Id { get { return _id; } }

        public string Nome
        {
            get { return _nome; }
            set { if (value != null && value.Length > 1) { _nome = value; } }
        }

        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value > 1) { _preco = value; }

            }
        }

        public int Quantidade
        {
            get { return _quantidade; }

            set { if (value > 1) { _quantidade = value; } }
        }
        public double valorTotalEmEstoque()
        {
            return this.Preco * this._quantidade;
        }

        public void adicionarProdutos(int quantidade)
        {
            this._quantidade += quantidade;
        }

        public void removerProdutos(int quantidade)
        {
            this._quantidade -= quantidade;
        }

        public override string ToString()
        {
            return "Nome: " + this.Nome + " Preco: " + this.Preco + " Quantidade: " + this._quantidade;
        }

    }
}
