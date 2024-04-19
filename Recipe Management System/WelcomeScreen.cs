namespace Recipe_Management_System
{
    public partial class WelcomeScreen : Form
    {
        private List<Recipe> recipes;

        public WelcomeScreen(List<Recipe> recipes = null)
        {
            this.recipes = recipes;

            InitializeComponent();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            // checks to make sure the recipes list is not null(default)
            if (recipes != null)
            {
                foreach (var recipe in recipes)
                {
                    // Adds the recipe names to the combobox
                    recipeComboBox.Items.Add(recipe.Name);
                }
            }
        }

        private void instructionsOpenButton_Click(object sender, EventArgs e)
        {
            // Create an instance of instructions page
            Instructions instructionsPage = new Instructions();

            // Show the Instructions Page
            instructionsPage.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Create an instance of Search page
            SearchRecipes SearchRecipesPage = new SearchRecipes();

            // Show the Search Page
            SearchRecipesPage.Show();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            // close the application
            Application.Exit();
        }

        private void recipeCRUDbutton_Click(object sender, EventArgs e)
        {
            // Get the selected recipe name from the combo box
            string selectedRecipeName = recipeComboBox.Text;

            if (selectedRecipeName != "")
            {
                // Find the matching recipe object in the recipes list
                Recipe selectedRecipe = null;
                foreach (Recipe recipe in recipes)
                {
                    if (recipe.Name == selectedRecipeName)
                    {
                        selectedRecipe = recipe;
                        break;
                    }
                }

                if (selectedRecipe != null)
                {
                    // Create an instance of SingleRecipe form and pass the selected recipe object
                    SingleRecipe singleRecipePage = new SingleRecipe(selectedRecipe);

                    // Show the SingleRecipe form
                    singleRecipePage.Show();
                }
                else
                {
                    MessageBox.Show("Selected recipe not found!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No recipe selected!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newRecipeButton_Click(object sender, EventArgs e)
        {
            // Create an instance of Search page
            SingleRecipe SingleRecipePage = new SingleRecipe();

            // Show the Search Page
            SingleRecipePage.Show();
        }
    }
}
