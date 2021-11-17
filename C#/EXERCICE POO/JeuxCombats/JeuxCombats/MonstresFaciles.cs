using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombats
{
    class MonstresFaciles
    {
public bool Vivant { get; set; }

        public MonstresFaciles()
        {
            this.Vivant = true;
        }

        public virtual bool Attaque(Joueurs moktar, bool trace)
        {

            int lancerDuJoueur = De.LanceLeDe();
            int lancerDuMonstre = De.LanceLeDe();
            if (lancerDuMonstre>lancerDuJoueur )
            {
                moktar.SubiDegats(10 , trace );  
                return true;
            }
            return false;
        }
    }
}
