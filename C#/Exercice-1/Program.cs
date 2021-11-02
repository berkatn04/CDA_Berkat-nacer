using System;
using System.Linq;

namespace Exercice
{
    class Program
    {
        private static object aleatoire;
        private static string boolean;
        private static int a;

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

                 Console.WriteLine((Math.Abs(i - i2) == 2 && Math.Abs(j - j2) == 1 || Math.Abs(i - i2) == 1 && Math.Abs(j - j2) == 2)? "Deplacement possible" : "Deplacement impossible");

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

            Console.WriteLine((Math.Abs(i - i2) == (Math.Abs(j - j2))) ? "Deplacement possible" : "Deplacement impossible");

          

           


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

            Console.WriteLine((Math.Abs(i-i2)==(Math.Abs(j-j2)))||((j2==j) || (i2==i))?"Deplacement possible":"Deplacement impossible");
            
                
            

            exercice10-roi:
           

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

            Console.WriteLine(((Math.Abs(i - i2) < 2 && Math.Abs(j - j2) < 2))?"Deplacement possible":"Deplacement imposssible");




            

                        exercice10- switch:
            

            int i;
            int j;
            int i2;
            int j2;
            string piece="";
            int choix;
            bool boolean = false;
            Console.WriteLine("Quelles piece souhaitez vous deplacer ?\n0=Cavalier\n1=Tour\n2=Fou\n3=Dame\n4=Roi ");
            choix = int.Parse(Console.ReadLine());
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
            switch (choix)
            {


                case 0:
                    piece = "Cavalier";
                    boolean = ((Math.Abs(i - i2) == 2 && Math.Abs(j - j2) == 1) || Math.Abs(i - i2) == 1 && Math.Abs(j - j2) == 2) ? true : false;

                    break;

                case 1:
                    piece = "Tour";
                    boolean = (i == i2 || j == j2) ? true : false;

                    break;

                case 2:
                    piece = "Fou";
                    boolean = (Math.Abs(i - i2) == Math.Abs(j - j2)) ? true : false;

                    break;

                case 3:
                    piece = "Dame";
                    boolean = (Math.Abs(i - i2) == (Math.Abs(j - j2)))|| ((j2 == j) || (i2 == i)) ? true : false;

                    break;

                case 4:
                    piece = "Roi";
                    boolean = (Math.Abs(i - i2) < 2 && Math.Abs(j - j2) < 2) ? true : false;

                    break;

                default:
                    break;


            }


            Console.WriteLine((boolean) ? "Deplacement du"+ piece + " de " + i + "," + j + " vers " + i2 + "," + j2 + "correct" : "deplacement incorrect");


            
                        exercice11:

            int heureDebut;
            int minuteDebut;
            int heureFin;
            int minuteFin;
            int heureDEcart;
            int minuteDEcart;
            Console.WriteLine("heure de début :");
            heureDebut = int.Parse(Console.ReadLine());
            Console.WriteLine("minutes de début :");
            minuteDebut = int.Parse(Console.ReadLine());
            Console.WriteLine("heure de fin :");
            heureFin = int.Parse(Console.ReadLine());
            Console.WriteLine("minutes de fin :");
            minuteFin = int.Parse(Console.ReadLine());
            if (minuteDebut > minuteFin)
            {
                minuteDEcart = 60 - minuteDebut + minuteFin;
                heureDEcart = -1;
            }
            else
            {
                minuteDEcart = minuteFin - minuteDebut;
                heureDEcart = 0;
            }
            if (heureFin > heureDebut || (heureFin == heureDebut && heureDEcart == 0))
            {
                heureDEcart += heureFin - heureDebut;
                Console.WriteLine("L'écart entre " + heureDebut + "h" + minuteDebut + " et " + heureFin + "h" + minuteFin + " est de " + heureDEcart + "h" + minuteDEcart);
            }
            else
            {
                Console.WriteLine("Erreur. L'heure de début est après celle de fin.");
            }


            
            ou:


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

            if ((HD > HF) || (HD == HF && MD > MF))
            {
                Console.WriteLine("ERREUR");

            }
            else
            {
                if (MD == MF)
                {
                    Console.WriteLine("Le temps ecoulé est de :" + (HF - HD) + "h");
                }
                else if (MD > MF)
                {
                    Console.WriteLine("Le temps ecoulé est de :" + ((HF - HD) - 1) + "h" + (60 - MD + MF) + "min");
                }
                else if (MD < MF)
                {
                    Console.WriteLine("Le temps ecoulé est de :" + (HF - HD) + "h" + (MF - MD) + "min");
                }




                if (HD == HF && MD != MF)
                {
                    Console.WriteLine("le temps ecoule est de :" + (MF - MD) + "min");
                }

                else
                {
                    Console.WriteLine("Le temps ecoulé est nulle");
                }

            }    

            


            exercice 12:
           

