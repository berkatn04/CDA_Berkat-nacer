using System;

namespace Jeu_de_combat
{
    class Program
    {
        private static MonstreFacile monstre1;

        static void Main(string[] args)
        {
            
            Joueur joueur = new Joueur(50);
            do
            {
                monstre1 = CreationMonstre();
                do
                {
                    joueur.Attaque(monstre1);
                    Console.WriteLine(joueur.PDV);
                    Console.WriteLine(joueur.SubitDegats(monstre1.degats));
                } while (monstre1.statut == true);
                Console.WriteLine("Le heros a gagné \n ********************** Monstre suivant");

            } while (joueur.PDV > 0);
            Console.WriteLine();


        }

        public static MonstreFacile CreationMonstre()
        {
            int creer = De.Lancer();
            if (creer > 3)
               return  monstre1 = new MonstreDifficile(true);
            else
              return  monstre1 = new MonstreFacile(true);
        }
    }
}

