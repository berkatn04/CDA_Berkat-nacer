using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Incaders
{
    class Invaders
    {
        public string motif{ get; set; }

        public Invaders(string motif)
        {
            this.motif = motif;
        }

        public Invaders()
        {
            this.motif = "#";
          
        }

        public override string ToString()
        {
            return "#";
        }

        public string AfficheInvaders() {

            return "#";
        }



    }





}
