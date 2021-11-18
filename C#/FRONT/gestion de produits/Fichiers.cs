using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_produits
{
    class Fichier
    {

      

        public void EcrireFichier(string[] enreg, string path)
       
        {
            File.WriteAllLines(path, enreg);
        }

        public string[] LireFichier(string path)
       
        {
            string[] tab = new string[5];      
            tab = File.ReadAllLines(path);
            return tab;
        }


    }
}
