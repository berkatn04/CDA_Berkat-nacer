using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombats
{
    class MonstresDifficiles:MonstresFaciles
    {


        public override bool Attaque(Joueurs moktar , bool trace )
        {
             base.Attaque(moktar, trace );
             int lancerDuMonstre = De.LanceLeDe();
            if (lancerDuMonstre!=6)
            {
                moktar.SubiDegats(lancerDuMonstre * 5 , trace );
                return true;
            }
            return false;
        }
    





    }
}
