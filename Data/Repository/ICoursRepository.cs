using DevoirNet.Core;
using DevoirNet.Data.Entities;

namespace DevoirNet.Data.Repository;

public interface ICoursRepository : IRepository<Cours>
{
    List<Cours> ListerCours(string etudiantId);
}