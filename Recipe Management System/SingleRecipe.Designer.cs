namespace Recipe_Management_System
{
    partial class SingleRecipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleRecipe));
            recipeExitButton = new Button();
            deleteRecipeButton = new Button();
            editRecipeButton = new Button();
            saveRecipeButton = new Button();
            nameLabel = new Label();
            ingredientsLabel = new Label();
            directionsLabel = new Label();
            mealTypeLabel = new Label();
            mealTypeDropdown = new ComboBox();
            nameTextBox = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // recipeExitButton
            // 
            recipeExitButton.Location = new Point(350, 356);
            recipeExitButton.Name = "recipeExitButton";
            recipeExitButton.Size = new Size(100, 30);
            recipeExitButton.TabIndex = 0;
            recipeExitButton.Text = "Exit";
            recipeExitButton.UseVisualStyleBackColor = true;
            recipeExitButton.Click += recipeExitButton_Click;
            // 
            // deleteRecipeButton
            // 
            deleteRecipeButton.Location = new Point(470, 304);
            deleteRecipeButton.Name = "deleteRecipeButton";
            deleteRecipeButton.Size = new Size(100, 30);
            deleteRecipeButton.TabIndex = 1;
            deleteRecipeButton.Text = "Delete";
            deleteRecipeButton.UseVisualStyleBackColor = true;
            // 
            // editRecipeButton
            // 
            editRecipeButton.Location = new Point(350, 304);
            editRecipeButton.Name = "editRecipeButton";
            editRecipeButton.Size = new Size(100, 30);
            editRecipeButton.TabIndex = 2;
            editRecipeButton.Text = "Edit";
            editRecipeButton.UseVisualStyleBackColor = true;
            // 
            // saveRecipeButton
            // 
            saveRecipeButton.Location = new Point(230, 304);
            saveRecipeButton.Name = "saveRecipeButton";
            saveRecipeButton.Size = new Size(100, 30);
            saveRecipeButton.TabIndex = 3;
            saveRecipeButton.Text = "Save";
            saveRecipeButton.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(296, 61);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // ingredientsLabel
            // 
            ingredientsLabel.AutoSize = true;
            ingredientsLabel.Location = new Point(206, 137);
            ingredientsLabel.Name = "ingredientsLabel";
            ingredientsLabel.Size = new Size(69, 15);
            ingredientsLabel.TabIndex = 5;
            ingredientsLabel.Text = "Ingredients:";
            // 
            // directionsLabel
            // 
            directionsLabel.AutoSize = true;
            directionsLabel.Location = new Point(410, 137);
            directionsLabel.Name = "directionsLabel";
            directionsLabel.Size = new Size(63, 15);
            directionsLabel.TabIndex = 6;
            directionsLabel.Text = "Directions:";
            // 
            // mealTypeLabel
            // 
            mealTypeLabel.AutoSize = true;
            mealTypeLabel.Location = new Point(296, 100);
            mealTypeLabel.Name = "mealTypeLabel";
            mealTypeLabel.Size = new Size(63, 15);
            mealTypeLabel.TabIndex = 7;
            mealTypeLabel.Text = "Meal Type:";
            // 
            // mealTypeDropdown
            // 
            mealTypeDropdown.FormattingEnabled = true;
            mealTypeDropdown.Location = new Point(384, 97);
            mealTypeDropdown.Name = "mealTypeDropdown";
            mealTypeDropdown.Size = new Size(121, 23);
            mealTypeDropdown.TabIndex = 8;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(384, 57);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(121, 23);
            nameTextBox.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(206, 154);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(173, 124);
            listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(410, 154);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(184, 124);
            listBox2.TabIndex = 11;
            // 
            // SingleRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(nameTextBox);
            Controls.Add(mealTypeDropdown);
            Controls.Add(mealTypeLabel);
            Controls.Add(directionsLabel);
            Controls.Add(ingredientsLabel);
            Controls.Add(nameLabel);
            Controls.Add(saveRecipeButton);
            Controls.Add(editRecipeButton);
            Controls.Add(deleteRecipeButton);
            Controls.Add(recipeExitButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SingleRecipe";
            Text = "RMS - Single Recipe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button recipeExitButton;
        private Button deleteRecipeButton;
        private Button editRecipeButton;
        private Button saveRecipeButton;
        private Label nameLabel;
        private Label ingredientsLabel;
        private Label directionsLabel;
        private Label mealTypeLabel;
        private ComboBox mealTypeDropdown;
        private TextBox nameTextBox;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}