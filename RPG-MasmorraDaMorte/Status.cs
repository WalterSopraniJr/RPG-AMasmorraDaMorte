using System;

public abstract class Status
{


    public string Nome { get; set; }
    public int Energia { get; set; }
    public int Habilidade { get; protected set; }

    Random dado = new Random();

    public Status(string nome)
    {
        Nome = nome;
        GeraAtributos();
    }

    public abstract void GeraAtributos();




}