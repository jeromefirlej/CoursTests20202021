namespace ExampleDelegates
{
    public class DelegateExample{
         public delegate string Concat(string chaine1, string chaine2);

         public string ConcatDelegate(Concat concatFct){
             return concatFct("delegate", " example");
         }
    }
}