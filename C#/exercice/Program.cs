using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice
{
    class Program
    {

        /*
        public static int demanderEntierPositif(string texte)
        {
            int valeur;
            bool conversionReussie;
            do
            {
                Console.WriteLine(texte);
                conversionReussie = int.TryParse(Console.ReadLine(), out valeur);

            } while (!conversionReussie || valeur < 0);
            return valeur;
        }

        public static double Demanderdoublenonnul(string texte)
        {
            double valeur;
            bool conversionreussie;
            do
            {
                Console.WriteLine(texte);
                conversionreussie = double.TryParse(Console.ReadLine(), out valeur);
            } while (valeur != 0 || !conversionreussie);
            return valeur;
        }

        public static double Demanderdouble(string texte)
        {
            double valeur;
            bool conversionreussie;
            do
            {
                Console.WriteLine(texte);
                conversionreussie = double.TryParse(Console.ReadLine(), out valeur);
            } while (!conversionreussie);
            return valeur;
        }

        static double calculSimple(double valeur1, char operateur, double valeur2)
        {
            double resultat=valeur1;
            switch (operateur)
            {
                case '+':
                    resultat = valeur1 + valeur2;
                    break;
                case '-':
                    resultat = valeur1 - valeur2;
                    break;
                case '*':
                    resultat = valeur1 * valeur2;
                    break;
                case '/':
                    resultat = valeur1 / valeur2;
                    break;
                case '$':
                    resultat = Math.Pow(valeur1, valeur2);
                    break;
                default:
                    break;
            }
            return resultat;
        }


        static double Calcul(double valeur, char operateur)
        {
            double result;
            result = 1;

            switch (operateur)
            {
                case 'V':
                    result = Math.Sqrt(valeur);
                    break;

                case '!':                    
                    for (int i = 1; i < valeur; i++)
                    {
                        result *= i;
                    }
                    break;
            }
            return result;
          
        }


        static char DemanderOperateur()
            {
                bool ok = true;
                char op;
                bool condition;

                do
                {
                    Console.Write("Entrez un opérateur +,-,*,/,$,!,V : ");
                    ok = char.TryParse(Console.ReadLine(), out op);
                    condition = !ok || (op != '+' && op != '-' && op != '*' && op != '/' && op != '$' && op != '!' && op != 'V' && op != 'v');
                    if (condition)
                        Console.WriteLine("Saisie incorrecte.");

                } while (condition);
                return char.ToUpper(op);
            }

        */
        static void Main(string[] args)
        {

            /*
             exercice 1 :

                string affiche;
                Console.Write("Saisissez votre nom :");
                affiche = Console.ReadLine();
                Console.WriteLine("Votre nom est:" + affiche);
                Console.ReadLine();
            /*

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


            exercice 3:

             resultat 0 . 4 / 3 . 0 / 11 . 12 . 12 . 04        


            exercice4:

                int val1;
                Console.Write("Saisissez une valeur:");
                val1 = int.Parse(Console.ReadLine());
                while (val1 >= 0)
                {
                    Console.WriteLine(val1--);
                }



                int val;
                Console.WriteLine("Entrez une valeur :");
                val = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine(val--);
                } while (val >= 0);


                int n;

                Console.Write("Saisissez un nombre positif : ");
                n = int.Parse(Console.ReadLine());
                for (int i = n; i >= 0; i--)
                {
                    Console.WriteLine(i);
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






                int valeur;
                int fact = 1;
                int i=1;
                Console.Write("Entrez une valeur entière positive : ");
                valeur = Convert.ToInt32(Console.ReadLine());
                while(i<=valeur)
                {
                    fact *= i++;
                }
                Console.WriteLine("La factorielle de " + valeur + " est " + fact);




            int nb;
            bool val;

            do
            {
                Console.Write("Entrez une valeur entière : ");
                val = int.TryParse(Console.ReadLine(), out nb);
            } while (!val || nb < 0);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(nb + " x " + i + " = " + (nb * i));
            }








                            exercice6:

                            int val1;            
                            Console.Write("Saisissez une valeur:");
                            val1 = int.Parse(Console.ReadLine());
                            for ( int i = 1; i<= 10; i++){
                                Console.WriteLine(val1 + " * " + i + " = " + (val1 * i));   
                            }




                            exercice7:

            int valeur;
            for(int i=1;i <= 10;i++)
            {
                for(int j=1;j <= 10;j++)
                {
                    valeur = i * j;
                    Console.Write(valeur + "," );
                }
                Console.WriteLine("");
            }
            }





                            exercice8:


                            int nombre, puissance;
            int total = 1;
            int i;
            bool boolean;

            do
            {

                Console.WriteLine("entrer le nombre ");
                nombre = int.Parse(Console.ReadLine());
                Console.WriteLine("entrer la puissance ");
                boolean = int.TryParse(Console.ReadLine(), out puissance);

            } while (!boolean || puissance < 0);

            for (i = 1; i <= puissance; i++)
             {
                    total = total * nombre;
             }
             Console.WriteLine("total de l'operation " + total);





                            exercice9:

        int n;         
        Console.Write("Saisissez une valeur:");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {

            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {

                Console.WriteLine("X ");

            }




        }  




        exercice10:

        double value1, value2;
        char operateur;

        value1 = demanderDouble();
        do
        {
            operateur = demanderOperateur();
            switch (operateur)
            {
                case '-' :
                case '+' :
                case '*' :
                    value2 = demanderDouble();
                    value1 = calculSimple(value1, value2, operateur);
                    break;
                case '/' :
                    value2 = demanderDoubleNonNull();
                    value1 = calculSimple(value1, value2, operateur);
                    break;
                case '$':
                    value2 = demanderEntierPositif();
                    value1 = calculSimple(value1, value2, operateur);
                    break;
                case '!':
                    if (value1%1 == 0 && value1 > 0) // On vérifie que value1 est un Entier et qu'il est positif.
                    {
                        value1 = calcul(value1,operateur);
                    }
                    else
                    {
                        Console.WriteLine("Calcul impossible !");
                    }
                    break;
                case 'V':
                    if (value1 > 0) // On vérifie que value1 est positif.
                    {
                        value1 = calcul(value1, operateur);
                    }
                    else
                    {
                        Console.WriteLine("Calcul impossible !");
                    }
                    break;
                case '=':
                    break;
                default:
                    Console.WriteLine("Opérateur incorrect.");
                    break;
            }

            Console.WriteLine("Résultat = " + value1);
            if (operateur == '=')
            {
                Console.WriteLine("Merci d'avoir utiliser cette calculatrice made in AFPA.");
            }
        } while (operateur != '=');




--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        PAGE 5:

         exercice1:

    string chaine = "Les framboises sont perchées sur le tabouret de mon grand-père";

    for (int i= 0; i<chaine.Length; i++){

            while (i < chaine.Length)
            {
                Console.Write(chaine[i]);
                Console.ReadLine();

                i++;
            }
}


        exercice2:
            
            string t, t2 = "" ;
            int ind1, ind2;
            Console.WriteLine("Entrez une chaine de caractere : ");
            t = Console.ReadLine();
            Console.WriteLine("Entrez le premier indice : ");
            ind1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le second indice : ");
            ind2 = int.Parse(Console.ReadLine());
            for (int i = ind1; i < ind2; i++)
            {
                t2 = t2 + t[i];
            }
            Console.WriteLine(t);
            Console.WriteLine(t2);



        exercice3:
            
            string t;
            int i;
            int j;
            string t1 = "";
            string t2 = "";

            Console.WriteLine("Saisissez une chaine");
            t = Console.ReadLine();
            Console.WriteLine("Saisissez un entier");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisissez une entier");
            j = int.Parse(Console.ReadLine());                               
            t1 = t1.Insert(0,t.Substring(i,j));                                            
            Console.WriteLine(t1);


            
        exercice4;
            
            string t;
            string a;
            string b;
            string t1;
            Console.WriteLine("Saisissez une chaine");
            t = Console.ReadLine();
            Console.WriteLine("Saisissez un caractere");
            a = Console.ReadLine();
            Console.WriteLine("Saisissez un caractere");
            b = Console.ReadLine();
            t1=t.Replace(a, b);
            Console.WriteLine(t1);



            exercice5:
            

            StringBuilder t;
            char a, b;

            Console.Write("Entrez la valeur  t : ");
            t = new StringBuilder(Console.ReadLine());
            Console.Write("Entrez la valeur a : ");
            a = Char.Parse(Console.ReadLine());
            Console.Write("Entrez la valeur b : ");
            b = Char.Parse(Console.ReadLine());



            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == a)
                {
                    t[i]= b ;
                }
              

                
            }
            Console.Write(t);




            exercice6:
            
             Console.Write("Entrez le nom du fichier : ");
            string nomFichier = Console.ReadLine();
            Console.WriteLine("Le nom du fichier est : '" + nomFichier.Substring(0, nomFichier.LastIndexOf(".")) + "' et son extention est : '" + nomFichier.Substring(nomFichier.LastIndexOf(".")) + "'");







            exercice7:
            
            string calcul;
            int cptOuv = 0;
            int cptFer = 0;
            int cpt = 0;

            Console.WriteLine("Entrez votre calcul");
            calcul = Console.ReadLine();

            while (cptOuv >= cptFer && cpt < calcul.Length - 1)
            {
                if (calcul[cpt] == '(')
                {
                    cptOuv++;
                } else if (calcul[cpt] == ')')
                {
                    cptFer++;
                }
                
                cpt++;
            }

            if (cptOuv == cptFer)
            {
                Console.WriteLine("expression correctement parenthesée.");
            }
            else
            {
                Console.WriteLine("expression mal parenthesée.");
            }


--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            PAGE 6:





            exercice1:
            
            aRkJ bslk


            exercice2:

            1
            3
            6
            10
            15
            21
            28
            36
            45
            55

            exercice3:
            1
            4
            9
            16
            25
            36
            49
            64
            81
            100


            exercice4:
            
            int[] T = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i=0; i<T.Length;i++)
            Console.WriteLine(T[i]);
            



            exercice5:
            
            int[] k;
            k = new int[10];
            for (int i = 0; i < 10; i++)
            {
                k[i] += i+1;
            }
                foreach (int p in k) {
                    Console.WriteLine(p);
    
                }





          exercice6:
            
            int[] k;        
            k = new int[10];
            int somme = 0;
            for (int i = 0; i < k.Length; i++)
            {
                k[i] += i + 1;
                somme += k[i];

            }
            Console.WriteLine(somme);

            

            



            exercice7:
            
            int[] t = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int cpt = 0;

            Console.WriteLine("Donner un chiffre :");
            int value = int.Parse(Console.ReadLine());

            while (cpt < t.Length && t[cpt] != value)
            {
                cpt++;
            }

            if (cpt < t.Length)
            {
                Console.WriteLine("Bien joué !");
            }
            else
            {
                Console.WriteLine("Le chiffre n'est pas dans le tableau.");
            }
              


                            ou 



            int[] T = new int[10];
            for (int i = 0; i < T.Length; i++)
            {
                T[i] = i + 1;
            }
            Console.WriteLine("Donnez une valeur");
            int t=int.Parse(Console.ReadLine());

            Console.WriteLine(Array.Exists(T, elt=> elt==t));




            exercice8:
            
            int[] k =new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };            
            int[] k2 = new int[10];
            for (int index = 0; index < k.Length; index++)
            {
                if (index == 0)
                {
                    k2[0] = k[k.Length - 1];
                }
                else
                {
                    k2[index] = k[index - 1];

                }

            }
                foreach (int p in k2)
                {
                    Console.WriteLine(p);

                }

          

        exercice9:
            
            int[] k =new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int stock=0;
            int stock2 = 0;
            for (int index = 0; index < k.Length; index++)
            {

                if (index == 0)
                {
                     stock = k[0];
                    k[0] = k[k.Length - 1];

                }
                else
                {
                    stock2 = k[index];
                    k[index] = stock;
                    stock = stock2;
                    

                }

            }
                foreach (int p in k)
                {
                    Console.WriteLine(p);

                }



                        ou


            int[] tableau = new int[10];
            int[] tableauCirculezYaRienAVoir = new int[10];
            for (int i = 0; i < tableau .Length; i++)
                tableau [i] = i + 1;
            for (int i = 0; i < tableau .Length; i++)
                tableauCirculezYaRienAVoir[(i + 1) % tableau .Length] = tableau [i];
            foreach (int p in tableauCirculezYaRienAVoir)
                Console.WriteLine(p);


            exercice10:
            
           

            int[] k = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < k.Length/2 ; i++)
            {
                int jsp = k[i];
                k[i] = k[k.Length - i - 1];
                k[k.Length - i - 1] = jsp;
            }
            foreach (int p in k)
            {
                Console.WriteLine(p);

            }
            /*
            exercice11;

            exercice12;
            
            int[] k = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("la valeur minimale du tableau est : " + k.Min());
            Console.WriteLine("la valeur maximale du tableau est : " + k.Max());
            Console.ReadLine();


            exercice13:
            
            int valeur;
            int[] k = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("Saisissez une valeur : ");
            valeur = int.Parse(Console.ReadLine());
            for( int i=0; i < k.Length; i++)
            {
                if(k[i]== valeur)
                {
                    Console.WriteLine(i);
                }
            }

            
            exercice14:           

            int valeur;
            int[] k = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] q = new int[10] ;
            List<int> liste = new List<int>();
            Console.Write("Saisissez une valeur : ");
            valeur = int.Parse(Console.ReadLine());
            for (int i = 0; i < k.Length; i++)
            {
                if (k[i] == valeur)
                {
                    liste.Add(i);
                    q = liste.ToArray();
                    
                }
            }
            foreach (int p in q)
            {
                Console.WriteLine(p);

            }


            exercice15:
            
            double[] piece = new double[8] {2, 1, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01 };
            int[] nbre = new int[8];
            double prix;
            int i = 0;
            Console.WriteLine("Saisissez un prix : ");
            prix = double.Parse(Console.ReadLine());
            for(i=0; i< piece.Length; i++)
            {
                while (prix >= piece[i] )
                {
                    prix -= piece[i];
                    nbre[i]++;
                    
                }
                                   
            }

            foreach (int p in nbre)
            {
                Console.WriteLine(p +" ");

            }

            
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

           
            PAGE 7:


            exercice;
            */
            int n;
            Console.Write("Saisissez une valeur:");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    if(j==0 || i==n)
                    Console.WriteLine("* ");

                }




            }










        }


    }
}
