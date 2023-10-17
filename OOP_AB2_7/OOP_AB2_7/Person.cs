using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AB2_7
{
    internal class Person
    {
        private string vorname;
        private string nachname;
        private Sprache sprache;

        public Person(string vorname, string nachname, Sprache sprache)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.sprache = sprache;
        }

        public void SageHallo()
        {
            if (sprache == Sprache.Deutsch)
            {
                Console.WriteLine("Guten Tag ich heisse {0} {1}", vorname, nachname);
            }
            else if (sprache == Sprache.Französisch)
            {
                Console.WriteLine("Bonjour je m'appelle {0} {1}", vorname, nachname);
            }
            else if (sprache == Sprache.Englisch)
            {
                Console.WriteLine("Hello my name is {0} {1}", vorname, nachname);
            }
            else
            {
                Console.WriteLine("nuqneH");
            }
        }
    }
    enum Sprache { Deutsch, Französisch, Englisch }
}
