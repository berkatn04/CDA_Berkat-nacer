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

namespace Exercice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int op = 0;
        string Op;
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void btnNumerique_Click(object sender, RoutedEventArgs e)
        {
            // sender est l'élément qui a déclenché l'événement
            tb.Text += ((Button)sender).Content;
        }

        private void btnInit_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = "";
        }

        private void btnOP_Click(object sender, RoutedEventArgs e)
        {
            string vide = "";           
            if (tb.Text != vide)
                tb.Text += (string)((Button)sender).Content;

            else
                MessageBox.Show("Veulliez entre une valeur d'abord");


        }
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double w = Application.Current.MainWindow.Width;
            double h = Application.Current.MainWindow.Height;
            tb.Text = "w" + w + ", h" + h;
            btn1.FontSize = h / 20; btn2.FontSize = h / 20; btn3.FontSize = h / 20; btn4.FontSize = h / 20; btn5.FontSize = h / 20;
            btn6.FontSize = h / 20; btn7.FontSize = h / 20; btn8.FontSize = h / 20; btn9.FontSize = h / 20; btnVirgule.FontSize = h / 20;
            btnPlus.FontSize = h / 20; btnMoins.FontSize = h / 20; btnMultiplier.FontSize = h / 20; btnDiviser.FontSize = h / 20; btnEgale.FontSize = h / 20;
            btnCE.FontSize = h / 20;
        }
        
        static double calculSimple(double valeur1, string operateur, double valeur2)
        {
            double resultat = valeur1;
            switch (operateur)
            {
                case "+":
                    resultat = valeur1 + valeur2;
                    break;
                case "-":
                    resultat = valeur1 - valeur2;
                    break;
                case "x":
                    resultat = valeur1 * valeur2;
                    break;
                case "/":
                    if(valeur2 !=0)
                    resultat = valeur1 / valeur2;
                    else
                    MessageBox.Show("Division impossible par 0");
                    break;
                case "$":
                    resultat = Math.Pow(valeur1, valeur2);
                    break;
                default:
                    break;
            }
            return resultat;
        }

        private void operateur()
        {
            
            if (tb.Text.Contains("+"))
                op = tb.Text.IndexOf("+");
                Op = tb.Text.Substring(op, 1);
            if (tb.Text.Contains("-"))
                op = tb.Text.IndexOf("-");
                Op = tb.Text.Substring(op, 1);
            if (tb.Text.Contains("x"))
                op = tb.Text.IndexOf("x");
                Op = tb.Text.Substring(op, 1);
            if (tb.Text.Contains("/"))
                op = tb.Text.IndexOf("/");
                Op = tb.Text.Substring(op, 1);
        }
       
        private void btn_resultat(object sender, RoutedEventArgs e)
        {
            operateur();
            double val1;
            double val2;
            val1 = Convert.ToDouble(tb.Text.Substring(0, op));
            val2 = Convert.ToDouble(tb.Text.Substring(op + 1, tb.Text.Length - op - 1));
            tb.Text = Convert.ToString(calculSimple(val1, Op, val2));



        }

        

    }
}
