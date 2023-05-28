using System;
namespace basics
{
	public class AccessControl
	{

		public void launchTest() {
			Licorne licorne = new Licorne();
			Console.WriteLine(licorne.puissance); // OK
			//licorne.taille = 180; // Erreur
			//licorne.Dormir(); // Erreur
			//licorne.Courir(); // OK
		}


		class Licorne
		{
		// Propriétés
		private int taille = 170;
		public string puissance = "Double.infinity";

		// Méthodes
		private void Dormir()
		{}

		public void Courir()
		{}
		}
	}
}

