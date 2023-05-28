using System;
namespace basics
{
	public class Loop
	{
        public void launchLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Applaudissez !");
            }

            // boucles avec collections
            int[] monArray = new int[] { 7, 2, 4 };

            for (int i = 0; i < monArray.Length; i++)
            {
                Console.WriteLine(monArray[i]);
            }
            // ou utilisation de foreach
            foreach (int nombre in monArray)
            {
                Console.WriteLine(nombre);
            }

            // Notations while
            int nombreArbres = 0;

            while (nombreArbres < 10)
            {
                nombreArbres += 1;
                Console.WriteLine("J’ai planté " + nombreArbres + "arbres");
            }

            Console.WriteLine("Je possède une forêt !");

            // notation do While
            int objectifPompe = 10;

            do
            {
                Console.WriteLine("Une pompe !");
                objectifPompe -= 1;
            } while (objectifPompe > 0);


            // mot clé continue
            for (int i = 0; i < 10; i++)
            {
                // Déclarations exécutées à chaque itération
                if (i == 2 || i == 5)
                {
                    continue;
                }
                // Instructions non exécutées lorsque i == 2 ou 5
            }

            // suspendre un boucle avec break
            string[] panier = new string[] { "pomme", "orange", "banane" };

            for (int i = 0; i < panier.Length; i++)
            {
                if (panier[i] == "orange")
                {
                    Console.WriteLine("J'ai une " + panier[i] + " !");
                    break;
                }
            }
        }
	}
}

