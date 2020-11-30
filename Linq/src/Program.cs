using System;
using System.Linq;
using Bogus;
namespace Linq
{
    class Program
    {
        
        
        
        static void Main(string[] args)
        {
            LinqImpl linqImpl = new LinqImpl();
            string[] result = new string[0];
            Console.WriteLine("Entree");
            Array.ForEach(linqImpl.liste, e =>Console.WriteLine("- " +e));

            // liste ordonnée et filtrée
            result = linqImpl.Contient('a');
            Console.WriteLine("Resultat filtre");
            Array.ForEach(result, e =>Console.WriteLine("- " +e));
            
            // premier ou throw 
            var first = linqImpl.PremierElement('a');
            Console.WriteLine("Premier");
            Console.WriteLine(first);
            //first = linqImpl.PremierElement('z');
            Console.WriteLine("Premier");
            Console.WriteLine(first);
            
            // premier ou null 
            var firstordefault = linqImpl.PremierElementOuNull('z');
            Console.WriteLine("Premier ou null");
            Console.WriteLine(firstordefault);
            
            
            // single ou throw 
            var single = linqImpl.SeulElement('m');
            Console.WriteLine("single");
            Console.WriteLine(single);
            //single = linqImpl.SeulElement('z');
            
            // single ou throw 
            single = linqImpl.SeulElementOuNull('z');
            Console.WriteLine("Single or default");
            Console.WriteLine(single);
        }
    }
}
