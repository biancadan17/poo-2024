namespace poo;

public class CererePreAprobare
{
    public int Id { get; set; }
    public string Destinatie { get; set; }
    public string Motiv { get; set; }
    public DateTime Data { get; set; }
    public int Durata { get; set; }
    public decimal Buget { get; set; }
    public string Detalii { get; set; }
    public TipDeplasare Tip { get; set; }
    public bool Aprobat { get; set; }

    public void Afiseaza()
    {
        Console.WriteLine($"ID: {Id}, Destinatie: {Destinatie}, Motiv: {Motiv}, Tip: {Tip}, Aprobat: {Aprobat}");
    }
}