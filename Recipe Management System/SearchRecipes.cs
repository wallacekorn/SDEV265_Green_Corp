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
        private List<Recipe> recipes; // initializes a blank recipes object list
        public SearchRecipes(List<Recipe> recipes)
        {
            /* Search form constructor */

            this.recipes = recipes; // sets the passed in recipes list to a local variable
            InitializeComponent(); // initialize the search form
            nameRadioButton.Checked = true; // checks one of the radio buttons by default to prevent errors
        }

        private void searchExitButton_Click(object sender, EventArgs e)
        {
            /* Close the form on click */
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            /* On button press, this function clears the old results and searches the recipes object list based on user entered
             * data then displays the results in the list view */
            
            searchListBox.Items.Clear(); // Clear previous search results in the list box

            List<Recipe> returnedRecipes = new List<Recipe>(); // initializes a list to store the returned objects
            string userSearch = searchBar.Text.ToLower(); // stores the user entered text in lowercase(to prevent case sensitivity)

            // If the search box is empty or filled with white space it tells the user and doesnt execute the search
            if (string.IsNullOrWhiteSpace(userSearch) && (nameRadioButton.Checked || ingredientRadioButton.Checked))
            {
                MessageBox.Show("Please enter a meal to search");
                return; // Exit the function
            }

            string selectedMealType = ""; // stores the user selected meal type
            if (mealTypeRadioButton.Checked)// If the mealTypeRadioButton is checked, 
            {
                if (typeComboBox.SelectedItem != null) // and the associated combo box is not null
                {
                    // then get the selected item from the typeComboBox and convert it to a string
                    selectedMealType = typeComboBox.SelectedItem.ToString();
                }
                else {
                    MessageBox.Show("Please select a meal type");
                }
            }

            if (recipes != null)
            {
                foreach (Recipe recipe in recipes) // iterates over the recipes object list 
                {
                    
                    if (nameRadioButton.Checked && recipe.Name.ToLower().Contains(userSearch)) 
                    {                                // if name radiobutton is checked and user input text matches the name field the recipes object list...
                        returnedRecipes.Add(recipe); // ...then the matching recipe object is added to the returnedRecipes object list
                    }
                    else if (ingredientRadioButton.Checked) // if ingredient button is checked
                    {
                        foreach (string ingredient in recipe.Ingredients) // each recipes ingredients are checked
                        {
                            if (ingredient.ToLower().Contains(userSearch)) // if they match the user-entered text
                            {
                                returnedRecipes.Add(recipe); // then the recipe object is added to the returnedRecipes object list
                            }
                        }
                    }
                    else if (mealTypeRadioButton.Checked && recipe.MealType.ToLower() == selectedMealType.ToLower()) // if the mealtype button is checked and selected meal type matches a recipes mealtype field
                    {
                        returnedRecipes.Add(recipe); // then the recipe is added to the returnedRecipes object list
                    }
                }
            }
            if (returnedRecipes.Count == 0) // if returnedRecipes list is empty
            {                
                searchListBox.Items.Add("No Results Found"); // Show a message to the user indicating no recipes were found
            }
            else
            {                
                UpdateSearchResults(returnedRecipes); // Update search results in the ListBox
            }
        }

        private void UpdateSearchResults(List<Recipe> returnedRecipes)
        {
            /* Adds the search results to the search results ListBox */
            searchListBox.Items.Clear(); // clears the listbox
            foreach (Recipe recipe in returnedRecipes) // adds the search results to the listbox
            {
                searchListBox.Items.Add(recipe); // adds the recipe object so it can easily be sent to the edit form
            }
            searchListBox.DisplayMember = "Name"; // Displays the name property of the recipe object
        }

        private void searchViewRecipe_Click(object sender, EventArgs e)
        {
            /* Sends the selected recipe in the search results listbox to a new view/edit form  */
            Recipe selectedRecipe = searchListBox.SelectedItem as Recipe; // stores selected recipe, stores null if not a recipe

            if (selectedRecipe != null) // if a recipe is stored
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
            /* Checks the mealType radio button if the combobox is clicked */
            mealTypeRadioButton.Checked = true;
        }

        private void mealTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            /* If the radio button is clicked, sets the searchbar to read-only and clears it to avoid confusion */
            searchBar.ReadOnly = mealTypeRadioButton.Checked;
            searchBar.Text = "";
        }
    }
}
