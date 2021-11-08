using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Application_Console
{
    class Voitures
    {

        public string couleur { get; set; }
        public string marque { get; set; }
        public string modele{ get; set; }
        public int nbkilometre { get; set; }
        public string motorisation { get; set; }

        public Voitures(string couleur, string marque, string modele, int nbkilometre, string motorisation)
        {
            this.couleur = couleur;
            this.marque = marque;
            this.modele = modele;
            this.nbkilometre = nbkilometre;
            this.motorisation = motorisation;
        }
       
        public override string ToString()
        {
            return " Cette voiture est une " + this.modele + " de la marque " + this.marque + " , de couleur " + this.couleur + " , de motorisation" +
                 this.motorisation + " , avec " + this.nbkilometre + " Kilomètres ";
        }

        public Voitures(string modele, int nbkilometre)
        {
            this.modele = modele;
            this.nbkilometre = nbkilometre;
        }

        public Voitures(string modele, string couleur)
        {
            this.couleur = couleur;
            this.modele = modele;
        }



        public int Rouler(int kilotrajet) => this.nbkilometre += kilotrajet;
    }
}
