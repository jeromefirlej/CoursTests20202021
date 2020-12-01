using System;
using Xunit;
using Xunit.Abstractions;

namespace CalcultriceDelegate.Tests
{
    public class Calculatrice_EqualShould
    {
        [Fact]
        public void Addition_QuandJAiUneAddition()
        {
            Calculatrice calculatrice = new Calculatrice();

            var resultat = calculatrice.Equal("+",1, 1);

            Assert.Equal(2, resultat);
        }
        
        
        [Theory]
        [InlineData(6,2,3)]
        [InlineData(8,2,4)]
        public void Diviser_QuandJAiUneDivision(int number1, int number2, int expected)
        {
            Calculatrice calculatrice = new Calculatrice();

            var resultat = calculatrice.Equal("/",number1, number2);

            Assert.Equal(expected, resultat);
        }
        
        [Theory]
        [InlineData(6,2,12)]
        [InlineData(8,2,16)]
        public void Multiplier_QuandJAiUneMultiplication(int number1, int number2, int expected)
        {
            Calculatrice calculatrice = new Calculatrice();

            var resultat = calculatrice.Equal("*",number1, number2);

            Assert.Equal(expected, resultat);
        }
        
        [Theory]
        [InlineData(6,2,4)]
        [InlineData(8,2,6)]
        public void Soustraire_QuandJAiUnMoins(int number1, int number2, int expected)
        {
            Calculatrice calculatrice = new Calculatrice();

            var resultat = calculatrice.Equal("-",number1, number2);

            Assert.Equal(expected, resultat);
        }

        [Theory]
        [InlineData(1, 6, 2, 3)]
        [InlineData(2, 8, 2, 2)]
        [InlineData(4, 8, 2, 1)]
        [InlineData(4, 16, 2, 2, 1)]
        [InlineData(8, 32, 2, 2, 1)]
        public void DiviserParUnNombreIndetermineDeNombres_QuandJAiUneDivision(
            int expected, params int[] numbers)
        {
            Calculatrice calculatrice = new Calculatrice();

            var resultat = calculatrice.Equal("/", numbers);

            Assert.Equal(expected, resultat);
        }
        
        [Fact]
        public void RenvoieUneException_PourUnOperateurNonSupporte()
        {
            Calculatrice calculatrice = new Calculatrice();

           Assert.Throws<NotSupportedException>(() => calculatrice.Equal("@",1, 1));
        }
    }
}
