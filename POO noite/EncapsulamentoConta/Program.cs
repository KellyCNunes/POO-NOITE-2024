// See https://aka.ms/new-console-template for more information
using EncapsulamentoConta;

Conta c1 = new Conta();
c1.Numero = 12; //set
Console.WriteLine("Número: " + c1.Numero); //get
//if(c1.Numero == 1000)


c1.Titular = "Fatec"; //set
c1.Saldo = 1050; //set
Console.WriteLine("titular: " + c1.Titular); //get
Console.WriteLine("Saldo: " + c1.Saldo); //get
