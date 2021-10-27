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
        if (a >=10)
        {
            Console.WriteLine("admis");
        }
        if (a < 8)
        {
            Console.WriteLine("ajournée");
        }
        else
        {
            Console.WriteLine("rattrapage");
        }




        exercice4:

        double franchise = 0;
            Console.WriteLine("Montant des dommages : ");
            franchise = (10 * double.Parse(Console.ReadLine()) / 100);
            if (franchise > 4000)
            {
                Console.WriteLine("Votre franchise est de 4000Euros");
            }
            else
            {
                Console.WriteLine("Votre franchise est de " + franchise + "Euro(s)");
            }




                exercice5:
                        int a;
                        int b;
                        Console.WriteLine("veuillez saisir la 1re valeur");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("veuillez saisir la 2eme valeur");
                        b = Convert.ToInt32(Console.ReadLine());
                        if(a==b)
                        {
                            Console.WriteLine("1 seul valeur distinct");
                        }
                        else
                        {
                            Console.WriteLine("2 valeurs separes");
                        };






        */

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


            /*

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
                    if(b == 0)
                    {
                        Console.WriteLine("Division impossible par 0");
                    }
                    else
                    {
                    Console.WriteLine("Le resultat de l'operation a+b est :" + (a + b));
            }
                    break;

                default:
                    Console.WriteLine("L'operateur saisie n'est pas bon");
                    break;
            }


            Console.ReadLine();


            

            exercice8:
            
            int i;
            int j;
            Console.Write("saisissez la coordonnée en x :");
            i = int.Parse(Console.ReadLine());
            Console.Write("saisissez la coordonnée en y :");
            j = int.Parse(Console.ReadLine());
            if ((i + j) % 2 == 0)
            {
                Console.WriteLine("La couleur de la case est noir");
            }
            else
            {
                Console.WriteLine("La couleur de la case est blanche");
            }


            exercice9-cavalier:
            
            int i;
            int j;
            int i2;
            int j2;
            Console.Write("saisissez la  coordonnée en x :");
            i = int.Parse(Console.ReadLine());
            Console.Write("saisissez la coordonnée en y :");
            j = int.Parse(Console.ReadLine());
            Console.Write("saisissez la coordonnée en x2 :");
            i2 = int.Parse(Console.ReadLine());
            Console.Write("saisissez la coordonnée en y2 :");
            j2 = int.Parse(Console.ReadLine());

            if (Math.Abs(i1 - i2) == 2 && Math.Abs(j1 - j2) == 1 || Math.Abs(i1 - i2) == 1 && Math.Abs(j1 - j2) == 2)

                    {
                Console.WriteLine("Deplacement possible");
            }


            exercice10-fou:
            

            int i;
            int j;
            int i2;
            int j2;
            Console.Write("saisissez la coordonnée en x :");
            i = int.Parse(Console.ReadLine());
            Console.Write("saisissez la coordonnée en y :");
            j = int.Parse(Console.ReadLine());
            Console.Write("saisissez la coordonnée en x2 :");
            i2 = int.Parse(Console.ReadLine());
            Console.Write("saisissez la coordonnée en y2 :");
            j2 = int.Parse(Console.ReadLine());

            if ((Math.Abs(i-i2) == (Math.Abs(j-j2) ))){

                Console.WriteLine("Deplacement possible");
            }
            else
            {
                Console.WriteLine("Deplacement impossible");
            }

            


            exercice10-dame:
            
            int i;
            int j;
            int i2;
            int j2;
            int taille = 8;
            Console.Write("saisissez la coordonnée en x :");
            i = int.Parse(Console.ReadLine());
            Console.Write("saisissez la coordonnée en y :");
            j = int.Parse(Console.ReadLine());
            Console.Write("saisissez la coordonnée en x2 :");
            i2 = int.Parse(Console.ReadLine());
            Console.Write("saisissez la coordonnée en y2 :");
            j2 = int.Parse(Console.ReadLine());

            
            if ((Math.Abs(i-i2)==(Math.Abs(j-j2)))   ||   ((j2==j) || (i2==i)))
            {
                Console.WriteLine("Deplacement possible");

            }
            else
            {
                Console.WriteLine("Deplacement impossible");
            }
            Console.ReadLine();



            exercice10-roi:
            

            int i;
            int j;
            int i2;
            int j2;
            int taille = 8;
            Console.Write("saisissez la coordonnée en x :");
            i = int.Parse(Console.ReadLine());
            Console.Write("saisissez la coordonnée en y :");
            j = int.Parse(Console.ReadLine());
            Console.Write("saisissez la coordonnée en x2 :");
            i2 = int.Parse(Console.ReadLine());
            Console.Write("saisissez la coordonnée en y2 :");
            j2 = int.Parse(Console.ReadLine());

            if ((Math.Abs(j2 - j) <= 1) && (Math.Abs(i2 - i) <= 1))
            {
                Console.WriteLine("Deplacement possible");
                    }
            else
            {
                Console.WriteLine("Deplacement impossible");
            }





            exercice10- switch:
            
            int i;
            int j;
            int i2;
            int j2;
            string piece;
            int choix;
            Console.WriteLine("Quelles piece souhaitez vous deplacer ?\n0=Cavalier\n1=Tour\n2=Fou\n3=Dame\n4=Roi ");
            choix = int.Parse(Console.ReadLine());
            switch (choix)
            {


                case 0:
                    piece = "Cavalier";
                    Console.Write("saisissez la coordonnée en x :");
                    i = int.Parse(Console.ReadLine());
                    Console.Write("saisissez la coordonnée en y :");
                    j = int.Parse(Console.ReadLine());
                    Console.WriteLine("Coordonnées (i,j) de la position de depart :\ni=" + i + "\nj=" + j);
                    Console.Write("saisissez la coordonnée en x2 :");
                    i2 = int.Parse(Console.ReadLine());
                    Console.Write("saisissez la coordonnée en y2 :");
                    j2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Coordonnées (i,j) de la position d'arrivée :\ni2=" + i2 + "\nj2=" + j2);
                    if ((i2 == i + 2 && (j2 == j + 1 || j2 == j - 1)) || (i2 == i - 2 && (j2 == j + 1 || j2 == j - 1)) || (j2 == j - 2 && (i2 == i - 1 || i2 == i + 1)) || (j2 == j + 2 && (i2 == i - 1 || i2 == i + 1)))
                    {
                        Console.WriteLine("Deplacement du cavalier de" + i + "," + j + "vers" + i2 + "," + j2 + "correct");
                    }
                    else
                    {
                        Console.WriteLine("Deplacement impossible");
                    }


                    break;
            
        
                /*
                case '1':
                    piece = "Tour";

                    break;
                case '2':
                    piece = "Fou";

                    break;
                case '3':
                    piece = "Dame";

                    break;
        
                case 4:
                    piece = "Roi";
                    Console.Write("saisissez la coordonnée en x :");
                    i = int.Parse(Console.ReadLine());
                    Console.Write("saisissez la coordonnée en y :");
                    j = int.Parse(Console.ReadLine());
                    Console.WriteLine("Coordonnées (i,j) de la position de depart :\ni=" + i + "\nj=" + j);
                    Console.Write("saisissez la coordonnée en x2 :");
                    i2 = int.Parse(Console.ReadLine());
                    Console.Write("saisissez la coordonnée en y2 :");
                    j2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Coordonnées (i,j) de la position d'arrivée :\ni2=" + i2 + "\nj2=" + j2);
                    if ((Math.Abs(j2 - j) <= 1) && (Math.Abs(i2 - i) <= 1))
                    {
                        Console.WriteLine("Deplacement du roi de " + i + "," + j + " vers " + i2 + "," + j2 + " correct");
                    }
                    else
                    {
                        Console.WriteLine("Deplacement impossible");
                    }


                    break;

                     
            }


            



            exercice11:
            


            int HD;
            int MD;
            int HF;
            int MF;
            int min = 60;
            Console.WriteLine("Saisissez l'heure de debut: ");
            HD = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisissez la minute de debut: ");
            MD = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisissez l'heure de fin: ");
            HF = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisissez la minute de fin: ");
            MF = int.Parse(Console.ReadLine());
            while ( (HD<24 && HF<24 && MD < 60 && MF < 60){
                if (HD > HF)
                {
                    Console.WriteLine("ERREUR");
                }

                if (HD==HF && MD > MF)
                {
                    Console.WriteLine("ERREUR");
                }
                if (HF > HD)
                {
                    if (MD > MF)
                    {
                        Console.WriteLine(
                }
                
            } 





            */






        }



    }
}

