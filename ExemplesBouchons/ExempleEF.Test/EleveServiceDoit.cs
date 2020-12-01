using System;
using ExampleEF;
using Xunit;
using Moq;

namespace ExempleEF.Test
{
    public class EleveServiceDoit
    {
        [Fact]
        public void AjouterUnEleve()
        {
            Mock<IRepository> repo = new Mock<IRepository>();
            EleveService eleveService = new EleveService(repo.Object);
            
            eleveService.CreerEleve("Jérôme Firlej", 3);
            
            //pas bon
            /*repo.Verify(f => f.Add(new Eleve{
                Nom = "Jérôme Firlej",
                Note = 3
            }));*/
            
            repo.Verify(f => f.Add(It.IsAny<Eleve>()));
            repo.Verify(f => f.Add(It.Is<Eleve>(
                e => e.Nom == "Jérôme Firlej" && e.Note == 3)));
        }
        
        [Fact]
        public void RenvoyerMeilleurEleve()
        {
            Mock<IRepository> repo = new Mock<IRepository>();
            EleveService eleveService = new EleveService(repo.Object);
            var meilleurEleve = new Eleve
            {
                Nom = "Jean Bon",
                Note = 20
            };
            repo.Setup(f => f.GetFirstUpperTo10())
                .Returns(meilleurEleve);
            
            var result = eleveService.GetMeilleurEleve();
            
            Assert.Equal(meilleurEleve, result);
        }
    }
}
