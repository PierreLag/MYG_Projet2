using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYG_Projet2
{
    /// <summary>
    /// Gère l'affichage en console de commande du jeu du Pendu. Utilise un controlleur appelé PenduController pour effectuer les opérations en arrière plan.
    /// </summary>
    internal class Pendu
    {
        /// <summary>
        /// Controlleur qui gère la partie algorithmique de la partie de Pendu.
        /// </summary>
        private PenduController controller;

        /// <summary>
        /// Crée une instance de la partie de Pendu. Lors de la création de la partie, crée aussi son controlleur, qui va générer un mot à deviner au hasard.
        /// </summary>
        public Pendu()
        {
            controller = new PenduController();
        }

        /// <summary>
        /// Méthode permettant d'afficher les règles du jeu du Pendu. Attend que le joueur appuie sur une touche du clavier afin de continuer le programme. Nettoie l'affichage une fois la méthode terminée.
        /// </summary>
        public static void AfficherRegles()
        {
            System.Console.WriteLine("//////////////////////////////////////////////");
            System.Console.WriteLine("                   Pendu                      ");
            System.Console.WriteLine("//////////////////////////////////////////////");
            System.Console.WriteLine();

            System.Console.WriteLine("Regles du jeu : Un mot choisi au hasard va");
            System.Console.WriteLine("     etre selectionne a chaque partie. Ton but");
            System.Console.WriteLine("     est d'entrer des lettres afin de");
            System.Console.WriteLine("     decouvrir le mot cache, avant que le");
            System.Console.WriteLine("     bonhomme soit pendu apres trop d'erreurs.");
            System.Console.WriteLine();

            System.Console.WriteLine("Appuie sur une touche pour commencer la partie...");
            System.Console.ReadKey();
            System.Console.Clear();
        }

        /// <summary>
        /// Affiche chaque lettre contenue dans la liste des charactères utilisés, séparées par un espace. Retourne à la ligne une fois fini.
        /// </summary>
        public void DisplayCharacteresUtilises()
        {
            List<Char> characteresUtilises = controller.GetCharacteresUtilises();
            foreach (Char charactere in characteresUtilises)
            {
                System.Console.Write(charactere + " ");
            }
            System.Console.WriteLine();
        }

        /// <summary>
        /// Affiche dans la console le mot à trouver selon les lettres insérées étant correctes. Retourne à la ligne une fois fini.
        /// <para>Si une lettre a été correctement devinée, l'affiche telle quelle dans le mot. Affiche un _ à la place sinon.</para>
        /// </summary>
        public void MotAfficher()
        {
            String mot = controller.GetMot();
            List<Char> characteresUtilises = controller.GetCharacteresUtilises();

            foreach (Char charactere in mot)
            {
                if (characteresUtilises.Contains(charactere))
                {
                    Console.Write(charactere + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Gère l'affichage de la manche courrante de la partie de Pendu. Commence par un en-tête, puis le mot à trouver, les lettres utilisées, et enfin le pendu en tant que tel.
        /// </summary>
        public void PenduAffichage()
        {
            // Affichage de l'en-tête
            System.Console.WriteLine("//////////////////////////////////////////////");
            System.Console.WriteLine("                   Pendu                      ");
            System.Console.WriteLine("//////////////////////////////////////////////");
            System.Console.WriteLine();

            // Affichage du mot à trouver
            System.Console.Write("Mot a trouver : ");
            MotAfficher();

            // Affichage des lettres utilisées
            System.Console.Write("Lettres utilisees : ");
            DisplayCharacteresUtilises();
            int fauxCharUtilisesCount = controller.GetFauxCharacteresUtilisesCount();

            // Affichage du pendu
            if (fauxCharUtilisesCount >= 3) {
                System.Console.WriteLine("   ______________");
            } else {
                System.Console.WriteLine();
            }
            if (fauxCharUtilisesCount >= 2)
            {
                if (fauxCharUtilisesCount >= 4)
                {
                    if (fauxCharUtilisesCount >= 5)
                    {
                        System.Console.WriteLine("   |  /         |");
                        System.Console.WriteLine("   | /          |");
                        System.Console.WriteLine("   |/           |");
                    }
                    else
                    {
                        System.Console.WriteLine("   |  /");
                        System.Console.WriteLine("   | /");
                        System.Console.WriteLine("   |/");
                    }
                }
                else
                {
                    System.Console.WriteLine("   |");
                    System.Console.WriteLine("   |");
                    System.Console.WriteLine("   |");
                }
            } else
            {
                System.Console.WriteLine();
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
            if (fauxCharUtilisesCount >= 2)
            {
                if (fauxCharUtilisesCount >= 6)
                {
                    System.Console.WriteLine("   |           / \\");
                    System.Console.WriteLine("   |           \\_/");
                }
                else
                {
                    System.Console.WriteLine("   |");
                    System.Console.WriteLine("   |");
                }
            }
            else
            {
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
            if (fauxCharUtilisesCount >= 2)
            {
                if (fauxCharUtilisesCount >= 7)
                {
                    if (fauxCharUtilisesCount >= 8)
                    {
                        if (fauxCharUtilisesCount >= 9)
                        {
                            System.Console.WriteLine("   |           /|\\");
                            System.Console.WriteLine("   |          / | \\");
                        }
                        else
                        {
                            System.Console.WriteLine("   |           /|");
                            System.Console.WriteLine("   |          / |");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("   |            |");
                        System.Console.WriteLine("   |            |");
                    }
                }
                else
                {
                    System.Console.WriteLine("   |");
                    System.Console.WriteLine("   |");
                }
            }
            else
            {
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
            if (fauxCharUtilisesCount >= 1)
            {
                if (fauxCharUtilisesCount >= 2)
                {
                    if (fauxCharUtilisesCount >= 10)
                    {
                        if (fauxCharUtilisesCount == 11)
                        {
                            System.Console.WriteLine("   |           / \\");
                            System.Console.WriteLine("   |          /   \\");
                            System.Console.WriteLine("___|________________");
                        }
                        else
                        {
                            System.Console.WriteLine("   |           /");
                            System.Console.WriteLine("   |          /");
                            System.Console.WriteLine("___|________________");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("   |");
                        System.Console.WriteLine("   |");
                        System.Console.WriteLine("___|________________");
                    }
                }
                else
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine();
                    System.Console.WriteLine("____________________");
                }
            }
            else
            {
                System.Console.WriteLine();
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
        }

        /// <summary>
        /// Retourne le nombre de lettres erronées entrées par le joueur dans la partie courante.
        /// </summary>
        /// <returns>Le nombre entier de lettre erronées que le joueur à entré.</returns>
        public int GetFauxCharUtilisesCount()
        {
            return controller.GetFauxCharacteresUtilisesCount();
        }

        /// <summary>
        /// Demande au joueur quelle lettre il pense y avoir dans le mot, puis attend une valeur correcte.
        /// <para>Continue à demander au joueur de taper sur une touche de clavier tant que la valeur entrée n'est pas valide.</para>
        /// <para>Par exemple, si la lettre entrée a déjà été entrée auparavant, affiche un message d'erreur approprié, et continue d'attendre une nouvelle entrée.</para>
        /// </summary>
        public void EntrerNewChar()
        {
            Exception exception = new Exception();
            System.Console.WriteLine("Quelle lettre pensez-vous etre dans le mot ?");
            while (exception != null)
            {
                try
                {
                    controller.InputNewChar(System.Console.ReadKey().KeyChar);
                    exception = null;   // Si la ligne précédent ne crée pas d'erreur, alors l'exception précédente est remplacée par null, et le programme sort de la boucle.
                }
                catch (ArgumentNullException e)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("Veuillez entrer une lettre.");
                    exception = e;
                }
                catch (InvalidOperationException e)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("Cette lettre a deja ete entree.");
                    exception = e;
                }
                catch (ArgumentException e)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("Pas de chiffre ou characteres speciaux.");
                    exception = e;
                }
                catch (Exception e)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("Erreur inattendue. Recommencez.");
                    exception = e;
                }
            }
        }

        /// <summary>
        /// Retourne le mot choisi lors de la création de la partie.
        /// </summary>
        /// <returns>La valeur au format String du mot à deviner.</returns>
        public String GetMot()
        {
            return controller.GetMot();
        }

        /// <summary>
        /// Retourne le nombre de lettres qui restent à découvrir dans le mot à deviner. Si cette valeur vaut 0, alors le mot entier est découvert.
        /// </summary>
        /// <returns>La valeur entière de lettres qui restent à découvrir par le joueur.</returns>
        public int GetLettresManquantes()
        {
            return controller.GetLettresManquantes();
        }
    }
}
