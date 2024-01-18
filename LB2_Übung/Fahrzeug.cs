using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waschanlage
{
	internal class Fahrzeug
	{
		public string Bezeichnung { get; set; }
		public int Verschmutzungsgrad { get; set; }
		public void Anzeige()
		{
			Console.WriteLine("Fahrzeug: " +  Bezeichnung);
			if(Verschmutzungsgrad >= 0)
			{
				Console.WriteLine("Verschmutzngsgrad : " + Verschmutzungsgrad);
			}
			else
			{
				Verschmutzungsgrad= 0;
				Console.WriteLine("Verschmutzngrad : " + Verschmutzungsgrad );
			}
			
		}
	}
}