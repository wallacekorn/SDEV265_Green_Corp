using System;
using System.Text;

namespace Recipe_Management_System
{
    public class Recipe
    {
        public string Name {get; set;} // getter and setter functions for the Name property of the Recipe object
        public string MealType {get; set; } // getter and setter functions for the MealType property of the Recipe object
        public List<string> Ingredients {get;} = new List<string>(); // Creates an empty list and get function for the Ingredients List
        public List<string> Directions {get;} = new List<string>();  // Creates an empty list and get function for the Directions List

        // Constructor
        public Recipe(string name, string mealType)
        {
            /* Constructor for the Recipe Object */

            Name = name;            // assigns the variable to the input name
            MealType = mealType;    // assigns the variable to the input mealType
        }

        // Adds an ingredient to the Ingredients list
        public void AddIngredient(string ingredient)
        {
            /* Adds ingredient to the Ingredients list */
            Ingredients.Add(ingredient);
        }

        // Adds a direction to the Directions list
        public void AddDirection(string direction)
        {
            /* Adds directions to the Directions list */
            Directions.Add(direction);
        }

        
        public override string ToString()
        {
            /* Overrides the ToString function for testing purposes */

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {Name}"); // Adds the object's name
            sb.AppendLine($"Meal Type: {MealType}"); // Adds the object's meal type

            sb.AppendLine("Ingredients:"); 
            foreach (string ingredient in Ingredients) // Adds the object's ingredients
            {
                sb.AppendLine($"- {ingredient}");
            }
            sb.AppendLine("Directions:"); 
            foreach (string direction in Directions) // Adds the object's ingredients
            {
                sb.AppendLine($"- {direction}");
            }

            return sb.ToString(); // returns the built string
        }
    }
}