using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace gestion_de_produits
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MainWindow fenetreMere;
        public Window1()
        {
            InitializeComponent();
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
        private void Enregistrer_Click(object sender, RoutedEventArgs e)
        {
            Enregistrement enreg = new Enregistrement( IdProduit.Text, LibelleProduit.Text, Categorie.Text, Rayon.Text);
            enreg.Ajout();
            ChargerFichier();
        }
        private void ChargerFichier()
        {
            fenetreMere.listeProduits.ItemsSource = Enregistrement.ListeEnreg();
        }
    }
}
