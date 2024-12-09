using DevoirNet.Core;
using DevoirNet.Data.Entities;

namespace DevoirNet.Data.Repository;

public interface IEtudiantRepository : IRepository<Etudiant>
{
    List<Cours> ListerCours(string etudiantId);
    List<Absences> listerAbsences(string etudiantId);
}