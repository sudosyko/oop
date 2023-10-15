using static System.Math;
namespace OOP_AB2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Eingabe;
            Console.WriteLine("Bitte Zahl Eingeben!");
            Eingabe = double.Parse(Console.ReadLine());
            double Ausgabe = Sqrt(Eingabe);
            Console.WriteLine(Ausgabe);
        }
    }
}