using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYG_Projet2
{
    // Controlleur pour la classe Pendu, permettant au jeu de fonctionner.
    internal class PenduController
    {
        // Liste de mots pouvant être séléctionnés au hasard lors de la construction de l'objet.
        readonly private static String[] motsListe =
        {
            "TEST",
            "VOCABULAIRE"
        };

        // Mot à deviner dans le cadre du jeu du pendu
        readonly private String mot;


        private List<Char> characteresUtilises;

        //
        public PenduController()
        {
            Random random = new Random();
            mot = motsListe[random.Next(motsListe.Length)]; // Sélectionne un mot au hasard dans la liste.
            characteresUtilises = new List<Char>();
        }

        public String GetMot() { return mot; }

        public bool IsCharInMot(Char charactere)
        {
            return mot.Contains(charactere);
        }
    }
}
