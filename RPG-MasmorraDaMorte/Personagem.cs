using System;

public class Personagem : Status
{

    Random dado = new Random();

    public int Sorte { get; protected set; }
    public int ouro;
    public int energiaTotal;
    public int habilidadeTotal;
    public int sorteTotal;
    //public string[] joias = {"esmeralda", "diamante"};

    public Personagem(string nome) : base(nome)
    {
    }

    public override void GeraAtributos()
    {
        energiaTotal = Energia = dado.Next(1, 13) + 6;
        habilidadeTotal = Habilidade = dado.Next(1, 13) + 6;
        sorteTotal = Sorte = dado.Next(1, 7);
    }


}