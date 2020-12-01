namespace ExampleEF
{
    //https://docs.microsoft.com/fr-fr/ef/core/
    public class EleveService{
        public EleveService(IRepository repo){
            Repo = repo;
        }

        public IRepository Repo;

        public void CreerEleve(string nom, double note){
            Repo.Add(new Eleve{
                Nom = nom,
                Note = note
            });
        }
        
        public Eleve GetMeilleurEleve()
        {
            return Repo.GetFirstUpperTo10();
        }

    }
}