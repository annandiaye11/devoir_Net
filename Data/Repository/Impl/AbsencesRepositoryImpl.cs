using DevoirNet.Core;
using DevoirNet.Data.Entities;

namespace DevoirNet.Data.Repository.Impl;

public class AbsencesRepositoryImpl : IAbsencesRepository
{
    private readonly List<Absences> absencesList = new();
    private readonly Etudiant etudiant = new Etudiant(); 
    public List<Absences> SelectAll()
    {
        return absencesList;
    }

    public List<Absences> ListerAbsences(string etudiantId)
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
        
        return etudiant.Absences;
    
    }
}