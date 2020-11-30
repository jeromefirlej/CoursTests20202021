using System;
using System.Linq;
using Xunit;

namespace Linq.Tests
{
    public class LinqImplShould
    {
        [Fact]
        public void FctQuiRetourneLesMotsOrdonnesContenantUnCaractere()
        {
            LinqImpl linqImpl = new LinqImpl();
            var expected = new[] {"armoire", "avion", "chaine", "chat", "étagère", "maison", "train"};
            
            var resultat = linqImpl.Contient('a');

            Assert.Equal(expected, resultat);
        }
        
        [Fact]
        public void RetourneLePremierElementContenantUnCaractere()
        {
            LinqImpl linqImpl = new LinqImpl();
            var expected = "armoire";
            
            var resultat = linqImpl.PremierElement('e');

            Assert.Equal(expected, resultat);
        }
        
        [Fact]
        public void RetourneUneExceptionSiLELementNHexistePas()
        {
            LinqImpl linqImpl = new LinqImpl();
            
           Assert.Throws<InvalidOperationException>(() => linqImpl.PremierElement('z'));
        }
        
        [Fact]
        public void RetourneLePremierElementContenantUnCaractere2()
        {
            LinqImpl linqImpl = new LinqImpl();
            var expected = "armoire";
            
            var resultat = linqImpl.PremierElementOuNull('e');

            Assert.Equal(expected, resultat);
        }
        
        [Fact]
        public void RetourneNullSiLELementNHexistePas()
        {
            LinqImpl linqImpl = new LinqImpl();
            string expected = null;
            
            var resultat = linqImpl.PremierElementOuNull('z');

            Assert.Equal(expected, resultat);
        }
        
        [Fact]
        public void FctQuiLeSeulElement()
        {
            LinqImpl linqImpl = new LinqImpl();
            linqImpl.liste = new []{ linqImpl.liste.First() };
            var resultat = linqImpl.SeulElement('a');

            Assert.Equal("avion", resultat);
        }

        [Fact]
        public void FctPlanteSiIlYAPLusDUnElement()
        {
            LinqImpl linqImpl = new LinqImpl();

            Assert.Throws<InvalidOperationException>(() => linqImpl.SeulElement('a'));
        }

        [Fact]
        public void FctQuiLeSeulElement2()
        {
            LinqImpl linqImpl = new LinqImpl();
            linqImpl.liste = new[] { linqImpl.liste.First() };

            var resultat = linqImpl.SeulElementOuNull('a');

            Assert.Equal("avion", resultat);
        }

        [Fact]
        public void FctRetourneNullSiIlYAPlusDUnElement()
        {
            LinqImpl linqImpl = new LinqImpl();

            var resultat = linqImpl.SeulElementOuNull('z');

            Assert.Null(resultat);
        }
        
        [Fact]
        public void FctRetourneLesEgalites()
        {
            string[] param = 
            {
                "armoire",
                "étagère",
                "mère",
                "chaussure"
            };

            LinqImpl linqImpl = new LinqImpl();

            var resultat = linqImpl.Similaire(param);

            Assert.Equal(new[]
            {
                "armoire",
                "étagère",
                "mère"
            }, resultat);

        }
        
        [Fact]
        public void FctQuiLeDernierElement()
        {
            LinqImpl linqImpl = new LinqImpl();
            var resultat = linqImpl.DernierElement();

            Assert.Equal("train", resultat);
        }
        
        [Fact]
        public void FctRetourne5PremierElements()
        {

            LinqImpl linqImpl = new LinqImpl();

            var resultat = linqImpl.FirstFive();

            Assert.Equal(new[]
            {
                "avion",
                "armoire",
                "étagère",
                "mère",
                "chien"
            }, resultat);

        }

        [Fact]
        public void FctRetourne5ElementsSansLes5Premiers()
        {

            LinqImpl linqImpl = new LinqImpl();

            var resultat = linqImpl.SkipFiveTakeFive();

            Assert.Equal(new[]
            {
                "chat",
                "bière",
                "C#",
                "chaine",
                "maison"
            }, resultat);

        }
    }
}