using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_MasmorraDaMorte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEM VINDO À MASMORRA DA MORTE!");
            Console.WriteLine();

            Random dado = new Random();
            Textos texto = new Textos();

            Personagem jogador = new Personagem();
            jogador.nome = "Drako Drachevsky";
            int energiaTotal = jogador.energia = dado.Next(1,7) + 6;
            int habilidadeTotal = jogador.habilidade = dado.Next(1,7) + 6;
            int sorteTotal = jogador.sorte = dado.Next(1,7) + 6;

            Console.WriteLine("__________________________________________");
            Console.WriteLine("ATRIBUTOS DO PERSONAGEM");
            Console.WriteLine("Nome do Herói: " + jogador.nome);
            Console.WriteLine("Energia: " + jogador.energia + "/" + energiaTotal);
            Console.WriteLine("Habilidade: " + jogador.habilidade + "/" + habilidadeTotal);
            Console.WriteLine("Sorte: " + jogador.sorte + "/" + sorteTotal);
            Console.WriteLine("__________________________________________");


            Console.WriteLine();
            Console.WriteLine("Sua jornada começa aqui. Tecle enter para iniciar...");
            Console.WriteLine();

            Console.WriteLine(texto.intro);
            Console.WriteLine("__________________________________________");
            Console.WriteLine(texto.intro);
            Console.WriteLine("__________________________________________");

            jogador.energia -= 10;
            jogador.habilidade -= 3;
            jogador.sorte -= 1;

            Console.WriteLine("__________________________________________");
            Console.WriteLine("ATRIBUTOS DO PERSONAGEM");
            Console.WriteLine("Nome do Herói: " + jogador.nome);
            Console.WriteLine("Energia: " + jogador.energia + "/" + energiaTotal);
            Console.WriteLine("Habilidade: " + jogador.habilidade + "/" + habilidadeTotal);
            Console.WriteLine("Sorte: " + jogador.sorte + "/" + sorteTotal);
            Console.WriteLine("__________________________________________");

            

            Console.WriteLine("__________________________________________");
            Console.WriteLine("Fim de jogo. (por enquanto)");
            Console.Read();

        }
    }
}
