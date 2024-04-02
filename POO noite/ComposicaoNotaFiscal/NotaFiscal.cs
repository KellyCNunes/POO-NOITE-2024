using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNF { get; set; }
        public string Data { get; set; }

        public List <ItemNotaFiscal> VetItens { get; set; }

        public  NotaFiscal (int nf, string data)
        { 
            NumeroNF = nf;
            Data = data;
            VetItens = new List<ItemNotaFiscal>();

        }

        public void AdicionarItens(ItemNotaFiscal itens)    //itemnotafiscal --- tipo 
        {
            VetItens.Add(itens);
        }
    }


}