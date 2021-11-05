using System;

namespace Compte
{
    class Program
    {
        static void Main(string[] args)
        {
            int montant;
            int retrait;
            string CIN;
            string nom;
            string prenom;
            double tel;
            Console.WriteLine("Donner le CIN : ");
            CIN = Console.ReadLine();
            Console.WriteLine("Donner le Nom : ");
            nom = Console.ReadLine();
            Console.WriteLine("Donner le Prenom : ");
            prenom = Console.ReadLine();
            Console.WriteLine("Donner le Tel : ");
            tel = double.Parse(Console.ReadLine());









            Clients C = new Clients(CIN, nom, prenom, tel);
            Compte Co = new Compte(0, 1, C);
            Console.WriteLine("****************************");
            Console.WriteLine(C);
           



        }
    }
}
