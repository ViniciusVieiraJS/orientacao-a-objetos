Musica musica1 =  new Musica();
// Se você quer usar uma classe de um outro arquivo desde que o tipo esteja "public"
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

/*Console.WriteLine($"Nome da música {musica1.nome}");
Console.WriteLine($"Nome do artista {musica1.artista}");*/

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;

/*Console.WriteLine($"Nome da música {musica2.nome}");
Console.WriteLine($"Nome do artista {musica2.artista}");*/

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
