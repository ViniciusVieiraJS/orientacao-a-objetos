class Titular
{
    public Titular(string nome, string cpf, string endereco)
    {




    }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Endereco { get; set; }
}

class Conta
    {
        public Conta(Titular titular, int agencia, int numeroDaConta, double saldo, double limite)
        {
            Titular = titular;
            Agencia = agencia;
            NumeroDaConta = numeroDaConta;
            Saldo = saldo;
            Limite = limite;

        }
        public Titular Titular { get; }
        public int Agencia { get; }
        public int NumeroDaConta { get; }
        public double Saldo { get; }
        public double Limite { get; }

        public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";
    }


