using System;

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
        }
    }
}