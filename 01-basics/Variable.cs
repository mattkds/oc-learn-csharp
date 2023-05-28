using System;

public class Variable
{

    public void launchTest()
    {
        // declare a variable int named currentAllocation
        int currentAllocation = 200;
        // declare a variable int named saving
        int saving = 3000;

        // TODO : create a int variable int named prime with an inital value 500
        int prime = 500;

        string texte = "Chaine de caractères";
        int nombreDeVoyelles = 0;
        double pourcentageDeVoyelles = 0.0;

        // Constantes
        const int nombreJoursSemaine = 7;
        const string glace = "Crème glacée";
        const string monAlimentPrefere = glace;
        // const string monAlimentPrefere = glace; // Erreur, const can't be initialize with variable value

        int nombreAnimauxDomestiques = 1;
        string saisonActuelle = "Hiver";

        // Print result
        Console.WriteLine("Your current allocation is " + currentAllocation);
        Console.WriteLine("Your saving amount is " + saving);
        Console.WriteLine("You've got a prime of  " + prime);

        // End Exercice
        // TODO, étape 1 :
        // Créer une variable nommée jourDeDepart avec pour valeur initiale 3
        int dayStart = 3;
        // TODO, étape 2 :
        // Créer une constante nommée joursDansSemaine avec pour valeur 7
        const int daysInWeek = 7;
        // TODO, étape 3 :
        // Utiliser un opérateur de raccourci pour ajouter la valeur de la constante joursDansSemaine à la variable jourDeDepart
        dayStart += daysInWeek;
        // Afficher le résultat 
        Console.WriteLine("There are " + daysInWeek + " days in a week.");
        Console.WriteLine("Your Day start is : " + dayStart);


        // Types -  Mélanges de types numérique
        int integerA = 10;
        double integerB = 4;
        int integerC = integerA / (int)integerB; //-> c contient 2, car a/(int) b est une division entière
        Console.WriteLine("Result Integer : " + integerC);
        double doubleC = integerA / (double)integerB; //-> c contient 2,5, car la valeur de b est convertie en double
        Console.WriteLine("Result Double : " + doubleC);


        // String
        string twon = "New York";
        string pet;
        string emptyString = "";

        string favoriteFirstTown = "New York";
        string favoriteSecondTown = "Buenos Aires";
        string favorites = "My favorites Town are " + favoriteFirstTown + " et " + favoriteSecondTown;
        Console.WriteLine(favorites);
    }
}
