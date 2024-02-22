class Titular
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string CEP { get; set; }
}
class Conta
{
    public Titular Titular { get; set; }
    public string Agencia { get; set;}
    public double _saldo;
    public double Saldo { get => _saldo; 
        set 
        {
            if(value >= 145.45)
            {
                Console.WriteLine("Funcionou");
                _saldo = value;
            }
            else
            {
                _saldo = value;
            }
        } 
    }


    public double Limite { get; set;}
    public string NumeroConta { get; set; }

    public string Informacoes => $"Titular: {Titular.Nome}, \n Agência: {Agencia}, \n Saldo: {Saldo} \n Limite: {Limite} \n Numero da Conta: {NumeroConta} ";

    
}


class Estoque
{
    
    public string nomeItem;
    public string NomeItem { get; set; }
    public double preco;
    public double Preco { get; set; }
    public int quantidade;
    public int Quantidade {  get; set; }




}
