using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Incaders
{
    

    class Spaces
    {
        public int NbLignes { get; set; }
        public int NbColonnes { get; set; }

        char[,] grille;

        public Spaces(int nbLignes, int nbColonnes)
        {
            NbLignes = nbLignes;
            NbColonnes = nbColonnes;
            this.grille = new char[nbLignes, nbColonnes];
            for (int j = 0; j < NbColonnes; j++)
            {

                Console.WriteLine();

                for (int i = 0; i < NbLignes; i++)
                {
                    if (i == 1) return (Invaders.Invaders());
                    if (i == 0 || j == NbColonnes - 1 || j == 0 || i == NbLignes - 1) Console.Write("- ");
                    else Console.Write("  ");


                }

            }


        } 
    }
}
