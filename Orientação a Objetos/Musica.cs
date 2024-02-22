using System.Collections.Concurrent;

class Musica
{
    public Musica(Banda artista, string nome) //argumento do tipo banda
    {
        Artista = artista;
        Nome = nome;
    }
// deixar public para que o Program.cs possa usar esses atributos
    public string Nome { get; }
    public Banda Artista { get; } 
    public int Duracao {  get; set; }   
    public bool Disponivel {  get; set; }
    // propriedade SOMENTE LEITURA (get) você utiliza lambda "=>"
    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista}.";
    
    // get = leitura | set = escrita || o atributo vira uma propriedade (pascal case)
    // além de atributos, você também pode criar métodos

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }

}