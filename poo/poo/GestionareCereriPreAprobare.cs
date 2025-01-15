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
    public void VizualizeazaCereri()
    {
        foreach (var cerere in cereri)
        {
            cerere.Afiseaza();
        }
    }
    public void ModificaCerere()
    {
        Console.Write("Introduceți ID-ul cererii de modificat: ");
        int id = int.Parse(Console.ReadLine());
        var cerere = cereri.Find(c => c.Id == id);

        if (cerere != null && !cerere.Aprobat)
        {
            Console.WriteLine("Introduceți noile detalii:");
            Console.Write("Destinație: ");
            cerere.Destinatie = Console.ReadLine();
            Console.Write("Motiv: ");
            cerere.Motiv = Console.ReadLine();
            Console.Write("Buget: ");
            cerere.Buget = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Cerere modificată cu succes!");
        }
        else
        {
            Console.WriteLine("Cererea nu poate fi modificată (aprobată sau inexistentă).");
        }
    }
}
