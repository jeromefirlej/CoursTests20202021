using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Bogus;

using System.Linq;
using System.Security.Cryptography;

namespace ExamplesLinq
{
    class Program
    {
        private static Eleve[] NotesTP = new Faker<Eleve>()
            .RuleFor(eleve => eleve.Nom, f => $"{f.Person.FirstName} {f.Person.LastName}")
            .RuleFor(eleve => eleve.Note, f => (int) f.Finance.Amount(0,20,0))
            .Generate(10)
            .ToArray();
        
        static void Main(string[] args)
        {
            IEnumerable<Eleve> result;
            Array.ForEach(NotesTP, n => Console.WriteLine($"Eleve {n.Nom} - Note {n.Note}"));

            //Where simple
            /*result = from element in NotesTP
                where element.Nom.Contains("a")
                select element;*/

            result = NotesTP
                .Where(element => element.Nom.Contains("a"));
            
            //filtre des notes
            var notes = NotesTP
                .Where(element => element.Nom.Contains("a"))
                .Select(e => e.Note);
            
            // trie
            result = from element in NotesTP
                where element.Nom.Contains("a")
                orderby element.Note descending // ascending par défaut
                select element;
            
            result = NotesTP
                .Where(element => element.Nom.Contains("a"))
                //.OrderBy(element => element.Note);
                .OrderByDescending(element => element.Note);
            
           
            
            
            Console.WriteLine("\n\nResultat");
            foreach (var eleve in result)
            {
                Console.WriteLine($"Eleve {eleve.Nom} - Note {eleve.Note}");
            }
            
            // Premier element
            var eleveFirst = NotesTP.First();
            
            eleveFirst = NotesTP
                .First(e => e.Nom.Contains("e"));
            
            Console.WriteLine("\n\nFirst");
            Console.WriteLine($"Eleve {eleveFirst.Nom} - Note {eleveFirst.Note}");
            
            // Seul element
            var eleveSingle = NotesTP.Single();
            
            eleveSingle = NotesTP
                .Single(e => e.Nom.Contains("e"));
            
            Console.WriteLine("\n\nFirst");
            Console.WriteLine($"Eleve {eleveFirst.Nom} - Note {eleveFirst.Note}");
        }
    }
}