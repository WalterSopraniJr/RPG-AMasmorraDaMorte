using System;

public class Monstro : Status
{

    Random dado = new Random();


    public int energiaTotal;
    public int habilidadeTotal;

    public Monstro(string nome) : base(nome)
    {
    }

    public override void GeraAtributos()
    {
        energiaTotal = Energia = dado.Next(1, 13) + 11;
        habilidadeTotal = Habilidade = dado.Next(1, 13) + 11;
    }


}