using DevoirNet.Data.Entities;

namespace DevoirNet.Service;

public interface ICoursServ
{
    List<Cours> GetCourses(string keyword);
}