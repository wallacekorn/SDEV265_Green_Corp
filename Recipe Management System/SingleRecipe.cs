using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Recipe_Management_System
{
    public partial class SingleRecipe : Form
    {
        private Recipe aRecipe;
        private List<Recipe> recipes;
        private bool fromAddNew;

        public SingleRecipe(Recipe aRecipe = null, List<Recipe> recipes = null)
        {
            InitializeComponent();
            this.aRecipe = aRecipe;
            this.recipes = recipes;


            // if no recipe exists, it executes the edit button so the fields are immediately editable
            if (aRecipe == null)
            {
                fromAddNew = true;
                editRecipeButton_Click(null, EventArgs.Empty);
            }
        }

        private void SingleRecipe_Load(object sender, EventArgs e)
        {
            if (aRecipe != null)
            {
                // Fills in the input fields with the Recipes information

                // Name
                nameTextBox.Text = aRecipe.Name;

                // ComboBox - tests values in lowercase to avoid case sensitivity
                string lowercaseMealType = aRecipe.MealType.ToLower();
                bool foundMealType = false;

                foreach (var item in mealTypeDropdown.Items)
                {
                    if (item is string && ((string)item).ToLower() == lowercaseMealType)
                    {
                        mealTypeDropdown.SelectedItem = item;
                        foundMealType = true;
                        break;
                    }
                }
                if (!foundMealType)
                {
                    mealTypeDropdown.SelectedItem = "Breakfast"; // Defaults to 'Lunch' if the meal type doesn't match
                }

                // Directions            
                directionsDataGrid.Rows.Clear(); // Clear existing rows just in case

                // Adds directions to data grid
                foreach (string direction in aRecipe.Directions)
                {
                    directionsDataGrid.Rows.Add(direction);
                }

                // Ingredients
                ingredientsDataGrid.Rows.Clear(); // Clear existing rows just in case

                // Adds ingredients to data grid
                foreach (string ingredient in aRecipe.Ingredients)
                {
                    ingredientsDataGrid.Rows.Add(ingredient);
                }
            }
            else 
            {
                mealTypeDropdown.SelectedItem = "Breakfast"; // sets to a default value to prevent error
            }
        }
        private void recipeExitButton_Click(object sender, EventArgs e)
        {
            // Close the form on click
            this.Close();
        }

        private void editRecipeButton_Click(object sender, EventArgs e)
        {
           
            if (fromAddNew != true) 
            {
                fromAddNew = false; // makes sure its not null
            }

            // Switches the button text to match the current state
            if (editRecipeButton.Text == "Edit")
            {
                // Toggles the Read-only nature of the input fields on button press
                ingredientsDataGrid.ReadOnly = false;
                directionsDataGrid.ReadOnly = false;
                mealTypeDropdown.Enabled = true;
                editRecipeButton.Text = "Lock";
                if (fromAddNew == true)
                {
                    nameTextBox.ReadOnly = false; // if a new recipe is locked the name should lock
                }
            }
            else
            {
                editRecipeButton.Text = "Edit";
                // Toggles the Read-only nature of the input fields on button press
                ingredientsDataGrid.ReadOnly = true;
                directionsDataGrid.ReadOnly = true;
                mealTypeDropdown.Enabled = false;
                if (fromAddNew == true)
                {
                    nameTextBox.ReadOnly = true; // if a new recipe is unlocked the name should still be editable
                }
            }
        }

        private void deleteRecipeButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            // Verifies the button press was intentional
            if (aRecipe != null)
            {
                result = MessageBox.Show($"This will delete the recipe '{aRecipe.Name}.' \nAre you sure you want to continue?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else 
            {
                result = MessageBox.Show($"Do you want to clear the form?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            // If it was intentional, deletes the Recipe object from the recipes list
            if (result == DialogResult.Yes)
            {
                if (aRecipe != null)
                {
                    // Find the index of the recipe to delete
                    int index = FindRecipeIndex(aRecipe);


                    if (index != -1) // If the recipe is found
                    {
                        recipes.RemoveAt(index); // remove it from the recipes object list

                        WelcomeScreen welcomeScreen = Application.OpenForms.OfType<WelcomeScreen>().FirstOrDefault();
                        if (welcomeScreen != null)
                        {
                            welcomeScreen.BuildComboBox(recipes); // Refresh the combo box on Welcome Screen
                        }
                        this.Close(); // then close the Single Recipes form after deletion

                        CSVManager.UpdateCSVFiles(recipes); // and finally, updates the CSV files.


                    }
                }
                else
                {
                    // Clear the form if aRecipe is null - just in case the user meant to clear the form
                    clearButton_Click(sender, e);
                }
            }
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            // clears input fields
            ingredientsDataGrid.Rows.Clear();
            directionsDataGrid.Rows.Clear();
            nameTextBox.Text = "";
            aRecipe = null;               // clears the variable to prevent logic breakdowns
            mealTypeDropdown.SelectedItem = "Breakfast";
            fromAddNew = true;            // treats the form as a new recipe now
            // editRecipeButton_Click(null, EventArgs.Empty); // sets all the inputs to so they can be editable

            // manually set all input fields to be editable 
            ingredientsDataGrid.ReadOnly = false;
            directionsDataGrid.ReadOnly = false;
            nameTextBox.ReadOnly = false;
            mealTypeDropdown.Enabled = true;

            // edit button shows correct text
            editRecipeButton.Text = "Lock";
        }

        private int FindRecipeIndex(Recipe recipe)
        {
            // Finds the index value of a passed in recipe within the Recipes object list
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i] == recipe)
                {
                    return i; // Returns the index if the recipe is found
                }
            }
            return -1; // Returns -1 if the recipe is not found
        }

        private void saveRecipeButton_Click(object sender, EventArgs e)
        {
            // Checks if the name text box is empty
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please enter a recipe name to save", "No name provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve the name and meal type from the input fields
            string name = CSVManager.ReplaceTheCommas(nameTextBox.Text); // stores name, removes commas to assure correct parsing later
            string mealType = mealTypeDropdown.SelectedItem.ToString();

            // Create a new Recipe object using the data
            Recipe newRecipe = new Recipe(name, mealType);

            // Add the ingredients to the Recipe object
            foreach (DataGridViewRow row in ingredientsDataGrid.Rows)
            {
                if (!row.IsNewRow) // so it doesnt grab the blank line at the end
                {
                    string ingredient = row.Cells[0].Value?.ToString();
                    if (!string.IsNullOrEmpty(ingredient))
                    {
                        newRecipe.AddIngredient(CSVManager.ReplaceTheCommas(ingredient)); // adds ingredient to list, removes commas to assure correct parsing later
                    }
                }
            }

            // Add the directions to the Recipe object
            foreach (DataGridViewRow row in directionsDataGrid.Rows)
            {
                if (!row.IsNewRow) // so it doesnt grab the blank line at the end
                {
                    string direction = row.Cells[0].Value?.ToString();
                    if (!string.IsNullOrEmpty(direction))
                    {
                        newRecipe.AddDirection(CSVManager.ReplaceTheCommas(direction)); // adds direction to list, removes commas to assure correct parsing later
                    }
                }
            }

            // Check if a recipe with the same name already exists in the recipes object list
            string lowercaseNewRecipeName = newRecipe.Name.ToLower();
            Recipe existingRecipe = null;

            if (this.recipes == null)
            {
                this.recipes = new List<Recipe>();  // Initialize if its null
            }

            foreach (Recipe recipe in recipes)
            {
                if (recipe.Name.ToLower() == lowercaseNewRecipeName) // compares in lowercase to prevent case sensitivity
                {
                    existingRecipe = recipe;
                    break;
                }
            }

            if (existingRecipe == null)
            {
                // If it doesn't exist, adds it to the list
                recipes.Add(newRecipe);
            }
            else
            { 
                // If recipe already exists, updates it
                int index = recipes.IndexOf(existingRecipe);
                recipes[index] = newRecipe;
            }

            // update combo box and recipes object
            WelcomeScreen welcomeScreen = Application.OpenForms.OfType<WelcomeScreen>().FirstOrDefault();
            if (welcomeScreen != null)
            {
                welcomeScreen.UpdateRecipes(recipes);
            }

            // Updates the CSV files with the new list of recipes
            CSVManager.UpdateCSVFiles(recipes);
        }
    }
}
