namespace DevoirNet.Data.Entities;

public class Etudiant
{
    public string Matricule { get; set; }
    public string NomComplet { get; set; }
    public string Adresse { get; set; }
    public List<Absences> Absences { get; set; } = new List<Absences>();
    public List<Cours> Cours { get; set; } = new List<Cours>();
}