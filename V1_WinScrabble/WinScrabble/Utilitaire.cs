using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinScrabble
{
    /// <summary>
    /// Classe qui regroupe les fonctions de calcul
    /// </summary>
    public static class Utilitaire
    {
        /// <summary>
        /// Méthode qui retourne le nombre de points que rapporte une lettre
        /// </summary>
        /// <param name="l">Lettre de type char</param>
        /// <returns>Nombre de points rapportés par la lettre</returns>
        private static int PointsLettre(char l)
        {
            l = char.ToUpper(l);
            int p;
            if (l == 'D' || l == 'G' || l == 'M')
                p = 2;
            else
            {
                if (l == 'B' || l == 'C' || l == 'P')
                    p = 3;
                else
                {
                    if (l == 'F' || l == 'H' || l == 'V')
                        p = 4;
                    else
                    {
                        if (l == 'J' || l == 'Q')
                            p = 8;
                        else
                        {
                            if (l == 'K' || l == 'W' || l == 'X' || l == 'Y' || l == 'Z')
                                p = 10;
                            else
                                p = 1;
                        }
                    }
                }
            }
            return p;
        }
        /// <summary>
        /// calcule le nombre de point de chaque lettre du mot entré en parametre
        /// </summary>
        /// <param name="mot">variable de type string </param>
        /// <returns>retourne le nombre de point en int</returns>
        public static int PointsMot(string mot)
        {
            int pts = 0;
            for (int i = 0; i < mot.Length; i++)
            {
                char lettre = mot[i];
                pts = pts + PointsLettre(lettre);
            }
            return pts;
        }
        public static int TotalMot(string mot)
        {
            int pts = 0;
            for (int i = 0; i < mot.Length; i++)
            {
                char lettre = mot[i];
                pts = pts + PointsLettre(lettre);
            }
            return pts;
        }
    }
}
