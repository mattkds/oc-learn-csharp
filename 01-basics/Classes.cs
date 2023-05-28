using System;

public class Classes
{
	public void launchTest()
	{
        // Exercice
		// TODO, étape 1 : instancier un objet de la classe Livre et affecter cet objet à une variable nommée monLivre
        Book monLivre = new Book();
		
		// TODO, étape 2 : affecter une valeur aux champs titre, auteur et nombre de pages de votre objet
        monLivre.title = "How to learn c#";
        monLivre.author = "Microsoft";
        monLivre.numberOfPages = 233;
		
		// Afficher le contenu des champs de cet objet 
		Console.WriteLine("Le titre du livre est " + monLivre.title);
		Console.WriteLine("Son auteur est " + monLivre.author);
		Console.WriteLine("Il compte " + monLivre.numberOfPages);
	}
}

class Book
{
    public string title;
    public string author;
    public int numberOfPages;
    public string editor = "MKY";
}

// To instanciate a new object : Book book = new Book("CSharp tutorials", "Microsoft", 223);
// To access to the attributes of a class, common way is to use dot notation : book.title = "new title"; book.numberOfPages = book.numberOfPages + 10;
