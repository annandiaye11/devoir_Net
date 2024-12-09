using DevoirNet.Data.Entities;

namespace DevoirNet.Service;

public interface IAbsencesServ
{
    List<Absences> GetAbsences(string keyword);
}