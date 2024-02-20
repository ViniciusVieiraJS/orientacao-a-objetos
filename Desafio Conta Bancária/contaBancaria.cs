using System.Threading.Channels;

class contaBancaria
{
    public int NumIndicador { get; set; }
    public string Titular {  get; set; }
    public double Saldo {  get; set; }
    public string Senha { get; set; }

    public void ExibirContaBancaria()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo}");
    }
}

class Carro
{
    public string Fabricante {  get; set; }
    public string Modelo {  get; set; }
    public int ano;
    public int QuantidadePortas { get; set; }
    public int Velocidade {  get; set; }
    public int AnoFabricação { 
        get => ano; 
        set 
        {
            if (value < 1960 || value > 2023)
            {
                Console.WriteLine("Ano inválido. Insira um ano válido");
            }
            else
            {
                ano = value;
            }
        }
             }
    public string DescricaoDetalhada => $"Fabricante: {Fabricante} \n Modelo: {Modelo} \n Ano: {AnoFabricação}";

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Informações do carro: {Fabricante} {Modelo}, {QuantidadePortas} portas, {ano}");
    }

    public void acelerar()
    {
        Console.WriteLine("Acelerando...");
        if (Velocidade < 100)
        {
            Velocidade = Velocidade + 5;
        }
    }

    public void frear()
    {
        Console.WriteLine("Freando...");
        if (Velocidade > 0)
        {
            Velocidade = Velocidade - 5;
        }
    }

    public void buzinar()
    {
        Console.WriteLine("Bi Bi");
    }
}

class Produto
{
    private int estoque;
    private double preco;
    public string Nome { get; set; }
    public string Marca { get; set; }
    public double Preco 
    { get => preco;
             
        set
        {
            if(value < 0)
            {
                preco = 10;
            }
            else
            {
                preco = value;
            }
        }
    }
    public int Estoque { 
        get => estoque;
        set
        {
            if(value < 0)
            {
                estoque = 0;
            }
            else
            {
                estoque = value;
            }
        }
    }
    public string DetalheEstoque => $"Estoque: {Estoque} | Preço: {Preco} | Nome: {Nome} | Marca: {Marca}";

    
    
}