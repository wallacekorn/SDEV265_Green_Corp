using System;
using System.Collections.Generic;

namespace Recipe_Management_System
{
    public static class CSVManager
    {
        private static string recipeFilePath; // initializes a variable for storing the recipes.csv file path
        private static string ingredientsFilePath; // initializes a variable for storing the ingredients.csv file path
        private static string directionsFilePath; // initializes a variable for storing the directions.csv file path
                
        public static void InitializeFilePaths(string recipePath, string ingredientsPath, string directionsPath)
        {
            /* Stores the passed in recipe paths into the local variables for use within this file */
            recipeFilePath = recipePath;
            ingredientsFilePath = ingredientsPath;
            directionsFilePath = directionsPath;
        }
        public static void UpdateCSVFiles(List<Recipe> recipes)
        {
            /* Updates the CSV files using the passed in recipes object list */

            if (!File.Exists(recipeFilePath)) // If the current recipes file path is not set...
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog()) // ...Prompts save dialog to choose location
                {
                    // Sets the initial directory to the 'recipes' folder inside the application's base directory
                    string appFolder = AppDomain.CurrentDomain.BaseDirectory; // stores the path to the directory holding the application file
                    string recipesDirectory = Path.Combine(appFolder, "recipes"); // seeks a recipes directory within the application file's home directory

                    if (!Directory.Exists(recipesDirectory)) // If the recipes directory doesnt exist
                    {
                        Directory.CreateDirectory(recipesDirectory); // Create the recipes directory
                    }

                    saveFileDialog.InitialDirectory = recipesDirectory; // Default directory
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv"; // limits the filetype to csv
                    saveFileDialog.FileName = "Recipes.csv";  // Default file name

                    if (saveFileDialog.ShowDialog() == DialogResult.OK) // if the user clicks ok
                    {
                        recipeFilePath = saveFileDialog.FileName; // sets the recipeFilePath to the chosen location

                    }
                    else
                    {
                        // If user clicks cancel it alerts the user
                        MessageBox.Show("Save operation cancelled. No file was selected.", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;  // then exits the method 
                    }
                }

            }

            // Update Recipes CSV file
            using (StreamWriter writer = new StreamWriter(recipeFilePath))
            {
                foreach (var recipe in recipes)
                {
                    writer.WriteLine($"{recipe.Name},{recipe.MealType}");
                }
            }

            // Update Ingredients CSV file
            using (StreamWriter writer = new StreamWriter(ingredientsFilePath))
            {
                foreach (var recipe in recipes)
                {
                    writer.Write(recipe.Name);
                    foreach (var ingredient in recipe.Ingredients)
                    {
                        writer.Write($",{ingredient}");
                    }
                    writer.WriteLine();
                }
            }

            // Update Directions CSV file
            using (StreamWriter writer = new StreamWriter(directionsFilePath))
            {
                foreach (var recipe in recipes)
                {
                    writer.Write(recipe.Name);
                    foreach (var direction in recipe.Directions)
                    {
                        writer.Write($",{direction}");
                    }
                    writer.WriteLine();
                }
            }
            MessageBox.Show("Changes Saved!"); // notifies the user the action was a success            
            
            SingleRecipe singleRecipeForm = Application.OpenForms.OfType<SingleRecipe>().FirstOrDefault(); // Finds the open SingleRecipe form
            if (singleRecipeForm != null)
            {
                singleRecipeForm.Close(); // Then closes the form
            }
        }
                
        public static List<Recipe> ReadDataFromFiles(string recipeFilePath, string ingredientsFilePath, string directionsFilePath)
        {
            /* Process the incoming data from the recipe, ingredients, and directions CSV files */            
            
            List<Recipe> recipes = new List<Recipe>(); // creates a list object that stores the Recipe objects
            string[] validMealTypes = { "Breakfast", "Lunch", "Dinner", "Dessert" }; // stores the meal types to verify incoming values are valid

            try
            {
                // Reads the lines from the three selected .csv files into arrays
                string[] recipeLines = File.ReadAllLines(recipeFilePath);
                string[] ingredientLines = File.ReadAllLines(ingredientsFilePath);
                string[] directionLines = File.ReadAllLines(directionsFilePath);

                foreach (string recipeLine in recipeLines) // iterates over the lines in the recipe lines array
                {
                    string[] aRecipeSplit = recipeLine.Split(',') ;// Takes each line, splits by comma
                    string recipeName = aRecipeSplit[0]; // first entry is the primary key, recipe name
                    string mealType; // second entry is the meal type

                    // Check if there is a mealType in the split data
                    if (aRecipeSplit.Length > 1)
                    {                        
                        mealType = aRecipeSplit[1].Trim(); // If there is a second element, its trimmed of whitespace                        
                        if (!validMealTypes.Contains(mealType)) // And then checked to see if it is one of the valid meal types
                        {
                            mealType = "Breakfast"; // if not, assigns it a default, valid meal type
                        }
                    }
                    else
                    {                        
                        mealType = "Breakfast"; // If the mealtype is omitted completely, it is given a default meal type
                    }

                    Recipe recipeObject = new Recipe(recipeName, mealType); // then uses the separated parts to build a Recipe Object
                    recipes.Add(recipeObject); // and adds the Recipe object to the recipes object list

                }

                // Processes each ingredient line, splits by comma
                foreach (string ingredientLine in ingredientLines) // iterates over the lines in the ingredients lines array
                {
                    string[] anIngredientSplit = ingredientLine.Split(','); // splits by comma
                    string recipeName = anIngredientSplit[0]; // stores each lines primary key - recipe name
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
                foreach (string directionLine in directionLines) // iterates over the lines in the directions lines array
                {
                    string[] aDirectionSplit = directionLine.Split(','); // splits by comma
                    string recipeName = aDirectionSplit[0]; // stores each lines primary key - recipe name
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
                Console.WriteLine("Error while reading files: " + ex.Message); // otherwise logs an error
            }

            return recipes;
        }

        public static string ReplaceTheCommas(string inputString)
        {
            /* Replaces commas in user input with semi colons to prevent parsing errors  */

            if (string.IsNullOrEmpty(inputString))
            {
                return string.Empty; // if the input string is null or empty it returns empty rather than trying to process
            }
                        
            return inputString.Replace(",", ";"); // Replace commas with a semicolon
        }
    }
}