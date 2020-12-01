using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleEF
{
    public class Eleve
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        
        public double Note { get; set; }
      
    }
}