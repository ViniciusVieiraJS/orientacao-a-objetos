class Jogo
{

    public string Nome { get; }
    public string Genero { get; }
    public int Duracao { get; set; }
    public Jogo(string nome, string genero)
    {
        Nome = nome;
        Genero = genero;
    }
}