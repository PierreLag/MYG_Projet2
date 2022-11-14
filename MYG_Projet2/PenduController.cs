using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYG_Projet2
{
    /// <summary>
    /// Controlleur pour la classe Pendu, permettant au jeu de fonctionner.
    /// </summary>
    internal class PenduController
    {
        /// <summary>
        /// Liste de mots pouvant être séléctionnés au hasard lors de la construction de l'objet.
        /// </summary>
        readonly private static String[] motsListe =
        {
            "TEST",
            "VOCABULAIRE",
            "EXAMEN",
            "ANTICIPATION",
            "ORDINATEUR",
            "CONJUGAISON",
            "BATEAU",
            "COORDINATEUR"
        };

        /// <summary>
        /// Mot à deviner dans le cadre du jeu du pendu
        /// </summary>
        readonly private String mot;


        private List<Char> characteresUtilises;

        /// <summary>
        /// Génère un controlleur pour la classe Pendu. Lors de sa création, un mot est séléctionné parmi l'énumération motsListe, et la liste de charactères utilisés est initialiée.
        /// </summary>
        public PenduController()
        {
            Random random = new Random();
            mot = motsListe[random.Next(motsListe.Length)]; // Sélectionne un mot au hasard dans la liste.
            characteresUtilises = new List<Char>();
        }

        /// <summary>
        /// Renvoie le mot sélectionné lors de la création de l'objet.
        /// </summary>
        /// <returns>Le mot attribué au controlleur à sa création au format String.</returns>
        public String GetMot() { return mot; }

        public List<Char> GetCharacteresUtilises() { return characteresUtilises; }

        /// <summary>
        /// Méthode permettant d'insérer dans la liste de charactères utilisés un nouveau charactère.
        /// <para>Renvoie une exception ArgumentNullException dans l'événement où la valeur entrée est vide.</para>
        /// <para>Renvoie une exception InvalidOperationException si la lettre a déjà été entrée auparavant.</para>
        /// <para>Renvoie une exception ArgumentException si le charactère entré n'est pas une lettre.</para>
        /// </summary>
        /// <param name="charactere">Charactère à insérer dans la liste interne. Doit être une lettre.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public void InputNewChar(Char charactere)
        {
            if (charactere.Equals(null))
            {
                throw new ArgumentNullException();
            }
            if (characteresUtilises.Contains(Char.ToUpper(charactere)))
            {
                throw new InvalidOperationException();
            }
            if (!Char.IsLetter(charactere))
            {
                throw new ArgumentException();
            }
            characteresUtilises.Add(Char.ToUpper(charactere));
        }

        /// <summary>
        /// Pour chaque lettre dans la liste de charactères utilisées, vérifie si elle est dans le mot ou non.
        /// </summary>
        /// <returns>Le nombre total de lettres dans la liste n'étant pas dans le mot à trouver.</returns>
        public int GetFauxCharacteresUtilisesCount()
        {
            int fauxCharacteresCount = 0;
            foreach(Char charactere in characteresUtilises)
            {
                if (!mot.Contains(charactere))
                {
                    fauxCharacteresCount++;
                }
            }
            return fauxCharacteresCount;
        }

        /// <summary>
        /// Retourne le nombre de lettres qui restent à découvrir dans le mot à deviner. Si cette valeur vaut 0, alors le mot entier est découvert.
        /// </summary>
        /// <returns>La valeur entière de lettres qui restent à découvrir par le joueur.</returns>
        public int GetLettresManquantes()
        {
            int charManquants = 0;
            foreach (Char charactere in mot)
            {
                if (!characteresUtilises.Contains(charactere))
                {
                    charManquants++;
                }
            }
            return charManquants;
        }
    }
}
