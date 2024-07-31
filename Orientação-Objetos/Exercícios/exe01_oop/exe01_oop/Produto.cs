using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe01_oop
{
    class Produto
    {
        private int Id { get; set; }
        private string Nome { get; set; } = string.Empty;
        private double Preco { get; set; }
        private int quantidade { get; set; }

        public Produto(int id, string nome, double preco, int quantidade)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
            this.quantidade = quantidade;
        }

        public int GetId()
        {
            return this.Id;
        }
        public void SetId(int id)
        {
            this.Id = id;
        }

       public string GetNome()
        {
            return this.Nome;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public double GetPreco()
        {
            return this.Preco;
        }

        public void SetPreco(double preco)
        {
            this.Preco = preco;
        }

        public int GetQuantidade()
        {
            return this.quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
        public double valorTotalEmEstoque()
        {
            return this.Preco * this.quantidade;
        }

        public void adicionarProdutos(int quantidade)
        {
            this.quantidade += quantidade;
        }

        public void removerProdutos(int quantidade)
        {
            this.quantidade -= quantidade;
        }

        public override string ToString()
        {
            return "Nome: " + this.Nome + " Preco: " + this.Preco + " Quantidade: " + this.quantidade;
        }

    }
}
