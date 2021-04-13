using System;
using System.Globalization;

namespace _4produtoEmEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler os dados de um produto em estoque (nome, preço e
            quantidade no estoque). Em seguida: 
            -Mostrar os dados do produto (nome, preço, quantidade, no estoque, valor total
            no estoque)
            -Realizar um entrada no estoque e mostrar novamente os dados do produto.
            -Realizar uma saída no estoque e mostrar novamente os dados do produto. 
            -Utilizar um diagrama UML. (Imagem na pasta) */

            Produto x;
            x = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");

            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();

            Console.Write("Preço: R$");
            x.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            x.Quantidade = int.Parse(Console.ReadLine());

            Console.Write($"Dados do produto: {x}\n");

            //Criando uma variavel que irá adicionar um valor inteiro no atributo Quatidade e apresentar um novo valor.
            Console.Write("Informe o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());

            //Pegando a nova variável int qte e sobrescrevendo a mesma na varaivel de parametro de entrada da função (quantidade)
            //Neste caso, ela irá somar a quantidade armazenada no atributo Quantidade e 
            x.AdicionarProdutos(qte);

            //Informando os dados atualizados.
            Console.Write($"Dados do produto: {x}\n");

            //usando a mesma variavel qte para informar um novo valor para subtrair o atributo Quantidade.
            Console.Write("Informe um número de produtos para ser retirado do estoque: ");
            qte = int.Parse(Console.ReadLine());

            //Removendo produtos do atributo.
            x.RemoverProdutos(qte);

            //Dados atualizados.
            Console.Write($"Dados do produto: {x}");
        }
    
    }
}
