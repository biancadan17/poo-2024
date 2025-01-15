namespace poo;

using System;

    class Program
    {
        static void Main(string[] args)
        {
            GestionareCereriPreAprobare gestionareCereri = new GestionareCereriPreAprobare();
            GestionareDecontari gestionareDecontari = new GestionareDecontari();
            Manager manager = new Manager();

            while (true)
            {
                Console.WriteLine("\n===== Meniu Principal =====");
                Console.WriteLine("1. Creează cerere de pre-aprobare");
                Console.WriteLine("2. Vizualizează cereri de pre-aprobare");
                Console.WriteLine("3. Modifică cerere de pre-aprobare");
                Console.WriteLine("4. Creează cerere de decontare");
                Console.WriteLine("5. Vizualizează cereri de decontare");
                Console.WriteLine("6. Aproba cerere de pre-aprobare (Manager)");
                Console.WriteLine("7. Aproba cerere de decontare (Manager)");
                Console.WriteLine("0. Ieșire");
                Console.Write("Alege o opțiune: ");
                
                int optiune;
                if (!int.TryParse(Console.ReadLine(), out optiune))
                {
                    Console.WriteLine("Opțiune invalidă. Încearcă din nou.");
                    continue;
                }

                switch (optiune)
                {
                    case 1:
                        gestionareCereri.CreeazaCerere();
                        break;
                    case 2:
                        gestionareCereri.VizualizeazaCereri();
                        break;
                    case 3:
                        gestionareCereri.ModificaCerere();
                        break;
                    case 4:
                        Console.Write("Introduceți ID-ul cererii de pre-aprobare: ");
                        int idPreAprobare = int.Parse(Console.ReadLine());
                        gestionareDecontari.CreeazaDecontare(idPreAprobare);
                        break;
                    case 5:
                        gestionareDecontari.VizualizeazaDecontari();
                        break;
                    case 6:
                        manager.AprobaCererePreAprobare(gestionareCereri);
                        break;
                    case 7:
                        manager.AprobaDecontare(gestionareDecontari);
                        break;
                    case 0:
                        Console.WriteLine("Ieșire din aplicație...");
                        return;
                    default:
                        Console.WriteLine("Opțiune invalidă. Încearcă din nou.");
                        break;
                }
            }
        }
    }

