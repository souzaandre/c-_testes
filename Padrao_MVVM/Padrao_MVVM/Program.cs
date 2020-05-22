using System;
using System.Threading.Tasks;


namespace Padrao_MVVM
{
    class Program
    {
        private static void BuscarProduto(string nome)
        {
            ProdutoViewModel produtoViewModel = new ProdutoViewModel();

            produtoViewModel.Criterio = nome;
            produtoViewModel.Procurar().Wait();

            Produto produto = produtoViewModel.Produtos[0];

            Console.WriteLine("Produto: " + produto.Nome);
            Console.WriteLine("Preco: " + produto.Preco);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BuscarProduto("camisa");
            BuscarProduto("Sapato");

            Console.Read();
        }
    }
}
