using System;

public class Personagem : Status
{

    Random dado = new Random();

    public int Sorte { get; protected set; }
    public int ouro;
    //public string[] joias = {"esmeralda", "diamante"};

    public Personagem(string nome) : base(nome)
    {
        int Sorte = dado.Next(1, 7) + 6;
    }
    


    //int energiaTotal = jogador.energia = dado.Next(1, 7) + 6;
    //int habilidadeTotal = jogador.habilidade = dado.Next(1, 7) + 6;
    //int sorteTotal = jogador.sorte = dado.Next(1, 7) + 6;


    

}