using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe
{
    class Agences
    {

        
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public int CodePostale { get; set; }
        public string Ville { get; set; }
        public string ModeRestauration { get; set; }

        public Agences(string nom, string adresse, int codePostale, string ville, string modeRestauration)
        {

            Nom = nom;
            Adresse=adresse;
            CodePostale = codePostale;
            Ville = ville;
            ModeRestauration = modeRestauration;

            }
    }
}
