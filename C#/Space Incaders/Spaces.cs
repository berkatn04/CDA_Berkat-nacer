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
            Grille();
        }   
            
           
             public void Grille()
            {
                this.grille = new char[NbLignes, NbColonnes];
                for (int j = 0; j < NbColonnes; j++)
                {

                    Console.WriteLine();

                    for (int i = 0; i < NbLignes; i++)
                    {

                    if (j == NbColonnes - 1 || i == 0 || i == NbLignes - 1 || j == 0)
                    {
                        Console.Write("- ");

                    }
                    else Console.Write("  ");
                        

                    }
                    

                }
                
              }

            public void GrilleEtInvaders()
            {
            Grille();
            for (int j = 1; j < NbColonnes-1; j++)
            {               
               for (int i = 1; i < NbLignes-1; i++)
                {

                    if (j == 1) Console.Write("# ");
                    else Console.Write("  ");


                }


            }

        }




        
    }
}
