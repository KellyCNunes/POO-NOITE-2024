//função main()

using AgregacaoConta;
//tipo Endereco(clesse)
Endereco end = new Endereco("Rua","83","PP");             //end objeto
Cliente cli = new Cliente("ana", "111", "1111-11");
cli.Ender = end; //agregando o endereço no cli           //ender atributo


Conta c1 = new Conta();
c1.Numero=1;
c1.Titular = cli; //agregando o cliente a conta c1
c1.Saldo = 100;
Console.WriteLine(c1.Titular.Logradouro);