using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_produits
{
    class Enregistrement
    {
        static string path = @"../../Produit.txt";
        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }
        public string Categories { get; set; }
        public int Rayons { get; set; }


        public Enregistrement() { }
        public Enregistrement(int idProduit, string libelleProduit, string categories, int rayons)
        {
            IdProduit = idProduit;
            LibelleProduit = libelleProduit;
            Categories = categories;
            Rayons = rayons;
        }

        public void Ajout()
        {
            string[] tab;
            List<Enregistrement> liste = new List<Enregistrement>();
            Fichier f = new Fichier();
            tab = f.LireFichier(path);
            int taille = tab.Length;
            Array.Resize(ref tab, taille + 1);
            tab[taille] = this.ToString();
            Array.Sort(tab);
            f.EcrireFichier(tab, path);

        }

        public override string ToString() // Méthode toString transforme un objet en chaîne de caractère
        {
            return IdProduit + ";" + LibelleProduit + ";" + Categories + ";" + Rayons;
        }

        static public List<Enregistrement> ListeEnreg()
        //Ajoute un nouveau enregistrement à une liste selon le niveau choisi
        {

            int i;
            Enregistrement r;
            List<Enregistrement> liste = new List<Enregistrement>();
            Fichier f = new Fichier();
            string[] tab = new string[10];
            string[] ligne;
            tab = f.LireFichier(path);
            for (i = 0; i < tab.Length; i++)
            {
                r = new Enregistrement();
                ligne = tab[i].Split(';');
                r.IdProduit = ligne[0]; // prend les 2 premiers caractères à partir de la position 0
                r.LibelleProduit = ligne[1]; // prend 5 caractères à partir de la position 2
                r.Categories = ligne[2];
                r.Rayons = ligne[3];
                liste.Add(r);
            }


        }
    }
}
