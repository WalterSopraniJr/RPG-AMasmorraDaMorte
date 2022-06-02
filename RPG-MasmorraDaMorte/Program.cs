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
            Personagem jogador = new Personagem("Drako");
            Random dado = new Random();
            Textos texto = new Textos();

            Console.WriteLine("BEM VINDO À MASMORRA DA MORTE! \n \n");
            Console.ReadLine();

            StatusHeroi(jogador);



            Console.WriteLine(texto.fim);
            Console.WriteLine();
            Console.ReadLine();

        }

     

        public static void StatusHeroi(Personagem jogador)
        {

            Console.WriteLine("--------HERÓI--------");
            Console.WriteLine("Nome: " + jogador.Nome);
            Console.WriteLine("Energia: " + jogador.Energia + "/" + jogador.energiaTotal);
            Console.WriteLine("Habilidade: " + jogador.Habilidade + "/" + jogador.habilidadeTotal);
            Console.WriteLine("Sorte: " + jogador.Sorte + "/" + jogador.sorteTotal);
            Console.WriteLine("---------------------");

        }


    }
}
