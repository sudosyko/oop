namespace OOP_AB1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Listen deklaration & Erklärung
            List<int> BenutzerTipps = new List<int>();
            List<int> Auslosung = new List<int>();
            Console.WriteLine("Bitte geben Sie Ihre Tipps ab (1-45)");

            // Eingabe Tipps
            for (int i = 1; i < 7 ; i++)
            {
                Console.Write("Tipp " + i + ": ");
                BenutzerTipps.Add(int.Parse(Console.ReadLine()));
            }

            // Auslosung
            Console.WriteLine("Es wurden folgende Zahlen gezogen:");
            Random random = new Random();

            for (int i = 1;i < 7 ; i++)
            {
                int losNr = random.Next(1, 45);
                Auslosung.Add(losNr);
                Console.Write(losNr + " ");
            }
            Console.WriteLine();

            // Vergleich
            int anzahlHits = 0;
            foreach (int losNr in Auslosung)
            {
                bool hits = false;
                foreach (int tipp in BenutzerTipps)
                {
                    if (losNr == tipp)
                    {
                        hits = true;
                        Console.WriteLine("Treffer: " + losNr);
                    }
                }
                if (hits) anzahlHits++;
            }
            // Output Anzahl Treffer
            Console.WriteLine("Sie haben " + anzahlHits + " Treffer erzielt.");

        }
    }
}