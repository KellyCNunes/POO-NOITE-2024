using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        private int numero;
        private string titular;
        private double saldo;

        public int Numero //propriedade -->metodos(função) de encapsulamento(get e set) letra maiuscula 
        {
            set {
                this.numero = value;
            }
            get{
                return this.numero;
            }
        }
        //propfull
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        
        

        //public void SetNumero (int numeroConta) //alterardados
        //{
           // numero = numeroConta;
        //}
        //public int GetNumero() //buscarnumeros
       // {
          //  return numero;
        //}
    }
}

//alt+shift+f -- formatação