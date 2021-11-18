using gestiondeproduits;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace gestion_de_produits
{
 
    public partial class MainWindow : Window
    {
        List<Produits> liste;
        string path = @"../../../Produits.json";
        public MainWindow()
        {
            InitializeComponent();
            liste = CreerListe();
            liste = TransformeJson();
            RemplirGrid();
            CreerFichier();
        }

        public void RemplirGrid()
        {
            listeProduits.ItemsSource = liste;
        }

        private List<Produits> CreerListe()
        {
            List<Produits> liste = new List<Produits>();
            for (int i = 1; i < 10; i++)
            {
                Produits p1 = new Produits(i, "Produit : " + i, "Alimentaire", i + 2);
                liste.Add(p1);
            }
            liste.Dump();
            return liste;         
        }

        private void CreerFichier()
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(liste, Formatting.Indented));
        }

        private string LireFichier()
       
        {
            string chaine;
            try
            {
              
                chaine = File.ReadAllText(path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Une exception s'est produite : " + e.Message);
                Console.WriteLine("Indiquer le path :");
                path = Console.ReadLine();
                chaine = LireFichier();
            }
            return chaine;
        }

        private List<Produits> TransformeJson()
        {
            string chaine = LireFichier();
            List<Produits> liste = JsonConvert.DeserializeObject<List<Produits>>(chaine);
            return liste;
        }



    }
}
