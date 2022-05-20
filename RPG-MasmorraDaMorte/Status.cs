using System;

public abstract class Status
{


    public string Nome { get; set; }
    public int Energia { get; protected set; }
    public int Habilidade { get; protected set; }

    Random dado = new Random();

    public Status(string nome)
    {
        int Energia = dado.Next(1, 7) + 6;
        int Habilidade = dado.Next(1, 7) + 6;

    }

    


}