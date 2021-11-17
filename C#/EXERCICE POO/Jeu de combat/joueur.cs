using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_de_combat
{
    class Joueur
    {
        public int PDV { get; private set; }

        public Joueur(int pdv)
        {
            PDV = pdv;
        }



        public bool EstVivant()
        {
            return PDV > 0 ? true : false;
        }

        public void Attaque(MonstreFacile monstre)
        {
             int attheros = De.Lancer();
            int attmonstre = De.Lancer();
            if (attheros > attmonstre)
            {
                monstre.statut = false;
            }
            else
            {
                monstre.Attaque(this);
            }
            

        }

        public int SubitDegats(int Degats)
        {
            int bouclier = De.Lancer();
            if (bouclier <= 2)
            {
                this.PDV -= 0;
                return this.PDV;
            }
            else
            this.PDV -= Degats;
            return this.PDV;
        }

        public override string ToString()
        {
            return "PV : " + this.PDV;
        }
    }
}
