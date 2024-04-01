using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgragacaoArrayVenda
{
    public class Venda
    {
        public Comprador comp { get; set; }
        public Vendedor vend { get; set; }
        public List<Produto> vetProd { get; set; }

        public void Mostrar() 
        {
            Console.WriteLine("Comprador: " + comp + "\tVendedor: " + vend);
        }

    }
}