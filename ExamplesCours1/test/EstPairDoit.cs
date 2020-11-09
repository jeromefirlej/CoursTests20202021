using System;
using Microsoft.VisualBasic;
using Xunit;

namespace ExamplesCours.Test
{
    public class EstPairDoit : IDisposable
    {
        private MathUtility math;
        public EstPairDoit()
        {
            math = new MathUtility();
        }
        
        [Fact]
        public void RetournerFaux_QuandNombreEstImpair()
        {
            //Arrange
            int nombre = 1;

            //Act
            bool resultat = math.EstPair(nombre);

            //Assert
            Assert.False(resultat);
            // Assert.Equal(false, resultat);
        }
        
        [Fact]
        public void RetournerVrai_QuandNombreEstPair()
        {
            //Arrange
            int nombre = 2;

            //Act
            bool resultat = math.EstPair(nombre);

            //Assert
            Assert.True(resultat);
            // Assert.Equal(true, resultat);
        }

        public void Dispose()
        {
            // mon code de nettoyage
        }
    }
}
