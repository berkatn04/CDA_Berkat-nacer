using System;
using System.Collections.Generic;
using System.Linq;

namespace Employe
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2015, 3, 9);
            DateTime dt1 = new DateTime(2000, 3, 9);
            DateTime dt2 = new DateTime(2008, 3, 9);

            //Employe emp1 = new Employe();
            Employe emp2 = new Employe("DUCOND", "bernard", dt, 3500, "comptabilité");
            Employe emp3 = new Employe("DUPOND", "bernard", dt1, 3500, "comptabilité");
            Employe emp4 = new Employe("DUROND", "bernard", dt2, 3500, "comptabilité");

            List<Employe> employes = new List<Employe>();  
            //employes.Add(emp1);
            employes.Add(emp2);
            employes.Add(emp3);
            employes.Add(emp4);
            foreach(Employe i in employes)           
            Console.WriteLine(i);

          
        }
        
    }
}
