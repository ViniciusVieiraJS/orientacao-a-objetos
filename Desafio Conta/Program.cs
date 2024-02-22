/*Titular titularCaixa = new Titular();
titularCaixa.Nome = "Vinicius Vieira";
titularCaixa.Endereco = "Ângelo de Cândia, 1432";
titularCaixa.CEP = "03958000";

Conta contaCaixa = new Conta();
contaCaixa.Titular = titularCaixa;
contaCaixa.Agencia = "001";
contaCaixa.Saldo = 145.45;
contaCaixa.NumeroConta = "00132424";
contaCaixa.Limite = 400;
Console.WriteLine($"{contaCaixa.Informacoes}");
*/
using System.Linq;

void Menu() { 
Console.WriteLine("Clique 1 para adicionar um novo produto");
Console.WriteLine("Clique 2 para ver o estoque de um produto");
string opcaoEscolhida = Console.ReadLine();
int opcaoEscolhidaNumero = int.Parse(opcaoEscolhida);

switch (opcaoEscolhidaNumero)
{
    case 1:
        CriarNovoEstoque();
        break;
            case 2:
            
      

}
    

}


List<Estoque> estoqueRegistrado = new List<Estoque>();

void CriarNovoEstoque(){
    

    Estoque estoque1 = new Estoque();
    Console.WriteLine("Insira o nome do produto");
    string nomeDoItem = Console.ReadLine();
    estoqueRegistrado.Add(nomeDoItem);
    estoque1.NomeItem = nomeDoItem;
    Console.WriteLine("Insira o preço do produto");
    string precoItem = Console.ReadLine()!;
    double precoItemDouble = double.Parse(precoItem);
    estoque1.Preco = precoItemDouble;
    Console.WriteLine("Insira a quantidade em estoque");
    string quantidadeItem = Console.ReadLine();
    int quantidadeItemInt = int.Parse(quantidadeItem);
    estoque1.Quantidade = quantidadeItemInt;
    estoqueRegistrado.Add(estoque1);
   

    Console.WriteLine($"Item {nomeDoItem} cadastrado com sucesso");

    Thread.Sleep(5000);
    Console.Clear();
    Menu();
}
void MostrarEstoque()
{
    Console.WriteLine("Qual item você deseja verificar?");
    string item = Console.ReadLine()!;
    if (estoqueRegistrado.(item)) ;
}



Menu();