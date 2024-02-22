class CatalogoJogos
{
    private List<Jogo> jogos = new List<Jogo>();
    public CatalogoJogos(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => jogos.Sum(j => j.Duracao);

    public void AdicionarJogo(Jogo jogo)
    {
        jogos.Add(jogo);
    }

    public void ExibirJogos()
    {
        Console.WriteLine($"Lista de jogos no {Nome}:");
        foreach(var jogo in jogos)
        {
            Console.WriteLine($"Nome do jogo: {jogo.Nome}\nDuração do jogo: {jogo.Duracao} minutos\n\nDuração total do catálogo: {DuracaoTotal}");
        }
    }
}