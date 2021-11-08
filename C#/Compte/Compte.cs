using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte
{
    class Compte
    {
        
        public  int solde { get; set; }
        public int code { get; set; }
        public Clients proprietaire { get; set; }

        public static int codeincrement;

        public Compte(int solde, int code, Clients proprietaire)
        {
            this.solde = solde;
            codeincrement++;
            codeincrement = code;            
            this.proprietaire = proprietaire;
        }

        public void Crediter()
        {
            int somme;
            Console.WriteLine("Donner le montant a deposer : ");
            somme = int.Parse(Console.ReadLine());
            solde += somme;
            Console.WriteLine("Donner le montant a deposer : ");
        }

        public void Crediter(int somme, Compte compte)
        {
            solde += somme;
            compte.solde -= somme;
        }

        public void Debiter(int somme)
        {
            this.solde -= somme;
        }

        public void Debiter(int somme, Compte compte)
        {
            this.solde -= somme;
            compte.solde += somme;
        }

        public override string ToString()
        {
            return  "Numero de compte : " + this.code + "\nSolde de compte : " + this.solde + this.proprietaire.ToString();
        }

        

    }
}
