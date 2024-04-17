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
        public SearchRecipes()
        {
            InitializeComponent();
        }

        private void searchExitButton_Click(object sender, EventArgs e)
        {
            // Close the form on click
            this.Close();
        }

        private void searchCRUDbutton_Click(object sender, EventArgs e)
        {
            // Create an instance of Search page
            SingleRecipe SearchRecipePage = new SingleRecipe();

            // Show the Search Page
            SearchRecipePage.Show();
        }
    }
}
