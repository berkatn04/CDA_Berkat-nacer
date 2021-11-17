using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_de_combat
{
    class MonstreDifficile : MonstreFacile
    {
        public MonstreDifficile(bool statut) : base(statut)
        {
        }


        public void Attaque(Joueur joueur2)
        {
            base.Attaque(joueur2);
            int sort = De.Lancer();
            if (sort != 6)
            {
                base.degats += (sort * 5);
                joueur2.SubitDegats(degats);
            }
            else
                joueur2.SubitDegats(0);

        }
    }
}
