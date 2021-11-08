using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Personnes
    {

        string nom;
        string prenom;
        int age;
        string adresse;


        public Personnes()
        {
            
        }

        public Personnes(string nom, string prenom, int age, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.adresse = adresse;

        }

        public override string ToString()
        {
            return " nom : " + this.nom + "\n prenom : " + this.prenom + "\n age : " + this.age + "\n adresse : " + this.adresse;
        }


        
    }
}
