using System;

namespace JeuxCombats
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaration
            Joueurs moktar = new Joueurs();
            int nbMonstre = 0;
            bool trace = true;
            MonstresFaciles munster;
            //initialisation 
            if (De.LanceLeDe()<=3)
            {
             munster = new MonstresFaciles();
            }
            else  munster = new MonstresDifficiles();
            // cette partie permet de faire tourner le jeu 
            do
            {
                if (!munster.Vivant) //creation d'un nouveau monstre si le monstre est precedent est mort
                {
                    if (De.LanceLeDe() <= 3)
                    {
                        munster = new MonstresFaciles();
                    }
                    else munster = new MonstresDifficiles();
                }
                if (moktar.Attaque(munster, trace))
                {
                    Console.WriteLine("le monstre est mort");
                    nbMonstre++;
                }
                else
                {
                    Console.WriteLine("le joueur a raté son coup");
                    if (munster.Attaque(moktar, trace))
                    {
                        Console.WriteLine("le joueur a été toucher");
                    }
                    else
                    {
                        Console.WriteLine("Le monstre a raté ");
                    }
                }
            } while (moktar.PointsDeVies >0);
            Console.WriteLine("***********************************");
            Console.WriteLine("vous etes mort vous avez reussi a tuer : " + nbMonstre + " monstres ");
        }
    }
}
