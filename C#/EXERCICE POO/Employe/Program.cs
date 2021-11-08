using System;
using System.Collections.Generic;

namespace Employe
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2015, 3, 9, 0, 0, 0, 0);
            DateTime dt1 = new DateTime(2000, 3, 9, 0, 0, 0, 0);
            DateTime dt2 = new DateTime(2008, 3, 9, 0, 0, 0, 0);
           
            Employe emp1 = new Employe();
            Employe emp2 = new Employe("DUCOND", "bernard",dt, 3500, "comptabilité");
            Employe emp3 = new Employe("DUPOND", "bernard", dt1, 3500, "comptabilité");
            Employe emp4 = new Employe("DUROND", "bernard", dt2, 3500, "comptabilité");

            List<string> employé = new List<string>();

            emp1.Temps();
            emp1.Prime();

        }
    }
}
