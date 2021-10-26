using System;

namespace Exercice
{
    class Program
    {
        private static object aleatoire;

        static void Main(string[] args)
        {

            /* exercice 1 :
              string affiche;
                Console.Write("Saisissez votre nom :");
                affiche = Console.ReadLine();
                Console.WriteLine("Votre nom est:" + affiche);
                Console.ReadLine();
           

             exercice 2:
            
            int nb;
            Console.Write("Entrez un entier : ");
            nb = int.Parse(Console.ReadLine());
            Console.WriteLine(nb);

            
               exercice 3:
                   int a = 5;
                   int b = 1;
                   Console.WriteLine("La somme de a et b est :" + (a+b));
                   Console.WriteLine("La division de a et b est:" + (a/b));

               exercice 4:
                      a = (float)3.5;
                   Console.WriteLine(a);

                exercice 5:
                        int a = 5;
                        int b = 2;
                        int c = 5;
                        int d = (a+b+c)/3;
                        Console.WriteLine(d);

                exercice 6:
                        int Longueur;
                        int Largeur;
                        Console.WriteLine("Saisir la longueur d'un rectangle :");
                        Longueur = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Saisir la largeur d'un rectangle: ");
                        Largeur = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("La surface du rectangle est:" + Longueur * Largeur);
                        Console.ReadLine();

                exercice 7:
                        char lettre;
                        lettre = 'A';
                        Console.WriteLine(lettre + (int) lettre);

             exercice 8

        static void upper(string lettre)
        {

        Console.WriteLine("Saisissez un caractere:");
        lettre = Console.ReadLine();
        Console.WriteLine("Voici sa majuscule :" + lettre.ToUpper());
        Console.ReadLine();

             

 ---------------------------------------------------------------------------------------------------------------------------------------------------------

            PAGE2:


            exercice1:

            

            Random myObject = new Random();
            int ranNum = myObject.Next(0,128);
            Console.WriteLine("le caractere saisi est :" + Convert.ToChar(ranNum));
            Console.WriteLine("Son successeur dans le table des code UNICODE est :" + Convert.ToChar(ranNum + 1));


            exercice2:

            *

            int c = 0;
            string str = "0123456789";
            for(c in str);
            {
                Console.WriteLine();
                Console.ReadLine();
            } 


            Exercice 3:

            */

            double M;
            double k;
            Console.Write("Saisissez le poids de chaque carton:");
            k = (double.Parse(Console.ReadLine()));
            Console.Write("Saisissez le poids max du camion:");
            M = (double.Parse(Console.ReadLine()));
            Console.WriteLine("Le camion peut transporter :" + (M / k) + "cartons");







        }



    }
}

