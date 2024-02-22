Jogo jogo1 = new Jogo("Genshin Impact", "RPG")
{
    Duracao = 4
};
Jogo jogo2 = new Jogo("League of Legends", "MOBA")
{
    Duracao = 4
};
CatalogoJogos cat1 = new CatalogoJogos("Catalogo do Vini");

cat1.AdicionarJogo(jogo1);
cat1.AdicionarJogo(jogo2);

cat1.ExibirJogos();