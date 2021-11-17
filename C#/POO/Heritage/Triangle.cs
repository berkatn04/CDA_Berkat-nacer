using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Triangle
    {
        public int Base { get; set; }
        public int Hauteur { get; set; }

        public Triangle(int @base, int hauteur)
        {
            Base = @base;
            Hauteur = hauteur;
        }

        public Triangle()
        {
            int bas;
            int hauteur;
            Console.WriteLine();
            bas = int.Parse(Console.ReadLine());
            Console.WriteLine();
            hauteur = int.Parse(Console.ReadLine());


        }

        public double Perimetre()
        {
            return (this.Base+this.Hauteur+(Math.Sqrt(Math.Pow(this.Base,2) + Math.Pow(this.Hauteur, 2))));
        }

        public int Aire()
        {
            return ((this.Base * this.Hauteur)/2);
        }
     
        public override string ToString()
        {
            return "Base : " + Base + "\nHauteur : " + this.Hauteur + "\n" +  this.Perimetre() + "\n" + this.Aire();
        }
    }
}
