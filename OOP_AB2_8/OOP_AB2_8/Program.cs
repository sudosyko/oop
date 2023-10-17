using Tsbe.CodeCracker;

namespace OOP_AB2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte Passwort eingeben: ");
            string password = Console.ReadLine();
            string hashedPassword = MD5Hash.GeneratePassword(password);
            Console.WriteLine("Your hashed password: " +  hashedPassword);
            Console.Write("Bitte maximale Länge eingeben: ");
            int maxLength = int.Parse(Console.ReadLine());

            //Version mit a-z
            //string hakedPassword = MD5Hash.CrackPassword(hashedPassword, maxLength);
            //if (hakedPassword.Length > 0 )
            //{
            //    Console.WriteLine("Das Passwort wurde entschlüsselt: " + hakedPassword);    
            //}
            //else
            //{
            //    Console.WriteLine("Hack nicht erfolgreich!");
            //}

            // Version mit erlaubten Zeichen
            char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '!', '_', '$', '%', '&', '-', '*', };

            string hakedPassword = MD5Hash.CrackPassword(hashedPassword, maxLength, chars);
            if (hakedPassword.Length > 0 )
            {
                Console.WriteLine("Das Passwort wurde entschlüsselt: " + hakedPassword);    
            }
            else
            {
                Console.WriteLine("Hack nicht erfolgreich!");
            }



        }
    }
}