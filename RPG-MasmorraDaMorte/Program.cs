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
            Random dado = new Random();
            Textos texto = new Textos();

            Console.WriteLine("BEM VINDO À MASMORRA DA MORTE! \n \n");
            Console.ReadLine();

            CriaPersonagem();

            StatusHeroi();

            Personagem jogador = new Personagem("Drako");

            Console.WriteLine("--------HERÓI--------");
            Console.WriteLine("Nome: " + jogador.Nome);
            Console.WriteLine("Energia: " + jogador.Energia);
            Console.WriteLine("Habilidade: " + jogador.Habilidade);
            Console.WriteLine("Sorte: " + jogador.Sorte);
            Console.WriteLine("---------------------");




            Console.WriteLine(texto.fim);
            Console.WriteLine();
            Console.ReadLine();

        }

        public static void CriaPersonagem()
        {

            Personagem jogador = new Personagem("Drako");


        }

        public static void StatusHeroi()
        {
            Personagem jogador = new Personagem("Drako");

            Console.WriteLine("--------HERÓI--------");
            Console.WriteLine("Nome: " + jogador.Nome);
            Console.WriteLine("Energia: " + jogador.Energia);
            Console.WriteLine("Habilidade: " + jogador.Habilidade);
            Console.WriteLine("Sorte: " + jogador.Sorte);
            Console.WriteLine("---------------------");

        }


    }
}
