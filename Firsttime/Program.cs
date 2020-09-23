using System;
using System.Collections.Generic;

namespace Firsttime
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> employees = new List<Person>(){
                new Employe("Thomas","Käfer",new DateTime(2002,12,7),2897.99m,88,6m),
                new Employe("Tobi","Lazer",new DateTime(2001,11,9),2497.99m,8,29m),
                new Employe("Julian","Madersbacher",new DateTime(2012,1,1),2697.99m,3,13m)
            };
            
            // Bei der Zuweisung wird die jeweilige setmethode aufgerufen.
            Console.WriteLine(employees);

        }
    }
}
