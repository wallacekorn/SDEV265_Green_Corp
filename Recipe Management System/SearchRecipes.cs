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
    public partial class SearchRecipes : Form
    {
        private List<Recipe> recipes;
        public SearchRecipes(List<Recipe> recipes)
        {
            this.recipes = recipes;
            InitializeComponent();
            nameRadioButton.Checked = true; // default value to prevent errors
        }

        private void searchExitButton_Click(object sender, EventArgs e)
        {
            // Close the form on click
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Clear previous search results in the list box
            searchListBox.Items.Clear();

            List<Recipe> returnedRecipes = new List<Recipe>();
            string userSearch = searchBar.Text.ToLower();

            // If the search box is empty or filled with white space it tells the user and doesnt search
            if (string.IsNullOrWhiteSpace(userSearch) && (nameRadioButton.Checked || ingredientRadioButton.Checked))
            {
                MessageBox.Show("Please enter a meal to search");
                return; // Exit the function
            }

            string selectedMealType = "";
            if (mealTypeRadioButton.Checked)// If the mealTypeRadioButton is checked, 
            {
                // then get the selected item from the typeComboBox and convert it to a string
                selectedMealType = typeComboBox.SelectedItem.ToString();
            }

            foreach (Recipe recipe in recipes)
            {
                if (nameRadioButton.Checked && recipe.Name.ToLower().Contains(userSearch))
                {
                    returnedRecipes.Add(recipe);
                }
                else if (ingredientRadioButton.Checked)
                {
                    foreach (string ingredient in recipe.Ingredients)
                    {
                        if (ingredient.ToLower().Contains(userSearch))
                        {
                            returnedRecipes.Add(recipe);
                        }
                    }
                }
                else if (mealTypeRadioButton.Checked && recipe.MealType.ToLower() == selectedMealType.ToLower())
                {
                    returnedRecipes.Add(recipe);
                }
            }
            if (returnedRecipes.Count == 0)
            {
                // No recipes found
                searchListBox.Items.Add("No Results Found");
            }
            else
            {
                // Update search results in the ListBox
                UpdateSearchResults(returnedRecipes);
            }
        }

        private void UpdateSearchResults(List<Recipe> returnedRecipes)
        {
            // Adds the search results to the ListBox
            searchListBox.Items.Clear();
            foreach (Recipe recipe in returnedRecipes)
            {
                searchListBox.Items.Add(recipe); // adds the recipe object so it can easily be sent to the edit form
            }
            searchListBox.DisplayMember = "Name"; // Displays the name property of the recipe object
        }

        private void searchViewRecipe_Click(object sender, EventArgs e)
        {
            // Stores the selected recipe
            Recipe selectedRecipe = searchListBox.SelectedItem as Recipe; // stores recipe, stores null if not a recipe

            if (selectedRecipe != null)
            {
                // Attaches the selected recipe and the overall recipes list
                SingleRecipe singleRecipePage = new SingleRecipe(selectedRecipe, recipes);
                // and launches the view/edit form window
                singleRecipePage.Show();

                this.Close(); // closes the search form
            }
        }

        private void typeComboBox_Click(object sender, EventArgs e)
        {
            // Checks the mealType radio button if the combobox is clicked
            mealTypeRadioButton.Checked = true;
        }

        private void mealTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchBar.ReadOnly = mealTypeRadioButton.Checked;
            searchBar.Text = "";
        }
    }
}
