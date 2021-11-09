using System;
using System.Collections.Generic;
using System.Linq;

namespace Employe
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            
            Dictionary<string, int> e1 = new Dictionary<string, int>();           
                e1.Add("J", 5);
                e1.Add("B", 11);
                e1.Add("G", 17);


            Agences a1 = new Agences("A1", "14 rue jsp", 62300, "Lens", "Ticket Restaurant");
            Agences a2 = new Agences("A2", "13 rue jsp", 62300, "Lens", "Restaurant d'entreprise");
            //Employe emp1 = new Employe();
            Employes emp2 = new Employes("DUROND", "Bernard", new DateTime(2015, 3, 9), 22500, "comptabilité", a1, e1);
            Employes emp3 = new Employes("DUPOND", "fernand", new DateTime(2000, 3, 9), 19500, "marketing", a2);
            Employes emp4 = new Employes("DUCOND", "martin", new DateTime(2021, 3, 9), 32500, "informatique", a1);


            //  4.
            List<Employes> employes = new List<Employes>();  
         //   employes.Add(emp1);
            employes.Add(emp2);
            employes.Add(emp3);
            employes.Add(emp4);
            //   employes.Sort(Employes.ComparerToNomPrenom);
            //   employes.Sort(Employes.ComparerServiceToNomPrenom);



            //    double montant=0;
            // 
            //   foreach (Employes i in employes)
            //   {
            //       montant += i.Salaire;
            //       montant += (i.Salaire * 0.05) + i.Salaire*0.02*(today.Year - emp3.DateEmbauche.Year);

            //  }

            //  Console.WriteLine(montant);



            // 6.
            //  foreach (Employes i in employes)
            //  {
            //      Console.WriteLine(i.Agence.ModeRestauration);

            //  }


            //7
            // Employes.Vacances(emp4);

            //8
            Employes.Noel(emp2);


        }


        
    }
}
