namespace poo;

public class Manager
{
    public void AprobaCererePreAprobare(GestionareCereriPreAprobare gestionare)
    {
        Console.Write("Introduceti ID-ul cererii de aprobat: ");
        int id = int.Parse(Console.ReadLine());
        var cerere = gestionare.cereri.Find(c => c.Id == id);

        if (cerere != null)
        {
            cerere.Aprobat = true;
            Console.WriteLine("Cerere aprobata cu succes!");
        }
        else
        {
            Console.WriteLine("Cerere inexistenta.");
        }
    }
    public void AprobaDecontare(GestionareDecontari gestionare)
    {
        Console.Write("Introduceti ID-ul cererii de decontare de aprobat: ");
        int id = int.Parse(Console.ReadLine());
        var decont = gestionare.decontari.Find(d => d.Id == id);

        if (decont != null)
        {
            decont.Aprobat = true;
            Console.WriteLine("Cerere de decontare aprobata cu succes!");
        }
        else
        {
            Console.WriteLine("Cerere de decontare inexistenta.");
        }
    }
}

