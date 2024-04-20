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

            // Process the data from the recipe, ingredients, and directions CSV files
            static List<Recipe> ReadDataFromFiles(string recipeFilePath, string ingredientsFilePath, string directionsFilePath)
            {
                // creates a list object that stores the Recipe objects
                List<Recipe> recipes = new List<Recipe>();

                try
                {
                    // Reads the lines from the three .csv files into arrays
                    string[] recipeLines = File.ReadAllLines(recipeFilePath);
                    string[] ingredientLines = File.ReadAllLines(ingredientsFilePath);
                    string[] directionLines = File.ReadAllLines(directionsFilePath);

                    // Processes each recipe line, splits by comma
                    // then uses the parts to build a Recipe Object
                    // then adds the Recipe object to a list
                    foreach (string recipeLine in recipeLines)
                    {
                        string[] aRecipeSplit = recipeLine.Split(',');
                        string recipeName = aRecipeSplit[0];
                        string mealType = aRecipeSplit[1];
                        Recipe recipeObject = new Recipe(recipeName, mealType);
                        recipes.Add(recipeObject);

                    }

                    // Processes each ingredient line, splits by comma
                    foreach (string ingredientLine in ingredientLines)
                    {
                        string[] anIngredientSplit = ingredientLine.Split(',');
                        string recipeName = anIngredientSplit[0];
                        string[] ingredients = anIngredientSplit.Skip(1).ToArray(); // skip to skip the recipe name

                        // iterates over the recipes by index value to match ingredients to the recipe 
                        for (int i = 0; i < recipes.Count; i++)
                        {
                            if (recipes[i].Name == recipeName)
                            {
                                // Add the ingredients to the matching recipe in the recipes list - from the ingredients array
                                foreach (string ingredient in ingredients)
                                {

                                    recipes[i].AddIngredient(ingredient);
                                }
                                
                                break; // Exit the loop once the matching recipe is found
                            }
                        }                        
                    }

                    // Processes each direction line, splits by comma
                    foreach (string directionLine in directionLines)
                    {
                        string[] aDirectionSplit = directionLine.Split(',');
                        string recipeName = aDirectionSplit[0];
                        string[] directions = aDirectionSplit.Skip(1).ToArray(); // skip to skip the recipe name

                        // iterates over the recipes by index value to match directions to the recipe
                        for (int i = 0; i < recipes.Count; i++)
                        {
                            if (recipes[i].Name == recipeName)
                            {
                                // Add the directions to the matching recipe in the recipes list - from the directions array
                                foreach (string direction in directions)
                                {
                                     recipes[i].AddDirection(direction);
                                }

                                break; // Exit the loop once the matching recipe is found
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while reading files: " + ex.Message);
                }

                return recipes;
            }

            // Checks to see if a Recipe.csv file is present (so if it is not the form loads blank)
            string filePath = recipeFilePath;            
            bool filePresent = File.Exists(filePath);

            if (filePresent)
            {
                // Takes the three csv file paths, and builds a list of the Recipe objects from the files
                List<Recipe> recipes = ReadDataFromFiles(recipeFilePath, ingredientsFilePath, directionsFilePath);
                
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