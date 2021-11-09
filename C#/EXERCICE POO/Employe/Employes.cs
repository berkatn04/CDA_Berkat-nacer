using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe
{
    class Employes
    {

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateEmbauche { get; set; }
        public double Salaire { get; set; }
        public string Service { get; set; }
        public Agences Agence { get; set; }
        public IDictionary<string,int> Enfants { get; set; }

        public Employes()
        {
            Console.WriteLine("saisissez votre nom ");
            this.Nom = Console.ReadLine();
            Console.WriteLine("saisissez votre prenom ");
            this.Prenom = Console.ReadLine();
            Console.WriteLine("saisissez une date sous forme 'JJ/MM/AAAA' ");
            this.DateEmbauche = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("saisissez votre salaire ");
            this.Salaire = double.Parse(Console.ReadLine());
            Console.WriteLine("saisissez votre service ");
            this.Service = Console.ReadLine();

        }

        public Employes(string nom, string prenom, DateTime dateEmbauche, double salaire, string service, Agences agence)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateEmbauche = dateEmbauche;
            this.Salaire = salaire;
            this.Service = service;
            this.Agence = agence;
        }

        public Employes(string nom, string prenom, DateTime dateEmbauche, double salaire, string service)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateEmbauche = dateEmbauche;
            this.Salaire = salaire;
            this.Service = service;
            
        }

        public Employes(string nom, string prenom, DateTime dateEmbauche, double salaire, string service, Agences agence, IDictionary<string, int> enfants)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateEmbauche = dateEmbauche;
            this.Salaire = salaire;
            this.Service = service;
            this.Agence = agence;
            this.Enfants = enfants;
        }
        public void Temps()
        {

            Console.WriteLine("L'employé est dans l'entreprise depuis : " + (DateTime.Today.Year - this.DateEmbauche.Year) + " ans");

        }

        public void Prime()
        {
            double prime = (this.Salaire * 0.05) + (this.Salaire * 0.02 * (DateTime.Today.Year - this.DateEmbauche.Year));
            Console.WriteLine("Votre prime est de : " + prime);
            if (DateTime.Today.Month == 11 && DateTime.Today.Day == 30)
            {
                this.Salaire += prime;
                Console.WriteLine("L'ordre de transfert a ete envoye a la banque, la prime est de : " + prime);
            }
            else
                Console.WriteLine("Nous ne somme pas encore le 30/11");


        }

        public override string ToString()
        {
            return this.Nom + " " + this.Prenom + " " + this.DateEmbauche + " " + this.Salaire + " " + this.Service;

        }

        public static int ComparerToNomPrenom(Employes E1, Employes E2)
        {
            if (E1.Nom == E2.Nom)
            {
                if (E1.Prenom.CompareTo(E2.Prenom) == 1)
                {
                    return 1;
                }
                else if (E1.Prenom.CompareTo(E2.Prenom) == -1)
                {
                    return -1;
                }
            }
            else if (E1.Nom.CompareTo(E2.Nom) == 1)
            {
                return 1;
            }
            else if (E1.Nom.CompareTo(E2.Nom) == -1)
            {
                return -1;
            }
            return 0;
        }

        public static int ComparerServiceToNomPrenom(Employes E1, Employes E2)
        {
            if (E1.Service == E2.Service)
                return ComparerToNomPrenom(E1, E2);
            else if (E1.Service.CompareTo(E2.Service) == 1)
                return 1;
            else
                return -1;

        }

        public static void Vacances(Employes E1)
        {
            if ((DateTime.Today.Year - E1.DateEmbauche.Year) >= 1)
            {
                
                Console.WriteLine("Vous etes eligible aux cheques vacance");
            }
            else
            {
                Console.WriteLine("Vous n'etes pas eligible aux cheques vacance");
            }

        }

        public static void Noel(Employes E1)
        {
            int valeur=0;
            foreach (KeyValuePair<string, int> i in E1.Enfants)
            {
                if (i.Value > 0 && i.Value <= 10)
                    valeur += 20;

                else if (i.Value > 11 && i.Value <= 15)
                    valeur += 30;
                else if (i.Value > 16 && i.Value <= 18)
                    valeur += 50;
                else
                    valeur += 0;

            }
            Console.WriteLine(valeur);
        }




    }
}