using DevoirNet.Data.Entities;

namespace DevoirNet.Service;

public interface IEtudiantServ
{
    List<Cours> FindAll(string keyword);
    List<Absences> FindAbsences(string keyword);
    List<Cours> FindCours(string keyword);
}