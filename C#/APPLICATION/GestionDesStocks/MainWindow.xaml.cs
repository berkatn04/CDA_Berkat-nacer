using GestionDesStocks.Data.Controller;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionDesStocks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MyDbContext _ctx;

        public MainWindow()
        {
            InitializeComponent();
            _ctx = new MyDbContext();
        }

      

        private void GoListeArticles(object sender, RoutedEventArgs e)
        {
            ListeArticles listeArticleWindow = new ListeArticles(this, this._ctx);
            listeArticleWindow.ShowDialog();
        }
    }
}
