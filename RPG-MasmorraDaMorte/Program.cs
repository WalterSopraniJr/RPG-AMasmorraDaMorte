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

            Personagem jogador = new Personagem("Drako");

            Monstro manticora = new Monstro("Mantícora");
            StatusMonstro(manticora);

            //Console.WriteLine("BEM VINDO À MASMORRA DA MORTE! \n");
            //Console.WriteLine(texto.intro);
            //Console.WriteLine("MENU\nDigite: R para regras, ou qualquer tecla para iniciar.");
            //string opcoes = Console.ReadLine();
            

            //if (opcoes == "R" || opcoes == "r")
            //{
            //    Console.WriteLine("REGRAS\n" + "Digite:\n 1 - Batalhas\n 2 - Escolhas de caminho\n 3 - Status");
            //    string op = Console.ReadLine();
            //    Menu(op);
            //}


            //Console.Clear();

            //StatusHeroi(jogador);

            //Console.WriteLine(texto.introducao);

            //Console.WriteLine(texto._1);
            //_ = Console.ReadLine();


            Console.WriteLine(texto.fim);
            Console.WriteLine();
            Console.ReadLine();

        }

        public static void Menu(string op)
        {
            switch (op)
            {
                case ("1"):
                    Console.WriteLine("\nBATALHAS");
                    Console.ReadLine();
                    break;
                case ("2"):
                    Console.WriteLine("\nCAMINHOS");
                    Console.ReadLine();
                    break;
                case ("3"):
                    Console.WriteLine("\nSTATUS");
                    Console.ReadLine();
                    break;


            }
        }

        public static void StatusHeroi(Personagem jogador)
        {
            Console.WriteLine(
                "--------HERÓI--------\n" + "Nome: " + jogador.Nome + 
                "\nEnergia: " + jogador.Energia + "/" + jogador.energiaTotal + 
                "\nHabilidade: " + jogador.Habilidade + "/" + jogador.habilidadeTotal + 
                "\nSorte: " + jogador.Sorte + "/" + jogador.sorteTotal + 
                "\n---------------------");
        }

        public static void StatusMonstro(Monstro monstro)
        {
            Console.WriteLine(
                "--------HERÓI--------\n" + "Nome: " + monstro.Nome +
                "\nEnergia: " + monstro.Energia + "/" + monstro.energiaTotal +
                "\nHabilidade: " + monstro.Habilidade + "/" + monstro.habilidadeTotal +
                "\n---------------------");
        }

        public static void Batalha(Personagem jogador, Monstro monstro)
        {

        }
    }
}
