
namespace exe01__OOP
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; }
        public int quantidade { get; set; }

        public Produto(int id, string nome, double preco, int quantidade)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
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
