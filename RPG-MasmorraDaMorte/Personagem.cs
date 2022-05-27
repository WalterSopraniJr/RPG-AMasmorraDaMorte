using System;

public class Personagem : Status
{

    Random dado = new Random();

    public int Sorte { get; protected set; }
    public int ouro;
    //public string[] joias = {"esmeralda", "diamante"};

    public Personagem(string nome) : base(nome)
    {
        GeraAtributos();
    }

    public override void GeraAtributos()
    {
        int Energia = dado.Next(1, 13) + 6;
        int Sorte = dado.Next(1, 7) + 6;

        int energiaTotal = Energia = dado.Next(1, 7) + 6;
        int habilidadeTotal = Habilidade = dado.Next(1, 13) + 6;
        int sorteTotal = Sorte = dado.Next(1, 7) + 6;
    }

    

    //System.Random dado = new Random();

    // public int rolaDado(Personagem atributo ,int quantidadeDeLados)
    //{
    //    return atributo.dado.Next(1,quantidadeDeLados);
    //}



}