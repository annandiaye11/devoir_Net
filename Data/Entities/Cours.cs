namespace DevoirNet.Data.Entities;

public class Cours
{
    private int Id { get; set; }
    private DateTime Date { get; set; }
    private TimeSpan HeureDebut { get; set; }
    private TimeSpan HeureFin { get; set; }
    private int NombreHeures { get; set; }
    private string Semestre { get; set; }
    private Etudiant Etudiant { get; set; }
}