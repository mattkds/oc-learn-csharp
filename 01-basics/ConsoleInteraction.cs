using System;
namespace basics
{
	public class ConsoleInteraction
	{

        public void launchTest()
        {
            string url = AskUrlFromUSer();

            Console.WriteLine("Vérification de l'URL " + url);

            if (URLValide(url))
            {
                Console.WriteLine(url + " est une URL valide");
            }
            else
            {
                Console.WriteLine(url + " n'est pas une URL valide");
            }
        }

		public static string AskUrlFromUSer()
		{
            Console.WriteLine("Veuillez saisir une URL valide");
            string url = Console.ReadLine();
            return url;
        }

        private static bool URLValide(string chaineUrl)
        {
            if (Uri.IsWellFormedUriString(chaineUrl, UriKind.Absolute))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

