using DevoirNet.Data.Entities;
using DevoirNet.Data.Repository;

namespace DevoirNet.Service.Impl;

public class EtudiantServImpl : IEtudiantServ
{
    private readonly IEtudiantRepository etudiantRepository;
    public List<Cours> FindAll(string keyword)
    {
        return etudiantRepository.ListerCours(keyword);
    }

    public List<Absences> FindAbsences(string keyword)
    {
        return etudiantRepository.listerAbsences(keyword);
    }

    public List<Cours> FindCours(string keyword)
    {
        return etudiantRepository.ListerCours(keyword);;
    }
}