using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayProduto
{
    public class Produto
    {
        //declaração dos atributos
        public int codigo;
        public int quantidade;
        public string nome;
        public double preco;

        //declaração dos métodos
        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {codigo} Quantidade: {quantidade} \tNome: {nome} \tPreço: {preco:c}");   //:c para reduzir as casa decimais em 2 casas
        }
        public void CalcularAumento(double porcentagem)
        {
            preco = preco + (preco * porcentagem/100);
            //preco += preco * porcentagem/100;
        }
    

    public double ValorTotalEmEstoque()
    {
        double totalEstoque = quantidade * preco;
        return totalEstoque;
    }

    public void RemoverEstoque (int qtdeVendida)
    {
        quantidade = quantidade  - qtdeVendida;
    }
    }

}


//dados do produto
//entrada no estoque + dados
//remover produto + dados