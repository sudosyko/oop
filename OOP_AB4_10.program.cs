using Tsbe.Raumfahrt;

namespace AB10LSG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Countrys
            List<Land> laenderListe = new List<Land>();
            laenderListe.Add(new Land() { Name = "USA", Hauptstadt = "Washington DC", ISO3 = "USA", Einwohner = 331900000 });
            laenderListe.Add(new Land() { Name = "Portugal", Hauptstadt = "Lisabon", ISO3 = "PT", Einwohner = 10000000 });
            laenderListe.Add(new Land() { Name = "Schweiz", Hauptstadt = "Bern", ISO3 = "CH", Einwohner = 8000000 });

            // Create Raumschiffe
            List<Raumschiff> RaumschiffListe = new List<Raumschiff>();
            RaumschiffListe.Add(new Raumschiff() { Programm = "Space Shuttle", EinsatzVon = 1981, EinsatzBis = 2011, Land = laenderListe.Find(l => l.ISO3 == "USA")});
            RaumschiffListe.Add(new Raumschiff() { Programm = "Grilliertes Poulet", EinsatzVon = 2023, EinsatzBis = 2024, Land = laenderListe.Find(l => l.ISO3 == "PT")});
            RaumschiffListe.Add(new Raumschiff() { Programm = "Fliegende Bratwurst", EinsatzVon = 1291, EinsatzBis = 2024, Land = laenderListe.Find(l => l.ISO3 == "CH") });

            Console.WriteLine("# RAUMSCHIFFE: ");

            // Output
            foreach (Raumschiff raumschiff in RaumschiffListe)
            {
                Console.WriteLine();
                Console.WriteLine("Programm: " + raumschiff.Programm);
                Console.WriteLine("Land: " + raumschiff.Land.Name);
                // Calculate Operational Time
                int dauer = 0;
                if (raumschiff.EinsatzBis != 0 && raumschiff.EinsatzVon != 0)
                {
                    Console.WriteLine("Einsatz von {0} bis {1}", raumschiff.EinsatzVon, raumschiff.EinsatzBis);
                    dauer = raumschiff.EinsatzBis - raumschiff.EinsatzVon;
                }
                else if (raumschiff.EinsatzVon == 0 && raumschiff.EinsatzBis != 0)
                {
                    Console.WriteLine("Einsatz bis " + raumschiff.EinsatzBis);
                }
                else if (raumschiff.EinsatzVon != 0 && raumschiff.EinsatzBis == 0)
                {
                    Console.WriteLine("Einsatz von " + raumschiff.EinsatzVon);
                    dauer = DateTime.Today.Year - raumschiff.EinsatzVon;
                }

                // Error handling 
                else
                {
                    Console.WriteLine("Einsatz unbekannt");
                }

                // If successfull more than 1 year
                if (dauer != 0)
                {
                    Console.WriteLine("Einsatzdauer: " + dauer + " Jahre"); ;
                }

                // Error handling
                else
                {
                    Console.WriteLine("Einsatzdauer unbekannt");
                }
            }

        }
    }
}

