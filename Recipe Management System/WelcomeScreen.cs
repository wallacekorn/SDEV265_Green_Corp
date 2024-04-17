namespace Recipe_Management_System
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
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
            SingleRecipe SearchRecipePage = new SingleRecipe();

            // Show the Search Page
            SearchRecipePage.Show();
        }

        private void newRecipeButton_Click(object sender, EventArgs e)
        {
            // Create an instance of Search page
            SingleRecipe SearchRecipePage = new SingleRecipe();

            // Show the Search Page
            SearchRecipePage.Show();
        }
    }
}
