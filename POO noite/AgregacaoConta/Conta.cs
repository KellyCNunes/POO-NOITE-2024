using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtoraluno
{
    public class Conta
    {
        public int Numero {get; set;}
        public Cliente Titular{get; set;} //agregação (atributo de outra classe)
        public double Saldo {get; set;}
    }
}