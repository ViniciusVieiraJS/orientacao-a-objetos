/*Musica musica1 = new Musica();
// Se você quer usar uma classe de um outro arquivo desde que o tipo esteja "public"
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

Console.WriteLine($"Nome da música {musica1.nome}");
Console.WriteLine($"Nome do artista {musica1.artista}");

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;

Console.WriteLine($"Nome da música {musica2.nome}");
Console.WriteLine($"Nome do artista {musica2.artista}");

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();*/


Banda lp = new Banda("Linkin Park");
/*lp.Nome = "Linkin Park";*/


Album albumDoLP = new Album("Meteora");
/*albumDoLP.Nome = "Meteora";*/



Musica meteora1 = new Musica(lp, "Faint")
{
    Duracao = 3,
    Disponivel = true,
};
/*meteora1.Nome = "Faint";
*/
Musica meteora2 = new Musica(lp, "Numb")
{
    Duracao = 4,
    Disponivel = true,
};
/*meteora2.Nome = "Numb";*/

Musica meteora3 = new Musica(lp, "Lying From You")
{
    Duracao = 3,
    Disponivel = true,

};
/*meteora3.Nome = "Lying From You";*/
albumDoLP.AdicionarMusica(meteora1);
albumDoLP.AdicionarMusica(meteora2);
albumDoLP.AdicionarMusica(meteora3);
meteora3.ExibirFichaTecnica();
lp.AdicionarAlbum(albumDoLP);
lp.ExibirDiscografia();
albumDoLP.ExibirMusicasAlbum();

Titular titular1 = new Titular("Vinicius", "422.914.178-51", "Rua Centro");
Conta nubank1 = new Conta(titular1, 10, 110, 11000, 1010101);
Console.WriteLine(nubank1.Informacoes);
