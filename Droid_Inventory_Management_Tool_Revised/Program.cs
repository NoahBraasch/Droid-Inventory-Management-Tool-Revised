using System;
using System.ComponentModel.DataAnnotations;

namespace Droid_Inventory_Management_Tool_Revised
{
    class Program
    {
        static void Main(string[] args)
        {                   

            // Create a new droid collection and set the size of it to 100.
            IDroidCollection droidCollection = new DroidCollection(100);

            droidCollection.Add("Gold", "Red", 3); //protocol
            droidCollection.Add("Gold", "Red", true, true, true, true, 5); // astro
            droidCollection.Add("Gold", "Red", true, true, true); // util
            droidCollection.Add("Gold", "Red", true, true, true, true, true); // janitor
            droidCollection.Add("Gold", "Green", 3); // protocol
            droidCollection.Add("Gold", "Green", true, true, true); // util
            droidCollection.Add("Gold", "Green", true, true, true, true, true); // janitor
            droidCollection.Add("Gold", "Green", true, true, true, true, 5); // astro

            // Create a user interface and pass the droidCollection into it as a dependency
            UserInterface userInterface = new UserInterface(droidCollection);

            // Display the main greeting for the program
            userInterface.DisplayGreeting();

            // Display the main menu for the program
            userInterface.DisplayMainMenu();

            // Get the choice that the user makes
            int choice = userInterface.GetMenuChoice();

            // While the choice is not equal to 4, continue to do work with the program
            while (choice != 4)
            {
                // Test which choice was made
                switch (choice)
                {
                    // Choose to create a droid
                    case 1:
                        userInterface.CreateDroid();
                        break;

                    // Choose to Print the droid
                    case 2:
                        userInterface.PrintDroidList();
                        break;
                    case 3:
                        userInterface.SortDroidList();
                        break;
                }
                // Re-display the menu, and re-prompt for the choice
                userInterface.DisplayMainMenu();
                choice = userInterface.GetMenuChoice();
            }
        }
    }
}
