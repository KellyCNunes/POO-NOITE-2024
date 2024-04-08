
using AgragacaoArrayVenda;

Vendedor ve = new Vendedor();
ve.Mostrar();
Comprador co = new Comprador(2000);
co.Mostrar();
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

    System.Console.WriteLine($"Informe o preço {i + 1}: ");
    p1.Preco = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("Informe o código: ");
    p1.Codigo = Convert.ToInt32(Console.ReadLine());
    v1.vetProd.Add(p1);


}
    
    foreach(Produto p in v1.vetProd)
          p.Mostrar();

     v1.calcularComissao();
     v1.debitarCompra();





   