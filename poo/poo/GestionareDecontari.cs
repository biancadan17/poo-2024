namespace poo;

public class GestionareDecontari
{
    public List<CerereDecontare> decontari = new List<CerereDecontare>();
    private int idCounter = 1;

    public void CreeazaDecontare(int idCererePreAprobare)
    {
        var decont = new CerereDecontare
        {
            Id = idCounter++,
            IdCererePreAprobare = idCererePreAprobare,
            Aprobat = false
        };
        Console.WriteLine("Introduceti documente justificative:");
        while (true)
        {
            Console.Write("Tip document (0 - Transport, 1 - Masa, 2 - Cazare, -1 pentru a iesi): ");
            int tip = int.Parse(Console.ReadLine());
            if (tip == -1) break;

            var document = new DocumentJustificativ
            {
                Tip = (TipDocument)tip
            };
            Console.Write("Suma: ");
            document.Suma = decimal.Parse(Console.ReadLine());

            Console.Write("Detalii: ");
            document.Detalii = Console.ReadLine();

            decont.Documente.Add(document);
        }
        decontari.Add(decont);
        Console.WriteLine("Cerere de decontare creata cu succes!");
    }

    public void VizualizeazaDecontari()
    {
        foreach (var decont in decontari)
        {
            Console.WriteLine($"ID: {decont.Id}, ID Cerere: {decont.IdCererePreAprobare}, Aprobat: {decont.Aprobat}");
        }
    }
}


public enum TipDocument
{
    Transport,
    Masa,
    Cazare
}