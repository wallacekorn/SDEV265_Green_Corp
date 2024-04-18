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
        public SingleRecipe()
        {
            InitializeComponent();
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
