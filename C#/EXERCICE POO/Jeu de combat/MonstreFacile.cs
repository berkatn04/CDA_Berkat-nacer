using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_de_combat
{
    class MonstreFacile
    {
        public bool statut { get; set; }
        public int degats { get; set; } = 10;

        public MonstreFacile(bool statut)
        {
            this.statut = statut;
        }

        public void Attaque(Joueur joueur)
        {
            int attheros = De.Lancer();
            int attmonstre = De.Lancer();
            if (attmonstre>=attheros)
            {
                joueur.SubitDegats(degats);
            }
            
        }
    }
}
