//função main()

using AgregacaoConta;
//tipo Endereco(clesse)
Endereco end = new Endereco("Rua", 83 ,"PP");             //end objeto
Cliente cli = new Cliente("ana", "111", "1111-11");
cli.Ender = end; //agregando o endereço no cli           //ender atributo


Conta c1 = new Conta();
c1.Numero=1;
c1.Titular = cli; //agregando o cliente a conta c1
c1.Saldo = 100;
System.Console.WriteLine("Número da conta: " + c1.Numero);
System.Console.WriteLine("Saldo: " + c1.Saldo);
System.Console.WriteLine("Nome: " + c1.Titular.Nome);
System.Console.WriteLine("Rg: " + c1.Titular.Rg);
System.Console.WriteLine("Cpf: " + c1.Titular.Cpf);
Console.WriteLine("Endereço: " + c1.Titular.Ender.Logradouro);
System.Console.WriteLine("Número: " + c1.Titular.Ender.Numero);
System.Console.WriteLine("Cidade: " + c1.Titular.Ender.Cidade);