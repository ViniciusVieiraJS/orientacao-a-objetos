contaBancaria conta = new contaBancaria();

conta.Titular = "Vinicius Vieira";
conta.Saldo = 143.23;

Console.WriteLine($"Titular: {conta.Titular}\n Saldo: {conta.Saldo}R$");

conta.ExibirContaBancaria();

Carro car = new Carro();
car.Fabricante = "Fiat";
car.Modelo = "Uno";
car.Velocidade = 130;
car.AnoFabricação = 2040;
car.QuantidadePortas = 4;
Console.WriteLine(car.DescricaoDetalhada);

Produto product = new Produto();
product.Marca = "Nestlé";
product.Nome = "Sonho de Valsa";
product.Estoque = -1;
product.Preco = -30;
Console.WriteLine(product.DetalheEstoque);

car.ExibirInformacoes();

Soma sum = new Soma();
Console.WriteLine(sum.Somar);

