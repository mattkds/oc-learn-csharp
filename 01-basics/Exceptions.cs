using System;
namespace Exceptions
{
	public class MathSimple
	{
        public static int CalculMoyenne(List<int> listeDesEntiers)
        {
            int moyenne = 0;

            foreach (int valeur in listeDesEntiers)
            {
                moyenne += valeur;
            }
            moyenne /= listeDesEntiers.Count;

            return moyenne;
        }
    }

    public class ExceptionMainTest {
        public void launchTest(string[] arguments)
        {
            try
            {
                List<int> temperaturesEnregistreesDegresCelcius = new List<int>();

                // Remplir la liste à partir des valeurs fournies comme arguments en ligne de commande
                foreach (string stringRepresentationTemperature in arguments)
                {
                    int temperature = int.Parse(stringRepresentationTemperature);
                    temperaturesEnregistreesDegresCelcius.Add(temperature);
                }

                // Calculer et afficher la température moyenne
                int temperatureMoyenne =
                    MathSimple.CalculMoyenne(temperaturesEnregistreesDegresCelcius);
                Console.WriteLine("La température moyenne est de " + temperatureMoyenne);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Les températures fournies doivent être des nombres");
                Environment.Exit(-1);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Vous devez fournir au moins une température");
                Environment.Exit(-1);
            }
        }
    }
}

