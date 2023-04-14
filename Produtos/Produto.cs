using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double valorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }

        
        public override string ToString()
        {
            return Nome 
            + ", R$" 
            + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " 
            + Quantidade 
            + " unidades, Total: R$"
            + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}