            int jour;
            int mois;
            int annee;                       
            Console.Write("Saisissez le jour :");
            jour = int.Parse(Console.ReadLine());
            Console.Write("Saisissez le mois :");
            mois = int.Parse(Console.ReadLine());
            Console.Write("Saisissez l'année :");
            annee = int.Parse(Console.ReadLine());
            if (jour <= 31 && mois < 13)
            {
                
                if (mois % 2 == 0)
                {
                    if (jour == 30)
                    {
                        Console.WriteLine("Jour incorrect");
                    }
                    else if (jour == 31 && mois!=12)
                    {
                        jour = 1;
                        mois++;
                    }
                }


                if (mois == 2 && (annee % 4 == 0 && annee % 100 != 0 || annee % 400 == 0))
                {
                    if (jour == 30)
                    {
                        Console.WriteLine("erreur année bisextile");


                    }
                    else if (jour == 29)
                    {
                        jour = 1;
                    }
                }

                if (jour == 31 && mois != 12)
                {
                    jour = 1;
                    mois++;
                }

                


                if (mois == 12 && jour == 31)
                {
                    mois = 1;
                    jour = 1;
                    annee++;
                }

               
            }
            

            Console.WriteLine("le date du lendemain est :" + jour + "/" + mois + "/" + annee);






            exercice13:
            
            int val1;
            int val2;
            int x;
            bool boolean;
            Console.Write("Saisissez le premiere borne :");
            boolean = int.TryParse(Console.ReadLine(), out val1);
            Console.Write("Saisissez la deuxieme borne :");
            boolean = int.TryParse(Console.ReadLine(), out val2);
            Console.Write("Saisissez uen valeur :");
            x  = int.Parse(Console.ReadLine());

            Console.WriteLine((x >= val1 && x <= val2)? "Votre valeur appartient a l'intervalle " + "[" + val1 + "," + val2 + "]": "Votre valeur n'appartient pas a l'intervalle " + "[" + val1 + "," + val2 + "]");
            





            exercice15:
            
            int xhautgauche;
            int yhautgauche;
            int xbasdroit;
            int ybasdroit;
            int xpoint;
            int ypoint;
            bool boolean;
            Console.Write("Saisissez la coordonnée x du premier point du rectangle :");
            boolean = int.TryParse(Console.ReadLine(), out xhautgauche);
            Console.Write("Saisissez la coordonnée y du premier point du rectangle:");
            boolean = int.TryParse(Console.ReadLine(), out yhautgauche);
            Console.Write("Saisissez la coordonnée x du deuxieme point du rectangle :");
            boolean = int.TryParse(Console.ReadLine(), out xbasdroit);
            Console.Write("Saisissez la coordonnée y du deuxieme point du rectangle :");
            boolean = int.TryParse(Console.ReadLine(), out ybasdroit);
            Console.Write("Saisissez la coordonnée x du point:");
            boolean = int.TryParse(Console.ReadLine(), out xpoint);
            Console.Write("Saisissez la coordonnée y du point:");
            boolean = int.TryParse(Console.ReadLine(), out ypoint);
            
            
            Console.WriteLine((xpoint > xhautgauche && xpoint < xbasdroit) && (ypoint > ybasdroit && ypoint < yhautgauche) ? "Votre point se trouve dans le rectangle" : "Votre point ne se trouve pas dans le rectangle");
           

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            PAGE4:



            exercie 1 :

            le programme affiche  5,14 
                                                    
                                       

            exercice 2 :
            
            Le programme affiche 3,4,18,6
        


            exercice4:
            
            int val1;
            Console.Write("Saisissez une valeur:");
            val1 = int.Parse(Console.ReadLine());
            while (val1 >= 0)
            {
                Console.WriteLine(val1--);
            }





            exercice5:
            
            int val1;
            int val2 = 1;
            Console.WriteLine("Saisissez une valeur:");
            val1 = int.Parse(Console.ReadLine());
            for ( int i = 1; i<= val1; i++)
            {
                val2 = val2 * i;
            }

            Console.Write("le factorielle de " + val1 + " est : " + val2);




            exercice6:
            
            int val1;            
            Console.Write("Saisissez une valeur:");
            val1 = int.Parse(Console.ReadLine());
            for ( int i = 1; i<= 10; i++){
                Console.WriteLine(val1 + " * " + i + " = " + (val1 * i));
            }


            exercice8:
            

            int val1;
            int val2=1;
            int exp;
            Console.Write("Saisissez une valeur:");
            val1 = int.Parse(Console.ReadLine());
            Console.Write("Saisissez une valeur:");
            exp = int.Parse(Console.ReadLine());
            a = val1;
            switch (exp)
            {
                case 0 :
                    Console.WriteLine('1');
                    break;
                case 1:
                    Console.WriteLine(val1);
                    break;

                default:
                    for (int i = 1; i < exp; i++)
                    {                      
                            val2 = val1 * a;
                            val1 = val2;                      
                    }
                    Console.WriteLine(val2);
                    break;

            }

           



            exercice9:
            */

            int n;         
            Console.Write("Saisissez une valeur:");
            n = int.Parse(Console.ReadLine());          
            for ( int i=0; i<n;i++)
            {               
                for (int j = 0; j < n; j++)
                {
                    char[,] tab = new char[i, j];
                    tab[i, j] = 'x';
                    Console.WriteLine(tab);
                }
                
            }



            /* exercice10:





























        }

        
    }
}         

