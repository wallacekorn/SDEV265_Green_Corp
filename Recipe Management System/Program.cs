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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LoadRecipeFileAndWelcomeScreen();
        }

        // Loads the recipe file and initializes the WelcomeScreen/application
        static void LoadRecipeFileAndWelcomeScreen()
        {

            string appFolder = AppDomain.CurrentDomain.BaseDirectory;

            // Finds the default filepath and filename to get the .csv filepaths
            string recipeFilePath = Path.Combine(appFolder, "recipes", "Recipes.csv");
            string ingredientsFilePath = Path.Combine(appFolder, "recipes", "Ingredients.csv");
            string directionsFilePath = Path.Combine(appFolder, "recipes", "Directions.csv");

            if (!string.IsNullOrEmpty(recipeFilePath) && !string.IsNullOrEmpty(ingredientsFilePath) && !string.IsNullOrEmpty(directionsFilePath))
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