namespace DevoirNet.Data.Entities;

public class Absences
{
    private int Id { get; set; }
    private DateTime Date { get; set; }
    private Cours Cours { get; set; }   
    private Etudiant Etudiant { get; set; }
}