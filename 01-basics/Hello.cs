using System; // using directive, indicates the namespaces (an assembly of class C#)
namespace basics // here is the namespace of the class
{
	public class Hello
	{
        // this code c# has to be convert on exectubale code (translate on machine langage)
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Launcher launcher = new Launcher();
            launcher.launchAll();
        }
    }
}

