using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte
{
    class Clients
    {
        public string cin { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public double tel { get; set; }

        public Clients(string cin, string nom, string prenom, double tel)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
        }

        public Clients(string cin, string nom, string prenom)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
        }

        public string Affiche()
        {
            return this.cin + this.nom + this.prenom + this.tel;
        }
        public override string ToString()
        {
            return "Proprietaire du compte : \nCIN : " + this.cin + "\nNOM : " + this.nom + "\nPrenom" + this.prenom + "\nTel : " + this.tel;

        }
    }
}
