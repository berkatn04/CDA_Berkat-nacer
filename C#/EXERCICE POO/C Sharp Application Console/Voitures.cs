using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Application_Console
{
    class Voitures
    {

        public string Couleur { get; set; }
        public string Marque { get; set; }
        public string Modele{ get; set; }
        public int NBkilometre { get; set; }
        public string Motorisation { get; set; }

        public Voitures(string couleur, string marque, string modele, int nbkilometre, string motorisation)
        {
            Couleur = couleur;
            Marque = marque;
            Modele = modele;
            NBkilometre = nbkilometre;
            Motorisation = motorisation;
        }
       
        public override string ToString()
        {
            return " Cette voiture est une " + Modele + " de la marque " + Marque + " , de couleur " + Couleur + " , de motorisation" +
                 Motorisation + " , avec " + NBkilometre + " Kilomètres ";
        }

        public Voitures(string modele, int nbkilometre)
        {
            Modele = modele;
            NBkilometre = nbkilometre;
        }

        public Voitures(string modele, string couleur)
        {
            Couleur = couleur;
            Modele = modele;
        }



        public int Rouler(int kilotrajet) => NBkilometre += kilotrajet;
    }
}
