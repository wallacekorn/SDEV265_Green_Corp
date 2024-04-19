using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_Management_System
{
    public partial class SingleRecipe : Form
    {
        private Recipe aRecipe;

        public SingleRecipe(Recipe aRecipe = null)
        {
            InitializeComponent();
            this.aRecipe = aRecipe;
            // MessageBox.Show(recipe.ToString());
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
                    mealTypeDropdown.SelectedItem = "Lunch"; // Defaults to 'Lunch' if the meal type doesn't match
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
        }
        private void recipeExitButton_Click(object sender, EventArgs e)
        {
            // Close the form on click
            this.Close();
        }

        private void editRecipeButton_Click(object sender, EventArgs e)
        {
            // Toggles the Read-only nature of the input fields on button press
            ingredientsDataGrid.ReadOnly = !ingredientsDataGrid.ReadOnly;
            directionsDataGrid.ReadOnly = !directionsDataGrid.ReadOnly;
            nameTextBox.ReadOnly = !nameTextBox.ReadOnly;
            mealTypeDropdown.Enabled = !mealTypeDropdown.Enabled;

            // Switches the button text to match the current state
            if (editRecipeButton.Text == "Edit")
            {
                editRecipeButton.Text = "Lock";
            }
            else
            {
                editRecipeButton.Text = "Edit";
            }
        }
    }
}
