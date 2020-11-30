using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Linq
{
    public class LinqImpl
    {
        public string[] liste = new []
        {
            "avion",
            "armoire",
            "étagère",
            "mère",
            "chien",
            "chat",
            "bière",
            "C#",
            "chaine",
            "maison",
            "voiture",
            "train"
        };
        
         public string[] Contient(char element)
        {
            var resultat = from value in liste
                    where value.Contains(element)
                    orderby value
                    select value;

            resultat = liste
                        .Where(value => value.Contains(element))
                        .OrderBy(value => value);
            return resultat.ToArray();
        }

        public string PremierElement(char element)
        {
            return liste.First(value => value.Contains(element));
        }

        public IEnumerable<char> PremierElementOuNull(char element)
        {
             return liste.FirstOrDefault(value => value.Contains(element));
        }

        public IEnumerable<char> SeulElementOuNull(char element)
        {
            return liste.SingleOrDefault(value => value.Contains(element));
        }

        public IEnumerable<char> SeulElement(char element)
        {
            return liste.Single(value => value.Contains(element));
        }

        public IEnumerable<string> Similaire(string[] strings)
        {
            /* SELECT T_VALUES.VALUE FROM T_VALUES
             * INNER JOIN T_STRINGS ON S_STRINGS.VALUE = T.VALUES.VALUE
             */
            
           /* return from element in liste
                join s in strings 
                on element equals s
                select element;*/

           //return liste.Where(element => strings.Contains(element));
           return liste.Join(strings,
               element => element,
               s => s,
               (element, s) => element);
        }

        public string DernierElement()
        {
            return liste.Last();
        }

        public IEnumerable<string> FirstFive()
        {
            return liste.Take(5);
        }

        public IEnumerable<string> SkipFiveTakeFive()
        {
            return liste
                .Skip(5)
                .Take(5);
        }
        
        public int NbElement()
        {
            return liste.Count();
        }

        public int Somme(List<int> entiers)
        {
            return entiers.Sum();
        }
        
        public int SommeImpair(List<int> entiers)
        {
            return entiers.Where(s => s%2 == 1).Sum();
        }

        public int SommeNoteEleves(List<Eleve> eleves)
        {
            //eleves.Select(e => e.Note).Sum(); <== équivalent
            return  eleves.Sum(e => e.Note);
        }
        
        public class Eleve
        {
            public int Note { get; set; }
        }
    }
}