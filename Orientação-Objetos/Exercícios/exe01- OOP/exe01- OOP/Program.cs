using System;

namespace exe01__OOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE ESTOQUE");
            int opcao = 0;
            
            List<Produto> produtos = new List<Produto>();

            int id = 1;

            do
            {
                Console.WriteLine("Selecione a opção que voce deseja realizar");
                Console.WriteLine("[1] Adicionar Produto");
                Console.WriteLine("[2] Consultar Valor de estoque de um produto");
                Console.WriteLine("[3] Adicionar Produtos");
                Console.WriteLine("[4] Remover Produtos");
                Console.WriteLine("[5] Exibir informaçoes do Produto" );
                Console.WriteLine("[6] Sair do Programa");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao){

                    case 1:
                        Console.WriteLine("Digite o nome do produto");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Digite o Preco do produto");
                        double preco = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantidade em estoque do produto");
                        int quantide = int.Parse(Console.ReadLine());

                        Produto produto = new Produto(id, nome, preco, quantide);

                        produtos.Add(produto);
                        
                        id++;

                        break;

                    case 2:

                        Console.WriteLine("Informe ID do produto: ");

                        int buscaId = int.Parse(Console.ReadLine());

                        Produto produtoFind = produtos.Find(produto => produto.Id == buscaId);

                        if(produtoFind == null)
                        {
                            Console.WriteLine("Produto não encontrado!");
                        }
                        else
                        {
                            Console.WriteLine("Valor em estoque: " + produtoFind.valorTotalEmEstoque());
                        }

                        break;

                    case 3:

                        Console.WriteLine("Informe ID do produto: ");

                        buscaId = int.Parse(Console.ReadLine());

                        produtoFind = produtos.Find(produto => produto.Id == buscaId);

                        if (produtoFind == null)
                        {
                            Console.WriteLine("Produto não encontrado!");
                        }
                        else
                        {
                            Console.WriteLine("Digite o valor que deseja adicionar no estoque:");
                            int quantidadeAdd = int.Parse(Console.ReadLine());

                            produtoFind.adicionarProdutos(quantidadeAdd);

                            Console.WriteLine("Quantidade em estoque atual: " + produtoFind.quantidade);
                        }

                        break;

                    case 4:

                        Console.WriteLine("Informe ID do produto: ");

                        buscaId = int.Parse(Console.ReadLine());

                        produtoFind = produtos.Find(produto => produto.Id == buscaId);

                        if (produtoFind == null)
                        {
                            Console.WriteLine("Produto não encontrado!");
                        }
                        else
                        {
                            Console.WriteLine("Digite o valor que deseja Retirar no estoque:");
                            int quantidadeSub = int.Parse(Console.ReadLine());

                            produtoFind.adicionarProdutos(quantidadeSub);

                            Console.WriteLine("Quantidade em estoque atual: " + produtoFind.quantidade);
                        }

                        break;

                    case 5:
                        Console.WriteLine("Informe ID do produto: ");

                        buscaId = int.Parse(Console.ReadLine());

                        produtoFind = produtos.Find(produto => produto.Id == buscaId);

                        if (produtoFind == null)
                        {
                            Console.WriteLine("Produto não encontrado!");
                        }
                        else
                        {
                            Console.WriteLine(produtoFind);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Saindo...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Caracter Inválido!! Digite uma opção válida");
                        break;
                }
            }while (opcao != 6) ;
        }

    }
}