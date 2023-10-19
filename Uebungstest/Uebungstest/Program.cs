namespace Uebungstest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Frage und Antwort
            int antwort = ConsolePlus.WriteRead("Wie alt sind Sie?");
            // Unterstrichen schreiben
            ConsolePlus.WriteUnderline("Sie sind also " + antwort + " Jahre alt!");
        }
    }
}
