using System;

namespace Exercice6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Longueur;
            int Largeur;
            Console.WriteLine("Saisir la longueur d'un rectangle :");
            Longueur = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Saisir la largeur d'un rectangle: ");
            Largeur = (int.Parse(Console.ReadLine()));
            Console.WriteLine("La surface du rectangle est:" + Longueur * Largeur);
            Console.ReadLine();



        }
    }
}
