using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte
{
    class Compte
    {
        
        public  double solde { get; private set; }
        public int code { get; set; }
        public Clients proprietaire { get; set; }

        public static int codeincrement;

        public Compte(double solde, int code, Clients proprietaire)
        {
            this.solde = solde;
            codeincrement++;
            code = codeincrement;            
            this.proprietaire = proprietaire;
        }

        public void Crediter(double somme)
        {            
            solde += somme;
            Console.WriteLine("Operation effectuée ");
        }

        public void Crediter(double somme , Compte compte)
        {           
            solde += somme;
            compte.solde -= somme;
        }

        public void Debiter(double somme)
        {                   
            this.solde -= somme;
            Console.WriteLine("Operation effectuée ");
        }

        public void Debiter(double somme, Compte compte)
        { 
            this.solde -= somme;
            compte.solde += somme;
        }

        public override string ToString()
        {
            return "****************************\nCompte n°" + Compte.codeincrement + "\nSolde : " + solde;
        }

        

    }
}
