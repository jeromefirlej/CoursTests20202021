using System;

namespace ExampleDelegates
{
    class Program
    {
        public static string MaConcatenation(string chaine1, string chaine2)
        {
            return chaine1 + chaine2;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Concat");
            DelegateExample delegateExample = new DelegateExample();
            Console.WriteLine(delegateExample.ConcatDelegate(MaConcatenation));

            Console.WriteLine("Lambda");
            LambdaExample lambdaExample = new LambdaExample();
            Func<string, string, string> concatFct = (chaine1, chaine2) => chaine1 + chaine2;
            Console.WriteLine(lambdaExample.ConcatLambda((chaine1, chaine2) => chaine1 + chaine2));
            Console.WriteLine(lambdaExample.ConcatLambda(concatFct));
            Console.WriteLine(lambdaExample.ConcatLambda(MaConcatenation));
        }
    }
}
