using System;
using System.Collections.Generic;
using System.Linq;

namespace CalcultriceDelegate
{
    public class Calculatrice
    {
        private delegate int Operation(int number1, int number2);

        private int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        
        private int Divise(int number1, int number2)
        {
            return number1 / number2;
        }

        private int Multiplier(int number1, int number2)
        {
            return number1 * number2;
        }
        
        private int Soustraire(int number1, int number2)
        {
            return number1 - number2;
        }
        private int TraiterOperation(Operation operation, params int[] numbers)
        {
            int resultat = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                resultat = operation(resultat, numbers[i]);
            }
            return resultat;
        }
        
        public int Equal(string operateur, params int[] numbers)
        {
            switch (operateur)
            {
                case "+":
                    return TraiterOperation(Add, numbers);
                case "/":
                    return TraiterOperation(Divise ,numbers);
                case "*":
                    return TraiterOperation(Multiplier,numbers);
                case "-":
                    return TraiterOperation(Soustraire,numbers);
                default:
                    throw new NotSupportedException();
            }
        }
        
    }
}
