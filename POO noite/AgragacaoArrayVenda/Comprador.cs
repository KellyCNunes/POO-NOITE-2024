using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgragacaoArrayVenda
{
    public class Comprador
    {
        public double Verba { get; set; }
        public Comprador(double verba)
        {
            Verba = verba;
        }

        public void Mostrar() 
        {
            Console.WriteLine("Verba: " + Verba);
        }
    }

    

    

}

// Criar as classes de acordo com o trecho de diagrama de classe anexo
// A comissão do vendedor é gerada referente a 2% do preço do produto vendido
// Na instância de um comprador, conceda um valor de verba
// Quando realizar uma venda subtraia o valor da verba
// É para ser realizada mais de uma venda, para usar o vetor/List de produtos
// No cadastro de produtos, o código inicial é 500
// Use encapsulamento completo (com tratamento de valores digitados) para os atributos da classe Produto
// Realizar instâncias necessárias para testar as classes 