using GestionDesStocks.Data.Controller;
using GestionDesStocks.Data.Models;
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

namespace GestionDesStocks
{
    /// <summary>
    /// Logique d'interaction pour ListeTypeProduits.xaml
    /// </summary>
    public partial class ListeTypeProduits : Window
    {
        private Window _window;
        private TypeProduitsController _TypeProduits;
        public ListeTypeProduits(MainWindow win, MyDbContext ctx)
        {
            InitializeComponent();
            this._window = win;
            this._TypeProduits = new TypeProduitsController(ctx);
            dt.ItemsSource = _TypeProduits.GetAllTypeProduits();
        }

        private void ButtonRetour(object sender, RoutedEventArgs e)
        {
            

        }
    }
}
