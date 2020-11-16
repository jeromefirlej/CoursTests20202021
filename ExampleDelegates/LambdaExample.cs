using System;

namespace ExampleDelegates
{
    public class LambdaExample{

         public string ConcatLambda(Func<string,string,string> concatFct){
             return concatFct("lambda", " example");
         }
    }
}