using ComposicaoNotaFiscal;

ItemNotaFiscal item1 = new ItemNotaFiscal(10);
ItemNotaFiscal item2 = new ItemNotaFiscal(5);


NotaFiscal nf = new NotaFiscal(1, "01/04/2024");
nf.AdicionarItens(item1);
nf.AdicionarItens(item2);
foreach (ItemNotaFiscal itens in nf.VetItens)
    System.Console.WriteLine("Quantidade: "+ itens.Quantidade);
nf = null;