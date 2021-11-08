using System;

namespace C_Sharp_Application_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            Voitures V = new Voitures("Citroën C4", 10000);
            Voitures V2 = new Voitures("Renault Kadjar", "rouge");
            Console.WriteLine(V);
            V.Rouler(15000);
            Console.WriteLine(V);
            Console.WriteLine(V2);


        }
    }
}
