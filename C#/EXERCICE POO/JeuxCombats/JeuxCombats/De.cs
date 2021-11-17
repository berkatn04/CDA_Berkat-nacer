using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombats
{
    class De
    {
        private static Random aleatoire = new Random();
        public static int LanceLeDe()
        {
            return aleatoire.Next(1, 7);

        }


    }



}
