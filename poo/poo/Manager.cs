namespace poo;

public class Manager
{
    public void AprobaCererePreAprobare(GestionareCereriPreAprobare gestionare)
    {
        Console.Write("Introduceți ID-ul cererii de aprobat: ");
        int id = int.Parse(Console.ReadLine());
        var cerere = gestionare.cereri.Find(c => c.Id == id);

        if (cerere != null)
        {
            cerere.Aprobat = true;
            Console.WriteLine("Cerere aprobată cu succes!");
        }
        else
        {
            Console.WriteLine("Cerere inexistentă.");
        }
    }
}
