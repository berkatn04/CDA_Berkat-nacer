using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Parallelepipede : Rectangle
    {
        public int Hauteur { get; set; }

        public Parallelepipede(int longueur, int largeur, int hauteur ) : base(longueur, largeur)
        {
            this.Hauteur = hauteur;
        }

        public override string ToString()
        {
            return "Perimetre : " + this.Perimetre2() + "\nVolume : " + this.Volume() ;
        }

        public double Perimetre2()
        {
            return (2 * this.Perimetre()) + (4 * this.Hauteur);
        }
        public double Volume()
        {
            return this.Aire() * this.Hauteur;

        }
    }
}
