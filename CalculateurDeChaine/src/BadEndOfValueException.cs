using System;

namespace CalculateurDeChaine
{
    public class BadEndOfValueException : Exception
    {
        public BadEndOfValueException() : base("Regardez la fin de votre valeur")
        {
            
        }
    }
}