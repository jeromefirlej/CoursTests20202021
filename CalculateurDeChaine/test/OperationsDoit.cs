using System;
using Xunit;

namespace CalculateurDeChaine.Test
{
    public class OperationsDoit
    {
        private Operations _operations;
        public OperationsDoit()
        {
            _operations = new Operations();
        }
        
        [Fact]
        public void Retourner0_QuandValeurVide()
        {
            int resultat = _operations.Add(string.Empty /* "" */);
          
            Assert.Equal(0, resultat);
        }
        
        [Theory]
        [InlineData("1", 1)]
        [InlineData("20", 20)]
        [InlineData("35", 35)]
        [InlineData("100", 100)]
        public void RetournerLaValeurEnEntier_QuandValeurEstChaineDe1Caractere
            (string entree, int expected)
        {
            int resultat = _operations.Add(entree);
            
            Assert.Equal(expected, resultat);
        }
        
        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("4,2", 6)]
        public void RetournerLAddition_QuandValeurEstChaineDe2CaracteresSepareParUneVirgule
            (string entree, int expected)
        {
            int resultat = _operations.Add(entree);
            
            Assert.Equal(expected, resultat);
        }
        
        [Theory]
        [InlineData("1,2,5", 8)]
        [InlineData("4,2,5,9,7", 27)]
        public void RetournerLAddition_QuandValeurEstChaineDePlusieursCaracteresSepareParUneVirgule
            (string entree, int expected)
        {
            int resultat = _operations.Add(entree);
            
            Assert.Equal(expected, resultat);
        }
        
        [Theory]
        [InlineData("1\n2", 3)]
        [InlineData("4,2\n5,9,7", 27)]
        public void RetournerLAddition_QuandValeurEstChaineDe2CaracteresSepareParUneVirguleOuUnSautDeLigne
            (string entree, int expected)
        {
            int resultat = _operations.Add(entree);
            
            Assert.Equal(expected, resultat);
        }

        [Fact]
        public void RetourneUneArgumentException_QuandLaChaineFiniParVirguleSautDeLigne()
        {
            string entree = "1,\n";

            Assert.Throws<BadEndOfValueException>(() => _operations.Add(entree));
        }
    }
}
