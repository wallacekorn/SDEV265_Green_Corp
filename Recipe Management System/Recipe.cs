using System;
using System.Text;

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
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Meal Type: {MealType}");
            sb.AppendLine("Ingredients:");
            foreach (string ingredient in Ingredients)
            {
                sb.AppendLine($"- {ingredient}");
            }
            sb.AppendLine("Directions:");
            foreach (string direction in Directions)
            {
                sb.AppendLine($"- {direction}");
            }

            return sb.ToString();
        }
    }
}