using System;
namespace basics
{
	public class Collections
	{
        public void launchTest() {
            // Déclarer la variable
            int[] coffeesByDayOfWeek;
            // Créer l'array et l'affecter à la variable
            coffeesByDayOfWeek = new int[7];
            //Créer un nouvel array avec toutes les valeurs et l'affecter à notre variable
            coffeesByDayOfWeek = new int[] { 6, 2, 3, 7, 3, 4, 1 };
            // Exerice
            // TODO : Déclarer une variable nommée couleurs d'un array de chaînes de longueur 5
            string[] colors;
            colors = new string[5];
            // TODO : Remplir le tableau avec les couleurs demandées
            colors = new string[] { "green", "red", "blue", "violet", "black" };

            // TODO : Remplacer vert par émeraude dans le tableau
            colors[0] = "Emeraude";

            // Afficher le contenu du tableau
            foreach (String color in colors)
            {
                Console.WriteLine(color);
            }


            // Use Lists
            IList<int> myIntegerList = new List<int> { 1, 2, 3, 4, 5, 6 };
            myIntegerList.Add(7);
            myIntegerList.Add(8);
            myIntegerList.Insert(0, 0);
            myIntegerList.RemoveAt(2);
            Console.WriteLine(myIntegerList.Count); // -> 2

            // Set (Ensemble) Collection of uniques non ordonned
            ISet<string> ingredients = new HashSet<string>();
            ingredients.Add("oeufs");
            ingredients.Add("sucre");
            ingredients.Add("beurre");
            ingredients.Add("sel");
            // To delete an element
            ingredients.Remove("sel"); // Supprimer le sel de la liste des ingrédients
            Console.WriteLine(ingredients.Count);

            // Exercice
            // TODO : ajouter un autre ingrédient à l'ensemble
            ingredients.Add("Avocado");

            // TODO : retirer la beurre de l'ensemble
            ingredients.Remove("Beurre");

            // Afficher la liste des ingrédients
            Console.WriteLine("Voici la liste de nos ingrédients");
            foreach (String ingredient in ingredients)
            {
                Console.WriteLine(ingredient);
            }


            // Dictionnary
            IDictionary<string, int> myDictionnary = new Dictionary<string, int>();
            // Définir des clés en tant que constantes
            const string marionKey = "Marion";
            const string MatthieuKey = "Matthieu";
            const string paulKey = "Paul";

            // Utiliser des constantes comme clés
            myDictionnary.Add(marionKey, 24);
            myDictionnary.Add(MatthieuKey, 24);
            myDictionnary.Add(paulKey, 31);

            // Accéder à un élément
            Console.WriteLine(myDictionnary[paulKey]); // -> 31

            // Exerice
            IDictionary<string, int> mois = new Dictionary<string, int>();
            const string juinLabel = "Juin";
            const string septembreLabel = "Septembre";
            const string marsLabel = "Mars";

            // TODO : Remplacer les noms par des constantes de type chaine de caractères
            mois.Add(juinLabel, 6);
            mois.Add(septembreLabel, 9);
            mois.Add(marsLabel, 5);

            // TODO : Corriger la valeur de Mars avec (3)
            mois[marsLabel] = 3;

            // TODO : Retirer Juin
            mois.Remove(juinLabel);

            // Afficher le contenu du dictionnaire
            Console.WriteLine("La liste des mois est :");
            foreach (KeyValuePair<string, int> clePaire in mois)
            {
                Console.WriteLine(clePaire.Key.ToString() + " est le numéro du mois de " + clePaire.Value + " de l'année ");
            }
        }
    }
}

