using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgragacaoArrayVenda
{
    public class Vendedor
    {
        public double Comissao { get; set; }
        public Vendedor(double comissao)
        {
            Comissao = comissao;
        }
        public void Mostrar() 
        {
            Console.WriteLine("Comissão: " + Comissao);
        }
    }
}