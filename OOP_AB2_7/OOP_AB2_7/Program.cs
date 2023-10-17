namespace OOP_AB2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Deklaration Liste
            List<Person> friends = new List<Person>();

            //friends hinzufügen
            friends.Add(new Person("Tomislav", "Tofilofski", Sprache.Englisch));
            friends.Add(new Person("Miguel", "Montag", Sprache.Französisch));
            friends.Add(new Person("Enes", "Besic", Sprache.Französisch));
            friends.Add(new Person("Leo", "Pieren", Sprache.Deutsch));
            friends.Add(new Person("Slim", "Shady", Sprache.Englisch));

            //Ausgabe Hallo sagen
            foreach (Person person in friends)
            {
                person.SageHallo();
            }

        }
    }
}