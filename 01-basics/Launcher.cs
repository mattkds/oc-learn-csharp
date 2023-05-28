using System;

namespace basics
{
    public class Launcher
    {
        public void launchAll ()
        {
            // Launch Variable
            Variable myVariableTest = new();
            myVariableTest.launchTest();
            // Launch Classes
            Classes classesTest = new Classes();
            classesTest.launchTest();
            // Launch Collections
            Collections collectionsTest = new Collections();
            collectionsTest.launchTest();
            // Launch Collections
            Conditions conditions = new Conditions();
            conditions.launchCondition();
            // Launch interaciton
            ConsoleInteraction consoleInteraction = new ConsoleInteraction();
            consoleInteraction.launchTest();
            // Launch Distant url
            DistantRetrieveUrl distantRetrieveUrl = new DistantRetrieveUrl();
            distantRetrieveUrl.launchTest();
        }
    }
}
