using DevoirNet.Data.Entities;
using DevoirNet.Data.Repository;

namespace DevoirNet.Service.Impl;

public class CoursServImpl : ICoursServ
{
    private ICoursRepository coursRepository;
    public List<Cours> GetCourses(string keyword)
    {
        return coursRepository.ListerCours(keyword);
    }
}