using System.Globalization;

namespace Encapsulamento {
    class Program {
        static void Main(string[] args) {
            Produto produto = new Produto("TV", 500.00, 10);
            produto.Nome = "TV";
            produto.AdicionarProduto(10);

            Console.WriteLine(produto.ToString());
        }
    }
}