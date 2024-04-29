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
        private Recipe aRecipe; // initializes a blank recipe object
        private List<Recipe> recipes; // initializes a blank recipes object list
        private bool fromAddNew; // Used to toggle the edit button so the name property is locked if a recipe is being edited vs created

        public SingleRecipe(Recipe aRecipe = null, List<Recipe> recipes = null)
        {
            /* Initializes the Single Recipe form, sets the arguments to variables, 
             * determines the source of the initialization and sets the edit button accordingly */

            InitializeComponent();
            this.aRecipe = aRecipe; // assigns the provided argument to the matching local variable
            this.recipes = recipes; // assigns the provided argument to the matching local variable


            // if no recipe exists, it executes the edit button so the fields are immediately editable
            if (aRecipe == null)
            {
                fromAddNew = true;
                editRecipeButton_Click(null, EventArgs.Empty);
            }
        }

        private void SingleRecipe_Load(object sender, EventArgs e)
        {
            /* Upon loading, if a recipe is fed into the form (not new) then it populates the form with the Recipe objects data*/

            if (aRecipe != null) // if the recipe exists fills in the input fields with the Recipes information
            {
                nameTextBox.Text = aRecipe.Name; // Sets Name text box to the recipe name

                // sets MealType ComboBox to recipe mealType - tests values in lowercase to avoid case sensitivity
                string lowercaseMealType = aRecipe.MealType.ToLower(); // assigns the recipe objects mealtype in lowercase letters to a variable
                bool foundMealType = false; // used to track if a mealtype is found

                foreach (var item in mealTypeDropdown.Items) // iterates over the items in the mealTypeDropdown
                {
                    if (item is string && ((string)item).ToLower() == lowercaseMealType) // checks to see if it matches the recipe object's mealtype - in lowercase to prevent case sensitivity
                    {
                        mealTypeDropdown.SelectedItem = item; // sets the dropdown to the matching item
                        foundMealType = true; // sets the variable to true, so the default is not set below
                        break; // breaks the loop once found
                    }
                }
                if (!foundMealType) // if no mealtype is found
                {
                    mealTypeDropdown.SelectedItem = "Breakfast"; // Defaults to 'Lunch' if the meal type doesn't match
                }

                // Sets Directions gridrow view to the recipe objects directions         
                directionsDataGrid.Rows.Clear(); // Clear existing rows to prevent appending if more than one recipe is viewed
                                
                foreach (string direction in aRecipe.Directions)
                {
                    directionsDataGrid.Rows.Add(direction); // Adds directions to data grid
                }

                // Sets Ingredients gridrow view to the recipe objects ingredients 
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
            /* Close the form on click */
            this.Close();
        }

        private void editRecipeButton_Click(object sender, EventArgs e)
        {
            /* Toggles the readonly nature of the input fields to provide a layer of protection for the recipes */
            if (fromAddNew != true) 
            {
                fromAddNew = false; // makes sure its not null to prevent null exception
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
                // Toggles the Read-only nature of the input fields on button press
                editRecipeButton.Text = "Edit";                
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
            /* Deletes the selected recipe and updates the recipes list on the welcome screen, and saves the changes to the csv files */

            DialogResult result;
            // Verifies the button press was intentional
            if (aRecipe != null) // displays a confirmation message to the user
            {
                result = MessageBox.Show($"This will delete the recipe '{aRecipe.Name}.' \nAre you sure you want to continue?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else // or if the recipe is not already saved, it clears the fields
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

                        WelcomeScreen welcomeScreen = Application.OpenForms.OfType<WelcomeScreen>().FirstOrDefault(); // targets the open welcome screen object
                        if (welcomeScreen != null) // if welcome screen is open
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
            /* Clears the input fields on button press */

            // clears input fields
            ingredientsDataGrid.Rows.Clear();
            directionsDataGrid.Rows.Clear();
            nameTextBox.Text = "";
            aRecipe = null;               // clears the variable to prevent logic breakdowns
            mealTypeDropdown.SelectedItem = "Breakfast"; // assigns a default value
            fromAddNew = true;            // treats the form as a new recipe

            // set all input fields to be editable 
            ingredientsDataGrid.ReadOnly = false;
            directionsDataGrid.ReadOnly = false;
            nameTextBox.ReadOnly = false;
            mealTypeDropdown.Enabled = true;            
            editRecipeButton.Text = "Lock"; // edit button shows correct text
        }

        private int FindRecipeIndex(Recipe recipe)
        {
            /* Finds the index value of a passed in recipe within the Recipes object list */
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i] == recipe) // iterates over the recipes list
                {
                    return i; // Returns the index if the recipe is found
                }
            }
            return -1; // Returns -1 if the recipe is not found
        }

        private void saveRecipeButton_Click(object sender, EventArgs e)
        {
            /* Saves the input fields to the csv files, and updates the combobox on the welcome screen form */

            // Checks if the name text box is empty (this is the primary key so must not be empty)
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please enter a recipe name to save", "No name provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // breaks the loop so it doesnt try to save
            }

            // Retrieve the name and meal type from the input fields
            string name = CSVManager.ReplaceTheCommas(nameTextBox.Text); // stores name, removes commas to assure correct parsing later
            string mealType = mealTypeDropdown.SelectedItem.ToString(); // stores the mealType chosen in the combo box

            // Create a new Recipe object using the data
            Recipe newRecipe = new Recipe(name, mealType);

            // Add the ingredients to the Recipe object
            foreach (DataGridViewRow row in ingredientsDataGrid.Rows)
            {
                if (!row.IsNewRow) // so it doesnt grab the blank line at the end
                {
                    string ingredient = row.Cells[0].Value?.ToString(); // grabs the ingredient on each row
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
                    string direction = row.Cells[0].Value?.ToString(); // grabs the direction on each row
                    if (!string.IsNullOrEmpty(direction))
                    {
                        newRecipe.AddDirection(CSVManager.ReplaceTheCommas(direction)); // adds direction to list, removes commas to assure correct parsing later
                    }
                }
            }

            // Check if a recipe with the same name already exists in the recipes object list
            string lowercaseNewRecipeName = newRecipe.Name.ToLower(); // converts the recipe name being saved to lowercase and stores for testing
            Recipe existingRecipe = null; // initializes the existingRecipe object

            if (this.recipes == null)
            {
                this.recipes = new List<Recipe>();  // Initialize recipes object list if currently null
            }

            foreach (Recipe recipe in recipes) // iterates over the recipes object list
            {
                if (recipe.Name.ToLower() == lowercaseNewRecipeName) // compares in lowercase to prevent case sensitivity
                {
                    existingRecipe = recipe; // if matching, the recipe already exists and existingRecipe is assigned the recipe object
                    break; // loop breaks to prevent additional processing
                }
            }

            if (existingRecipe == null)
            {                
                recipes.Add(newRecipe); // If recipe doesnt already exist, adds it to the recipes object list
            }
            else
            {                 
                int index = recipes.IndexOf(existingRecipe); // If recipe already exists, grabs its index
                recipes[index] = newRecipe; // then assigns the newRecipe object to the old recipes location
            }

            // update combo box and recipes object
            WelcomeScreen welcomeScreen = Application.OpenForms.OfType<WelcomeScreen>().FirstOrDefault(); // targets the open welcome screen object
            if (welcomeScreen != null)
            {
                welcomeScreen.UpdateRecipes(recipes); // updates the combobox
            }

            // Updates the CSV files with the new list of recipes
            CSVManager.UpdateCSVFiles(recipes);
        }
    }
}
