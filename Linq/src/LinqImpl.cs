using System.Collections.Generic;
using System.Linq;

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
            return new string[0];
        }

        public IEnumerable<string> SkipFiveTakeFive()
        {
            return new string[0];
        }
        
        public int NbElement()
        {
            return 0;
        }

        public int Somme(List<int> entiers)
        {
            return 0;
        }
        
        public int SommeImpair(List<int> entiers)
        {
            return 0;
        }
    }
}