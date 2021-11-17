using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Cercle
    { 
    public int Diametre { get; set; }

        public Cercle(int diametre)
        {
            Diametre = diametre;
        }

        public Cercle()
    {
        int diametre;
        Console.WriteLine();
        diametre = int.Parse(Console.ReadLine());
             
    }

    public double  Perimetre()
    {
       return  (this.Diametre*Math.PI);
    }

    public double Aire()
    {
           int a = (this.Diametre / 2);
       return (Math.Pow(a,2));
    }

    public override string ToString()
    {
            return "Diametre : " + this.Diametre + "\n"  + this.Perimetre() + "\n" +  this.Aire();
    }
}
}
