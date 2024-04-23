using System;
using System.Collections.Generic;

namespace Recipe_Management_System
{
    public static class CSVManager
    {
        private static string recipeFilePath;
        private static string ingredientsFilePath;
        private static string directionsFilePath;

        // Stores the recipe paths for use within this file
        public static void InitializeFilePaths(string recipePath, string ingredientsPath, string directionsPath)
        {
            recipeFilePath = recipePath;
            ingredientsFilePath = ingredientsPath;
            directionsFilePath = directionsPath;
        }
        public static void UpdateCSVFiles(List<Recipe> recipes)
        {
            if (!File.Exists(recipeFilePath)) // If the current recipes file path is not set
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog()) // Prompts save dialog to choose location
                {
                    // Set the initial directory to the 'recipes' folder inside the application's base directory
                    string appFolder = AppDomain.CurrentDomain.BaseDirectory;
                    string recipesDirectory = Path.Combine(appFolder, "recipes");

                    if (!Directory.Exists(recipesDirectory))
                    {
                        Directory.CreateDirectory(recipesDirectory); // Create the recipes directory if it doesnt exist
                    }

                    saveFileDialog.InitialDirectory = recipesDirectory; // Default directory
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                    saveFileDialog.FileName = "Recipes.csv";  // Default file name

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        recipeFilePath = saveFileDialog.FileName;

                    }
                    else
                    {
                        // If user clicks cancel
                        MessageBox.Show("Save operation cancelled. No file was selected.", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;  // exits the method 
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
            MessageBox.Show("Changes Saved!");
            
            // Finds the open SingleRecipe form
            SingleRecipe singleRecipeForm = Application.OpenForms.OfType<SingleRecipe>().FirstOrDefault();
            if (singleRecipeForm != null)
            {
                singleRecipeForm.Close(); // Then closes the form
            }
        }

        // Process the data from the recipe, ingredients, and directions CSV files
        public static List<Recipe> ReadDataFromFiles(string recipeFilePath, string ingredientsFilePath, string directionsFilePath)
        {
            // creates a list object that stores the Recipe objects
            List<Recipe> recipes = new List<Recipe>();
            string[] validMealTypes = { "Breakfast", "Lunch", "Dinner", "Dessert" };

            try
            {
                // Reads the lines from the three .csv files into arrays
                string[] recipeLines = File.ReadAllLines(recipeFilePath);
                string[] ingredientLines = File.ReadAllLines(ingredientsFilePath);
                string[] directionLines = File.ReadAllLines(directionsFilePath);

                foreach (string recipeLine in recipeLines)
                {
                    string[] aRecipeSplit = recipeLine.Split(',') ;// Takes each line, splits by comma
                    string recipeName = aRecipeSplit[0];
                    string mealType;

                    // Check if there is a mealType in the split data
                    if (aRecipeSplit.Length > 1)
                    {
                        // If there is a second element, its trimmed
                        mealType = aRecipeSplit[1].Trim();
                        // And then checked to see if it is one of the valid types
                        if (!validMealTypes.Contains(mealType))
                        {
                            mealType = "Breakfast"; // if not, gives it a default meal type
                        }
                    }
                    else
                    {
                        // If the mealtype is omitted completely, it is given a default meal type
                        mealType = "Breakfast";
                    }

                    Recipe recipeObject = new Recipe(recipeName, mealType); // then uses the parts to build a Recipe Object
                    recipes.Add(recipeObject); // and adds the Recipe object to a list

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

        public static string ReplaceTheCommas(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return string.Empty;
            }

            // Replace commas with a semicolon to maintain csv integrity 
            return inputString.Replace(",", ";");
        }
    }
}