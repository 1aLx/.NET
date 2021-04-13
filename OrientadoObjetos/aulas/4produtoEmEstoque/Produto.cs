using System.Globalization;

namespace _4produtoEmEstoque
{
    public class Produto
    {
        //Atributos.
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        //Usando a variavel qte substituindo em quantity, porém, adicionando uma quantidade para ser somada.
        //void = Não terá que retornar o valor da saida mais sim alterar um atributo (Quantidade).
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        //Usando a variavel qte substituindo em quantity, porém, sendo subtraída para demonstar um novo valor à saída de dados.
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        //Criando um m�todo para saida de dados (override string ToString())
        //ToString() Converte o objeto para string.
        //override = indica que esta opera��o vem de outra classe.

        public override string ToString()
        {

            return
            Nome +
            ", R$" +
            Preco.ToString("F2", CultureInfo.InvariantCulture) +
            ", " +
            Quantidade +
            "unidades " +
            ", Valor total: R$" +
            ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}