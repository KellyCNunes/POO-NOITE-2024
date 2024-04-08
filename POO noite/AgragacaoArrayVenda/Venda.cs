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
         
        public void calcularComissao()
        {
            double totalVenda = 0;
            foreach (Produto p in vetProd)
            {
                totalVenda += p.Preco;
            }

            double comissao = totalVenda * 0.02;
            Console.WriteLine($"Comissão: {comissao}");
        }

        public void debitarCompra()
        {
            double totalVenda = 0;
            foreach (Produto p in vetProd)
            {
                totalVenda += p.Preco;
            }

            double verba = 1600; // verba

            verba -= totalVenda;
            Console.WriteLine($"Verba restante após compra: {verba}");
     
        }
    } 
}
