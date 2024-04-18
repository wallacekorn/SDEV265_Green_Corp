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
            // Create an instance of Search page
            SingleRecipe SingleRecipePage = new SingleRecipe();

            // Show the Search Page
            SingleRecipePage.Show();
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
