/*
Group: Green Group
    Date: 05/10/2023
    Program Title: Green Corporation - Recipes Management System
    Purpose: Allows for the storage and editing of Recipe information for the Green corporation.
             Supports CRUD functions for Recipe objects, that contain Name, MealType, Ingredients, and Directions fields. 
*/

namespace Recipe_Management_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); // Intitializes the application configuration
            LoadRecipeFileAndWelcomeScreen();      // Loads the application
        }

        static void LoadRecipeFileAndWelcomeScreen()
        {
            /*
                Automatically loads the recipe, ingredients, and directions csv files if they are in the default location.
                Then boots the Welcome Screen form - the initial viewport for the Recipes management system application
             */

            string appFolder = AppDomain.CurrentDomain.BaseDirectory; // finds the directory that the application is in and stores it

            // Finds the default filepath and filename to get the .csv filepaths
            string recipeFilePath = Path.Combine(appFolder, "recipes", "Recipes.csv");          // Checks the appFolder/recipes/recipes.csv to automatically load data if present
            string ingredientsFilePath = Path.Combine(appFolder, "recipes", "Ingredients.csv"); // Checks the appFolder/recipes/ingredients.csv to automatically load data if present
            string directionsFilePath = Path.Combine(appFolder, "recipes", "Directions.csv");   // Checks the appFolder/recipes/directions.csv to automatically load data if present

            if (!string.IsNullOrEmpty(recipeFilePath) && !string.IsNullOrEmpty(ingredientsFilePath) && !string.IsNullOrEmpty(directionsFilePath)) // if default files are found
            {
                // Sends the file paths to the CSVManager for use in updating the files
                CSVManager.InitializeFilePaths(recipeFilePath, ingredientsFilePath, directionsFilePath);
            }
            else
            {
                Console.WriteLine("Missing one or more file paths");
            }

            // Checks to see if a Recipe.csv file is present (so if it is not the form loads blank)
            string filePath = recipeFilePath;            
            bool filePresent = File.Exists(filePath);

            if (filePresent)
            {
                // Takes the three csv file paths, and builds a list of the Recipe objects from the files
                List<Recipe> recipes = CSVManager.ReadDataFromFiles(recipeFilePath, ingredientsFilePath, directionsFilePath);
                
                // File is present, sends the data to the WelcomeScreen form
                Application.Run(new WelcomeScreen(recipes));
            }
            else
            {
                // No file is present, only loads the WelcomeScreen form
                Application.Run(new WelcomeScreen());
            }
        }
    }
}