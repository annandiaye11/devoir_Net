using DevoirNet.Data.Entities;
using DevoirNet.Data.Repository;

namespace DevoirNet.Service.Impl;

public class AbsenceServImp : IAbsencesServ
{
    private readonly IAbsencesRepository absencesRepository;
    public List<Absences> GetAbsences(string keyword)
    {
        return absencesRepository.ListerAbsences(keyword);
    }
}