using Xunit;

namespace FizzBuzzPrj.Test
{
    public class FizzBuzzDoit
    {
        private FizzBuzzClass _fizzBuzzClass;
        
        public FizzBuzzDoit()
        {
            _fizzBuzzClass = new FizzBuzzClass();
        }

        [Fact]
        public void RetournerFizz_QuandNumberEst3()
        {
            // Act
            var result = _fizzBuzzClass.FizzBuzz(3);
            
            //Assert
            Assert.Equal("Fizz", result);
        }
        
        [Fact]
        public void RetournerFizz_QuandNumberEst6()
        {
            // Act
            var result = _fizzBuzzClass.FizzBuzz(6);
            
            //Assert
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void RetournerBuzz_QuandNumberEst10()
        {
            var result = _fizzBuzzClass.FizzBuzz(10);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void RetournerFizzBuzz_QuandNumberEstDivisiblePar5Et3()
        {
            var result = _fizzBuzzClass.FizzBuzz(15);
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void RetournerNombre_DansLesAutresCas()
        {
            int nombre = 1;
            var result = _fizzBuzzClass.FizzBuzz(nombre);
            Assert.Equal(nombre.ToString(), result);
        }
    }
}
