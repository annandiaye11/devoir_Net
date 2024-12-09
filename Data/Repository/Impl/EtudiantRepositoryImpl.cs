using DevoirNet.Data.Entities;

namespace DevoirNet.Data.Repository.Impl;

public class EtudiantRepositoryImpl : IEtudiantRepository
{
    private readonly List<Etudiant> etudiants  = new List<Etudiant>();
    private readonly CoursRepositoryImpl coursesRepository = new CoursRepositoryImpl();
    private readonly AbsencesRepositoryImpl absencesRepository = new AbsencesRepositoryImpl();
    public List<Etudiant> SelectAll()
    {
        return etudiants;
    }

    public List<Cours> ListerCours(string etudiantId)
    {
       return  coursesRepository.ListerCours(etudiantId);
    }

    public List<Absences> listerAbsences(string etudiantId)
    {
        return absencesRepository.ListerAbsences(etudiantId);
    }
}