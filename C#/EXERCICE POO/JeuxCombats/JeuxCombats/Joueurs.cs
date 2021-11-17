using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombats
{
    class Joueurs
    {

        public int PointsDeVies { get; private set; }

        public Joueurs()
        {
            this.PointsDeVies = 50;
        }

        public bool EstVivant()
        {
            if (this.PointsDeVies<=0 )
            {
                return false;
            }
            return true;
        }

        public bool Attaque (MonstresFaciles munster, bool trace)
        {
            int lancerDuJoueur = De.LanceLeDe();
            int lancerDuMonstre = De.LanceLeDe();
            if (trace)
            {
                Console.WriteLine("mon hero attaque : " + lancerDuJoueur + " le monstre : " + lancerDuMonstre);
            }
            if (lancerDuJoueur >= lancerDuMonstre)
            {
                munster.Vivant = false;
                return true;
            }
               return false ;
        }

         public bool SubiDegats(int degat , bool trace)
        {
            int lancerDuJoueur = De.LanceLeDe();
            if (trace)
            {
                Console.WriteLine("mon hero bouclier : " + lancerDuJoueur );
            }
            if (lancerDuJoueur <= 2)
            {
                return true;
            }
            if (trace)
            {
                Console.WriteLine("mon heros subit des degats : " + degat + " point de vie restant : " + this.PointsDeVies);
            }
            this.PointsDeVies -= degat;
            return false;
        }


    }
}
