using System;
using System.Globalization;

namespace Encapsulamento
{
    class Produto
    {
        // Atributos
        private string _nome;
        private double _preco;
        private int _quantidade;

        // Construtores
        public Produto()
        {
            _quantidade = 5;
        }
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        // Properties
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

        // Métodos
        public double QuantidadeTotalEmEstoque()
        {
            return _quantidade * _preco;
        }
        public int AdicionarProduto(int quantidade)
        {
            return _quantidade += quantidade;
        }
        public int RemoverProduto(int quantidade)
        {
            return _quantidade -= quantidade;
        }

        // ToString
        public override string ToString()
        {
            return $"Dados do produto: {_nome}, " +
                   $"R$ {_preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
                   $"{_quantidade} unidades, " +
                   $"Total: {QuantidadeTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
