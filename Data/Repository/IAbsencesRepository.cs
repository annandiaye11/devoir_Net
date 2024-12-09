using DevoirNet.Core;
using DevoirNet.Data.Entities;

namespace DevoirNet.Data.Repository;

public interface IAbsencesRepository : IRepository<Absences>
{
    List<Absences> ListerAbsences(string etudiantId);

}