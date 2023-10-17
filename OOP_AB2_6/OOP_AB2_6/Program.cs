using static System.String;
namespace OOP_AB2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Deklaration Variablen & Defaults
            string Eingabe;

            // Aufforderung zur Eingabe
            Console.WriteLine("Bitte E-Mail Addresse Eingeben: ");
            Eingabe = Console.ReadLine();

            // Prüfung @ Zeichen
            if (Eingabe.Contains('@'))
            {
                // Prüfung ob Empfänger vorhanden
                if (Eingabe.StartsWith('@'))
                {
                    Console.WriteLine("Es fehlt der Empfänger!");
                }
                // Prüfung ob Domain vorhanden
                else if (Eingabe.EndsWith('@'))
                {
                    Console.WriteLine("Es fehlt die Domäne!");
                }
                // Prüfung ob Domain korrekt
                else
                {
                    if (Eingabe.Contains('.') && Eingabe.IndexOf('@') < Eingabe.IndexOf('.'))
                    {
                        Console.WriteLine("Eingabe korrekt");
                    }
                    else
                    {
                        Console.WriteLine("Domäne nicht korrekt!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Es gibt ein @ Zeichen!");
            }
        }
    }
}