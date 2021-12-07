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
using System.Windows.Shapes;

namespace GestionDesStocks
{
    /// <summary>
    /// Logique d'interaction pour ListeCategories.xaml
    /// </summary>
    public partial class ListeCategories : Window
    {
        private Window _window;
        private CategoriesController _categorieController;
        public ListeCategories(MainWindow win, MyDbContext ctx)
        {
            InitializeComponent();
            this._window = win;
            this._categorieController = new CategoriesController(ctx);
            dt.ItemsSource = _categorieController.GetAllCategories();
        }
    }
}
