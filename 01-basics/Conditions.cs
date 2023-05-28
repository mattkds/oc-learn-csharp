using System;

namespace basics
{
	public class Conditions
	{
		public void launchCondition()
		{
            bool leCoursEstExcellent = true;
			Console.WriteLine(leCoursEstExcellent);
            string meteo = "Il fait beau";
            meteo.StartsWith("Il fait"); // -> true

            // If condition
			const string stringCondition = "test unitaire";
			if (stringCondition.Equals("test unitaire")) {
                Console.WriteLine("C'est un test");
            } else if (stringCondition.Equals("test d'intégration")) {
                Console.WriteLine("C'est un test d'intégration");
            } else {
                Console.WriteLine("Ce n'est pas un test");
            }

            IList<string> usernames = new List<string>();
            usernames.Add("user1");
            // Switch
            switch (usernames.Count)
            {
                case 0: // Aucun argument n'a été envoyé
                    Console.WriteLine("Hello World");
                    break;
                case 1: // L'utilisateur a fourni un argument dans le terminal
                    string username = usernames.First();
                    Console.WriteLine("Hello" + username);
                    break;
                default: // L'utilisateur a fourni plus d'arguments que nous ne pouvons en gérer !
                    Console.WriteLine("Désolé, je ne sais pas comment gérer plus de deux prénoms !");
                    break;
            }
        }
	}
}

