using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgragacaoArrayVenda
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public void Mostrar() 
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tPreço: " + Preco);
        }
    }

}