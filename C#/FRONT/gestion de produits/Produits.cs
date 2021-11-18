using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_produits
{
    public class Produits
    {
        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }
        public string Categories { get; set; }
        public int Rayons { get; set; }


        public Produits(int idProduit, string libelleProduit, string categories, int rayons)
        {
            IdProduit = idProduit;
            LibelleProduit = libelleProduit;
            Categories = categories;
            Rayons = rayons;
        }
    }
}
