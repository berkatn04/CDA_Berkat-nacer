using System;

namespace Compte
{
    class Program
    {
        static void Main(string[] args)
        {
            int montant;                 
            Clients C = new Clients();
            Compte Co = new Compte(0, 1, C);
            


            Console.WriteLine(Co);          
            Console.WriteLine(C);
            Console.Write("Saisissez le montant a crediter");
            montant = int.Parse(Console.ReadLine());
            Co.Crediter(montant);
            Console.WriteLine(Co);
            Console.WriteLine(C);
            Console.ReadLine();
            Console.WriteLine(Co);
            Console.WriteLine(C);
            Console.Write("Saisissez le montant a crediter");
            montant = int.Parse(Console.ReadLine());
            Co.Debiter(montant);
            Console.WriteLine(Co);
            Console.WriteLine(C);
            Console.WriteLine("\n\n");
            Clients C2 = new Clients();
            Compte Co2 = new Compte(0, 1, C2);
            Console.WriteLine(Co2);
            Console.WriteLine(C2);
            Console.Write("Saisissez le montant a crediter");
            montant = int.Parse(Console.ReadLine());
            Co.Debiter(montant, Co2);
            Console.WriteLine(Co2);
            Console.WriteLine(C2);
            Console.ReadLine();
            Console.WriteLine(Co);
            Console.WriteLine(C);
            Console.WriteLine("\nNombre de comptes crees : " + Compte.codeincrement);




        }
    }
}
