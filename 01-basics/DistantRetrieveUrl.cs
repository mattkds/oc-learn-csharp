using System;
using System.Net;

namespace basics
{
	public class DistantRetrieveUrl
	{
        public void launchTest()
        {
            string url =  ConsoleInteraction.AskUrlFromUSer();
            string content = RetrieveContentFromUrl(url);

            try
            {
                WriteInFile(content, "output.txt");
            } catch (IOException e)
            {
                Console.WriteLine("Impossible d'écrire dans le fichier - " + e.ToString());
            }


        }


        /// <summary>
        /// Retourner le contenu de l'URL
        /// </summary>
        /// <param name="url">L'adresse Web de la page</param>
        public static string RetrieveContentFromUrl(string url)
        {
            string contenu = "";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    contenu = webClient.DownloadString(url);
                }
            }
            catch (WebException e)
            {
                Console.WriteLine("Impossible d'établir une connexion - " + e.ToString());
            }

            return contenu;
        }

        /// <summary>
        /// Ecrit dans un fichier
        /// </summary>
        /// <param name="content">contenu du fichier</param>
        /// <param name="output">fichier de sorti</param>

        public static void WriteInFile(string content, string output)
        {
            try
            {
                File.WriteAllText(output, content);
                Console.WriteLine("Écriture terminée dans le fichier " + output);
            }
            catch (IOException e)
            {
                Console.WriteLine("Impossible d'écrire dans le fichier " + output);
            }
        }
    }
}

