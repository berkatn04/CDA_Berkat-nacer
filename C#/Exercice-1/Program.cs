using System;
using System.Linq;

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

        char val2 = '1';
        char val3 = '2';
        char val4 = '3';
        char val5 = '4';
        char val6 = '5';
        char val7 = '6';
        char val8 = '7';
        char val9 = '8';
        char val10 = '9';

        Console.WriteLine((int)val1);
        Console.WriteLine((int)val2);
        Console.WriteLine((int)val3);
        Console.WriteLine((int)val4);
        Console.WriteLine((int)val5);
        Console.WriteLine((int)val6);
        Console.WriteLine((int)val7);
        Console.WriteLine((int)val8);
        Console.WriteLine((int)val9);
        Console.WriteLine((int)val10);


            Exercice8:

            Console.WriteLine("Saisissez le poids d'un carton : ");
            float poidsUnitaire = float.Parse(Console.ReadLine());
            Console.WriteLine("Saisissez la capacité du camion : ");
            float poidsTotal = float.Parse(Console.ReadLine());
            int nombreDeCartons = (int)(poidsTotal / poidsUnitaire);
            Console.WriteLine("Vous pourrez placer " + nombreDeCartons + " cartons.");

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            PAGE 3:


            exercice1:

            int age;
            Console.WriteLine("Saisissez votre age:");
            age = (int.Parse(Console.ReadLine()));
            if (age >= 18)
            {
                Console.Write("Vous etes majeur");
            }
            else
            {
                Console.Write("Vous etes mineur");
            }



            exercice2:

            int a;
            Console.Write("Saisissez une valeur:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(a));
            



            exercice3:

            int a;
            Console.Write("Saisissez une note:");
            a = int.Parse(Console.ReadLine());
            if(a>=8 & a < 10)
            {
                Console.WriteLine("rattrapage");
            }
            if (a >=10)
            {
                Console.WriteLine("admis");
            }
            if (a < 8)
            {
                Console.WriteLine("ajournée");
            }





            exercice4:

            float M;
            Console.WriteLine("Saisissez le montant des dommages :");
            M = float.Parse(Console.ReadLine());
            float F = (10 / 100) * M;
            if (F < 4000)
            {
                Console.WriteLine("La franchise est de" + F);
            }
           



            exercice5:
            
            





            
            exercice6:
            
            int a;
            int b;
            int c;
            Console.Write("Saisissez la premiere valeur :");
            a = int.Parse(Console.ReadLine());
            Console.Write("Saisissez la deuxieme valeur :");
            b = int.Parse(Console.ReadLine());
            Console.Write("Saisissez la troisieme valeur :");
            c = int.Parse(Console.ReadLine());
            int[] tableau = { a, b, c };
            Console.WriteLine("la valeur minimale entre les trois est:" + tableau.Min());
            Console.WriteLine("la valeur maximale entre les trois est:" + tableau.Max());
            Console.ReadLine();


            

            exercice7:
            

            int a;
            int b;
            char op;
            Console.Write("Saisissez la premiere valeur :");
            a = int.Parse(Console.ReadLine());
            Console.Write("Saisissez la deuxieme valeur :");
            b = int.Parse(Console.ReadLine());
            Console.Write("Saisissez l'operateur :");
            op = char.Parse(Console.ReadLine());
            switch (op) {


                case  '+':
            
                Console.WriteLine("Le resultat de l'operation a+b est :" + (a + b));
                    break;
                case '-':

                    Console.WriteLine("Le resultat de l'operation a+b est :" + (a + b));
                    break;
                case '*':

                    Console.WriteLine("Le resultat de l'operation a+b est :" + (a + b));
                    break;
                case '/':

                    Console.WriteLine("Le resultat de l'operation a+b est :" + (a + b));
                    break;

                default:
                    Console.WriteLine("L'operateur saisie n'est pas bon");
                    break;
            }


            Console.ReadLine();


            

            exercice8:
            
            int i;
            int j;
            Console.Write("saisissez les coordonnées en x :");
            i = int.Parse(Console.ReadLine());
            Console.Write("saisissez les coordonnées en y :");
            j = int.Parse(Console.ReadLine());
            if ((i + j) % 2 == 0)
            {
                Console.WriteLine("La couleur de la case est noir");
            }
            else
            {
                Console.WriteLine("La couleur de la case est blanche");
            }


            exercice9:
            
            int i;
            int j;
            int i2;
            int j2;
            Console.Write("saisissez les coordonnées en x :");
            i = int.Parse(Console.ReadLine());
            Console.Write("saisissez les coordonnées en y :");
            j = int.Parse(Console.ReadLine());
            Console.Write("saisissez les coordonnées en x2 :");
            i2 = int.Parse(Console.ReadLine());
            Console.Write("saisissez les coordonnées en y2 :");
            j2 = int.Parse(Console.ReadLine());

            if ((i2 == i+2 && (j2 == j+1 || j2 ==j-1)) || (i2 == i-2 && (j2 == j + 1 || j2 == j - 1)) || (j2 == j-2 && (i2 == i - 1 || i2 == i + 1)) || (j2 == j + 2 && (i2 == i - 1 || i2 == i + 1)))
                    {
                Console.WriteLine("Deplacement possible");
            }


            exercice10:
            */

            int i;
            int j;
            int i2;
            int j2;
            Console.Write("saisissez les coordonnées en x :");
            i = int.Parse(Console.ReadLine());
            Console.Write("saisissez les coordonnées en y :");
            j = int.Parse(Console.ReadLine());
            Console.Write("saisissez les coordonnées en x2 :");
            i2 = int.Parse(Console.ReadLine());
            Console.Write("saisissez les coordonnées en y2 :");
            j2 = int.Parse(Console.ReadLine());

            if (Math.Abs()==0)  (Math)




























        }



    }
}

