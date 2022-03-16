using System.Globalization;


namespace ProdutoPOO
{
    class Produto
    {
        #region Atributos
        public string Nome;
        public double Preco;
        public int Quantidade;
        #endregion

        #region Métodos
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos()
        {

        }
        public void RemoverProdutos()
        {

        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2",CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        #endregion
    }
}
