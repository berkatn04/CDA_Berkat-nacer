using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Rectangle
    {
        public int Longueur { get; set; }
        public int Largeur { get; set; }

        public Rectangle(int longueur, int largeur)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public Rectangle()
        {
            int longueur;
            int largeur;
            Console.WriteLine();
            longueur = int.Parse(Console.ReadLine());
            Console.WriteLine();
            largeur = int.Parse(Console.ReadLine());


        }

        public int  Perimetre()
        {
            return ((this.Longueur + this.Largeur) * 2); 
        }

        public int Aire()
        {
            return (this.Longueur*this.Largeur);
        }

        public string Estcarré()
        {
            if (this.Longueur == this.Largeur)
                return "Le rectangle est carré";
            else
                return "Le rectangle n'est pas carré";
        }

        public override string ToString()
        {
            return "Longueur :" + this.Longueur + "\nLargeur : " + this.Largeur + "\nLe perimetre est : " + this.Perimetre() + "\nL'aire est : " + this.Aire() + "\n" + this.Estcarré();
        }
















    }


}
