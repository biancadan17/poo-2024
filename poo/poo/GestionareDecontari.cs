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
        Console.WriteLine("Introduceți documente justificative:");
        while (true)
        {
            Console.Write("Tip document (0 - Transport, 1 - Masa, 2 - Cazare, -1 pentru a ieși): ");
            int tip = int.Parse(Console.ReadLine());
            if (tip == -1) break;

            var document = new DocumentJustificativ
            {
                Tip = (TipDocument)tip
            };


        
            

        
    }

}


