namespace poo;

public class GestionareCereriPreAprobare
{
    public List<CererePreAprobare> cereri = new List<CererePreAprobare>();
    private int idCounter = 1;

    public void CreeazaCerere()
    {
        var cerere = new CererePreAprobare
        {
            Id = idCounter++,
            Aprobat = false
        };

        Console.Write("Destinație: ");
        cerere.Destinatie = Console.ReadLine();

        Console.Write("Motiv: ");
        cerere.Motiv = Console.ReadLine();

        Console.Write("Data (YYYY-MM-DD): ");
        cerere.Data = DateTime.Parse(Console.ReadLine());

        Console.Write("Durată (zile): ");
        cerere.Durata = int.Parse(Console.ReadLine());

        Console.Write("Buget: ");
        cerere.Buget = decimal.Parse(Console.ReadLine());

        Console.Write("Detalii: ");
        cerere.Detalii = Console.ReadLine();

        Console.Write("Tip (0 - Interna, 1 - Externa): ");
        cerere.Tip = (TipDeplasare)int.Parse(Console.ReadLine());

        cereri.Add(cerere);
        Console.WriteLine("Cerere creată cu succes!");
    }
    
}