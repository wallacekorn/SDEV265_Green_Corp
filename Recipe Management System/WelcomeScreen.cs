using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;

namespace Recipe_Management_System
{
    public partial class WelcomeScreen : Form
    {
        private List<Recipe> recipes; // initializes a list of Recipe objects

        public WelcomeScreen(List<Recipe> recipes = null)
        {
            /* Constructor for the welcome screen form */

            this.recipes = recipes; // assigns the passed in recipes object list to a local variable
            InitializeComponent(); // initializes the welcome screen form
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            /* On load, checks to make sure the recipes list is not default(null), then builds the combo-box */

            if (recipes != null)
            {
                BuildComboBox(recipes);
            }
        }

        private void instructionsOpenButton_Click(object sender, EventArgs e)
        {
            /* On click, creates an instance of the instructions form */
                        
            Instructions instructionsPage = new Instructions(); // Create an instance of instructions form            
            instructionsPage.Show(); // Show the Instructions form
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            /* On click, creates an instance of the instructions form */
            
            SearchRecipes SearchRecipesPage = new SearchRecipes(recipes); // Create an instance of Search page            
            SearchRecipesPage.Show(); // Show the Search Page
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            /* On click, closes the application */

            Application.Exit();
        }

        private void recipeCRUDbutton_Click(object sender, EventArgs e)
        {
            /* On click, opens a new instance of the view/edit single recipe form - passing in the recipe selected in the combo box */

            string selectedRecipeName = recipeComboBox.Text; // Get the selected recipe name from the combo box

            if (selectedRecipeName != "") // if not blank
            {                
                Recipe selectedRecipe = null; // initializes an empty recipe object to store the selected Recipe
                foreach (Recipe recipe in recipes) // iterates over the recipes object
                {
                    if (recipe.Name == selectedRecipeName)// Finds the matching recipe object in the recipes list
                    {
                        selectedRecipe = recipe; // if found, sets the selected recipe to the matching recipe object
                        break; // prevents extra iterations
                    }
                }

                if (selectedRecipe != null) // if a matching recipe is found
                {
                    // Create an instance of SingleRecipe form and pass the selected recipe object as well as the recipes object list
                    SingleRecipe singleRecipePage = new SingleRecipe(selectedRecipe, recipes);
                                        
                    singleRecipePage.Show(); // Show the SingleRecipe form
                }
                else // notifies the user if no matching recipes are found
                {
                    MessageBox.Show("Selected recipe not found!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // if the selection in the combo box is empty, notifies the user
            {
                MessageBox.Show("No recipe selected!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newRecipeButton_Click(object sender, EventArgs e)
        {
            /* On click, sends the recipes object to an instance of the view/edit a single recipe form */
            
            SingleRecipe SingleRecipePage = new SingleRecipe(null, recipes); // Create an instance of view/edit single recipe page
            SingleRecipePage.Show(); // Show view/edit single recipe page
        }

        public void UpdateRecipes(List<Recipe> newRecipes)
        {
            /* Updates the recipes object and updates the welcome screen combo box */

            this.recipes = newRecipes;  // replaces the recipes object
            BuildComboBox(this.recipes); // rebuilds the combo box

        }
        public void BuildComboBox(List<Recipe> recipes)
        {
            /* Rebuilds the combo box on the welcome screen form */
            
            recipeComboBox.Items.Clear(); // Clear existing items in the combo box            
            foreach (var recipe in recipes) // Add passed in recipes to the combo box
            {
                recipeComboBox.Items.Add(recipe.Name);
            }
        }

        private void loadMenuItem_Click(object sender, EventArgs e)
        {
            /* Selected from the menu bar, this allows the user to load a recipes.csv file and, if present, loads matching directions.csv and ingredients.csv files in the same directory
             it then rebuilds the welcome screen using the new data and updates the filepath variables throughout the application so file saves are saved to the same location */

            using (OpenFileDialog openFileDialog = new OpenFileDialog()) // launches windows open file dialog
            {
                string appFolder = AppDomain.CurrentDomain.BaseDirectory; // stores the application's directory path
                string recipesDirectory = Path.Combine(appFolder, "recipes"); // builds a path for the default recipes directory

                openFileDialog.InitialDirectory = recipesDirectory; // sets the default directory
                openFileDialog.Filter = "CSV files (*.csv)|*.csv"; // Filter for CSV files

                if (openFileDialog.ShowDialog() == DialogResult.OK) // if the user clicks ok
                {
                    string userSelectedFilepath = openFileDialog.FileName; // assigns the user selected file path to a variable
                    if (userSelectedFilepath != null)
                    {
                        string recipesFilePath = userSelectedFilepath; // sets the user selected filepath to the recipes file path
                        string directoryPath = Path.GetDirectoryName(userSelectedFilepath); // finds the chosen recipes file path's home directory path
                        string ingredientsFilePath = Path.Combine(directoryPath, "Ingredients.csv"); // looks in the same directory for ingredients.csv
                        string directionsFilePath = Path.Combine(directoryPath, "Directions.csv"); // looks in the same directory for directions.csv

                        // Checks if the directions and ingredients files are present and named correctly
                        if (!File.Exists(ingredientsFilePath))
                        {
                            MessageBox.Show("The file 'Ingredients.csv' was not found in the selected directory. Files must be named 'Ingredients.csv' and 'Directions.csv', respectively.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;  // stops if the file is not found
                        }
                        if (!File.Exists(directionsFilePath))
                        {
                            MessageBox.Show("The file 'Directions.csv' was not found in the selected directory. Files must be named 'Ingredients.csv' and 'Directions.csv', respectively.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;  // stops if the file is not found
                        }

                        // Builds a list of recipe objects from the selected files and loads them into the combo box
                        List<Recipe> loadedRecipes = CSVManager.ReadDataFromFiles(recipesFilePath, ingredientsFilePath, directionsFilePath);
                        this.recipes = loadedRecipes;
                        BuildComboBox(recipes);

                        CSVManager.InitializeFilePaths(userSelectedFilepath, ingredientsFilePath, directionsFilePath); // re-establishes the filepaths for saving/deleting
                    }
                    else // alerts the user if no file was chosen
                    {
                        MessageBox.Show("No file was selected.", "File Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
