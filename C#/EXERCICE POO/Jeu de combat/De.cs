using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_de_combat
{
    class De
    {
        public De()
        {
            Lancer();
        }

        public static int Lancer()
        {
            var rand = new Random();
            return (rand.Next(1, 7));
        }

    }
}
