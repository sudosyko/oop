using System;
namespace Waschanlage
{
	internal class Waschanlage
	{
		private int anzahlWaschplätze;
		private DateTime[] waschplätze;
		public int AnzahlWaschplätze
		{
			get { return anzahlWaschplätze; }
		}
		public Waschanlage(int anzahlWaschplätze)
		{
			this.anzahlWaschplätze = anzahlWaschplätze;
			waschplätze = new DateTime[anzahlWaschplätze];
		}
		public void WascheFahrzeug(Fahrzeug fahrzeug, int waschplatz, string waschprogramm)
		{
			if (waschplatz < 1 || waschplatz > anzahlWaschplätze)
			{
				Console.WriteLine("Ungültiger Waschplatz");
			}
			else
			{
				if (waschprogramm == "s" || waschprogramm == "m" || waschprogramm == "l")
				{
					if (waschplätze[waschplatz - 1] < DateTime.Now)
					{
						int dauer = 0;
						if (waschprogramm == "s")
						{
							dauer = 30;
							fahrzeug.Verschmutzungsgrad -= 50;
						}
						else if (waschprogramm == "m")
						{
							dauer = 60;
							fahrzeug.Verschmutzungsgrad -= 80;
						}
						else if (waschprogramm == "l")
						{
							dauer = 90;
							fahrzeug.Verschmutzungsgrad -= 100;
						}
						waschplätze[waschplatz - 1] = DateTime.Now.AddSeconds(dauer);
						Console.WriteLine($"Ihr Fahrzeug {fahrzeug.Bezeichnung} wird gewaschen und ist fertig {waschplätze[waschplatz-1]}");
					}
					else
					{
						Console.WriteLine("Der Waschplatz: " + waschplatz+ " ist leider schon besetzt");
					}
				}
				else
				{
					Console.WriteLine("Ungültiges Waschprogramm");
				}
			}
		}
	}
}