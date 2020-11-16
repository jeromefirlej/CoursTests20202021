using System;

namespace CalculateurDeChaine
{
    public class Operations
    {
        public int Add(string values)
        {
            if (string.IsNullOrEmpty(values))
                return 0;

            if (values.EndsWith(",\n"))
            {
                throw new BadEndOfValueException();
            }
            //"1,2" => ["1", "2"]
            //"1" => ["1"]
            var valueTable = values.Split(',','\n');
            int resultat = 0;
            foreach (var value in valueTable)
            {
                resultat += int.Parse(value);
            }

            return resultat;
        }
    }
}
