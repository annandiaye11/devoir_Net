using DevoirNet.Core;
using DevoirNet.Data.Entities;

namespace DevoirNet.Data.Repository.Impl;


public class CoursRepositoryImpl : ICoursRepository
{
    private readonly List<Cours> courslist = new();
    private readonly Etudiant etudiant = new Etudiant(); 
    public List<Cours> SelectAll()
    {
        return courslist;
    }

    public List<Cours> ListerCours(string etudiantId)
    {
        if (string.IsNullOrEmpty(etudiantId))
        {
            Console.WriteLine("etudiant id is empty");
        }

        // Rechercher l'étudiant correspondant à l'ID
        if (etudiant.Matricule != etudiantId)
        {
            Console.WriteLine($"Aucun étudiant trouvé avec l'identifiant : {etudiantId}");
        }
        
        return etudiant.Cours;
    }
}