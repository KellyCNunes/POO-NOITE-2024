using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgragacaoArrayVenda
{
    public class Vendedor
    {
        public double Comissao { get; set; }
        public void Mostrar() 
        {
            Console.WriteLine("Comissão: " + Comissao);
        }
    }
}