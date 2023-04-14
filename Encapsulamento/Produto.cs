using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos
{
    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public double preco2 { get; private set; }

        public Produto()
        {
            _quantidade = 10;
        }


        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
        }

        public string GetNome()
        {
            return _nome;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public string Nome 
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double valorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantity)
        {
            _quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            _quantidade -= quantity;
        }


        public override string ToString()
        {
            return _nome
            + ", R$"
            + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
            + _quantidade
            + " unidades, Total: R$"
            + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}