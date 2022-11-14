using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYG_Projet2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pendu pendu;
            int lettresManquantes;
            ConsoleKeyInfo key;

            Pendu.AfficherRegles();
            do
            {
                pendu = new Pendu();
                do
                {
                    System.Console.Clear();
                    pendu.PenduAffichage();
                    pendu.EntrerNewChar();
                    lettresManquantes = pendu.GetLettresManquantes();
                } while (lettresManquantes > 0 && pendu.GetFauxCharUtilisesCount() < 11);

                System.Console.Clear();
                pendu.PenduAffichage();
                System.Console.WriteLine();
                if (lettresManquantes == 0)
                {
                    System.Console.WriteLine("Felicitations ! Vous avez trouve le mot " + pendu.GetMot() + " ! Voulez-vous recommencer ? Y/n");
                }
                else
                {
                    System.Console.WriteLine("Dommage ! Le mot etait " + pendu.GetMot() + ". Voulez-vous recommencer ? Y/n");
                }

                do
                {
                    key = System.Console.ReadKey();
                } while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Y && key.Key != ConsoleKey.N);    // Continue à lire les touches entrées tant qu'elles ne sont pas Y, N ou Entrer
            } while (key.Key == ConsoleKey.Y || key.Key == ConsoleKey.Enter);   // Si la touche entrée est Y ou Entrer, reprend la boucle à 0 et crée une nouvelle partie. Quitte la boucle et termine le programme si N est appuyé.
        }
    }
}
