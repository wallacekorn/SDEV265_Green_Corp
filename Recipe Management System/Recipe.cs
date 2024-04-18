using System;

namespace Recipe_Management_System
{
    public class Recipe
    {
        public string Name {get; set;}
        public string MealType {get; set;}
        public List<string> Ingredients {get;} = new List<string>();
        public List<string> Directions {get;} = new List<string>();

        // Constructor
        public Recipe(string name, string mealType)
        {
            Name = name;
            MealType = mealType;
        }

        // Adds an ingredient to the Ingredients list
        public void AddIngredient(string ingredient)
        {
            Ingredients.Add(ingredient);
        }

        // Adds a direction to the Directions list
        public void AddDirection(string direction)
        {
            Directions.Add(direction);
        }

        // Overrides the ToString function for testing purposes
        public override string ToString()
        {
            // Combine recipe details into a single string
            string recipeDetails = $"Name: {Name}\nMeal Type: {MealType}\n\nIngredients:\n";
            recipeDetails += string.Join("\n", Ingredients.Select((ingredient, index) => $"{index + 1}. {ingredient}"));
            recipeDetails += "\n\nDirections:\n";
            recipeDetails += string.Join("\n", Directions.Select((direction, index) => $"{index + 1}. {direction}"));
            return recipeDetails;
        }
    }
}