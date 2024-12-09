using DevoirNet.Data.Entities;
using DevoirNet.Service.Impl;

namespace DevoirNet.View;

public abstract class EtudiantView
{
    private Etudiant etudiant = new Etudiant();
    private  EtudiantServImpl etudiantServ;
    public  void ListerCoursEtudiant()
    {
        var mat = etudiant.Matricule;
        List<Cours> courses = etudiantServ.FindCours(mat);
        foreach (var cours in courses)
        {
            Console.WriteLine(cours.ToString());
        }
    }
    
    public  void ListerAbsencesEtudiant()
    {
        var mat = etudiant.Matricule;
        List<Absences> absences = etudiantServ.FindAbsences(mat);
        foreach (var absence in absences)
        {
            Console.WriteLine(absence.ToString());
        }
    }
}