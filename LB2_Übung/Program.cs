namespace Waschanlage
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Fahrzeug fahrzeug1 = new Fahrzeug() { Bezeichnung = "VW", Verschmutzungsgrad = 100 };
			Fahrzeug fahrzeug2 = new Fahrzeug() { Bezeichnung = "BMW", Verschmutzungsgrad = 10 };
			Fahrzeug fahrzeug3 = new Fahrzeug() { Bezeichnung = "Porsche", Verschmutzungsgrad = 50 };

			Waschanlage waschanlage = new Waschanlage(3);

			fahrzeug1.Anzeige();
			waschanlage.WascheFahrzeug(fahrzeug1, 1, "s");
			fahrzeug1 .Anzeige();

			fahrzeug2.Anzeige();
			waschanlage.WascheFahrzeug(fahrzeug2, 1, "m");
			fahrzeug2.Anzeige();

			Thread.Sleep(30001);
			fahrzeug1.Anzeige();
			waschanlage.WascheFahrzeug(fahrzeug1, 1, "l");
			fahrzeug1.Anzeige();
			Console.ReadLine();
		}
	}
}