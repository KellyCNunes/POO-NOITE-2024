
using AgragacaoArrayVenda;

Vendedor ve = new Vendedor(0.02);
Comprador co = new Comprador(2000);
Venda v1 = new Venda();
v1.vend = ve;
v1.comp = co;

v1.vetProd = new List<Produto>();

//soma = 0;

for(int i=0; i<3; i++)
{
    Produto p1 = new Produto();
    System.Console.WriteLine("Informe o nome: ");
    p1.Nome = Console.ReadLine();
    System.Console.WriteLine("Informe o preço: ");
    p1.Preco = Console.ReadLine();
    System.Console.WriteLine("Informe o código: ");
    p1.Codigo = Console.ReadLine();

    v1.vetProd.Add(p1);
}

//double soma = 0;
//for (int i = 0; i < v1.Length; i++)




v1.Mostrar();
foreach(Venda v in v1.vetProd)  //foreach 
    v.Mostrar();