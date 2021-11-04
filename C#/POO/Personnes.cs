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


    }
}
