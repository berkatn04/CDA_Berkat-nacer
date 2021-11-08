using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe
{
    class Employe
    {
        internal object priority;

        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime dateEmbauche { get; set; }
        public double salaire { get; set; }
        public string service { get; set; }


            public Employe()
            {
            Console.WriteLine("saisissez votre nom ");
            this.nom =  Console.ReadLine();
            Console.WriteLine("saisissez votre prenom ");
            this.prenom = Console.ReadLine();
            Console.WriteLine("saisissez une date sous forme 'JJ/MM/AAAA' ");
            this.dateEmbauche = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("saisissez votre salaire ");
            this.salaire = double.Parse(Console.ReadLine());
            Console.WriteLine("saisissez votre service ");
            this.service = Console.ReadLine();
            
            }

            public Employe(string nom, string prenom, DateTime dateEmbauche, double salaire, string service)
            {
            this.nom = nom;
            this.prenom = prenom;
            this.dateEmbauche = dateEmbauche;
            this.salaire = salaire;
            this.service = service;
            }
            public void Temps()
            {
           
            Console.WriteLine("L'employé est dans l'entreprise depuis : " + (DateTime.Today.Year - this.dateEmbauche.Year)+ " ans");
            
            }

        public void Prime()
        {
            double prime = (this.salaire * 0.05) + (this.salaire * 0.02 * (DateTime.Today.Year - this.dateEmbauche.Year));
            Console.WriteLine("Votre prime est de : " + prime);
            if (DateTime.Today.Month == 11 && DateTime.Today.Day == 30)
            {
                this.salaire += prime;
                Console.WriteLine("L'ordre de transfert a ete envoye a la banque, la prime est de : " + prime);
            }
            else
                Console.WriteLine("Nous ne somme pas encore le 30/11");


        }

        public override string ToString()
        {
            return this.nom +" "+ this.prenom +" "+ this.dateEmbauche +" "+ this.salaire +" "+ this.service; 

        }

}   }   
          
   

