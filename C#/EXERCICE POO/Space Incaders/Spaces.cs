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
                

                }
                
              }

            public void GrilleEtInvaders()
            {
            Grille();
            


            }

        }




        
    }
}
