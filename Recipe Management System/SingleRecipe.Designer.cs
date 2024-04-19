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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            directionsDataGrid = new DataGridView();
            directionsColumn = new DataGridViewTextBoxColumn();
            ingredientsDataGrid = new DataGridView();
            ingredientsColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)directionsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredientsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // recipeExitButton
            // 
            recipeExitButton.Location = new Point(665, 12);
            recipeExitButton.Name = "recipeExitButton";
            recipeExitButton.Size = new Size(80, 24);
            recipeExitButton.TabIndex = 0;
            recipeExitButton.Text = "Exit";
            recipeExitButton.UseVisualStyleBackColor = true;
            recipeExitButton.Click += recipeExitButton_Click;
            // 
            // deleteRecipeButton
            // 
            deleteRecipeButton.Location = new Point(552, 370);
            deleteRecipeButton.Name = "deleteRecipeButton";
            deleteRecipeButton.Size = new Size(100, 30);
            deleteRecipeButton.TabIndex = 1;
            deleteRecipeButton.Text = "Delete";
            deleteRecipeButton.UseVisualStyleBackColor = true;
            // 
            // editRecipeButton
            // 
            editRecipeButton.Location = new Point(427, 370);
            editRecipeButton.Name = "editRecipeButton";
            editRecipeButton.Size = new Size(100, 30);
            editRecipeButton.TabIndex = 2;
            editRecipeButton.Text = "Edit";
            editRecipeButton.UseVisualStyleBackColor = true;
            editRecipeButton.Click += editRecipeButton_Click;
            // 
            // saveRecipeButton
            // 
            saveRecipeButton.Location = new Point(302, 370);
            saveRecipeButton.Name = "saveRecipeButton";
            saveRecipeButton.Size = new Size(100, 30);
            saveRecipeButton.TabIndex = 3;
            saveRecipeButton.Text = "Save";
            saveRecipeButton.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(106, 91);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // ingredientsLabel
            // 
            ingredientsLabel.AutoSize = true;
            ingredientsLabel.Location = new Point(86, 137);
            ingredientsLabel.Name = "ingredientsLabel";
            ingredientsLabel.Size = new Size(69, 15);
            ingredientsLabel.TabIndex = 5;
            ingredientsLabel.Text = "Ingredients:";
            // 
            // directionsLabel
            // 
            directionsLabel.AutoSize = true;
            directionsLabel.Location = new Point(302, 137);
            directionsLabel.Name = "directionsLabel";
            directionsLabel.Size = new Size(63, 15);
            directionsLabel.TabIndex = 6;
            directionsLabel.Text = "Directions:";
            // 
            // mealTypeLabel
            // 
            mealTypeLabel.AutoSize = true;
            mealTypeLabel.Location = new Point(375, 90);
            mealTypeLabel.Name = "mealTypeLabel";
            mealTypeLabel.Size = new Size(63, 15);
            mealTypeLabel.TabIndex = 7;
            mealTypeLabel.Text = "Meal Type:";
            // 
            // mealTypeDropdown
            // 
            mealTypeDropdown.Enabled = false;
            mealTypeDropdown.FormattingEnabled = true;
            mealTypeDropdown.Items.AddRange(new object[] { "Breakfast", "Lunch", "Dinner", "Dessert" });
            mealTypeDropdown.Location = new Point(463, 87);
            mealTypeDropdown.Name = "mealTypeDropdown";
            mealTypeDropdown.Size = new Size(121, 23);
            mealTypeDropdown.TabIndex = 8;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(194, 87);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(121, 23);
            nameTextBox.TabIndex = 9;
            // 
            // directionsDataGrid
            // 
            directionsDataGrid.AllowUserToOrderColumns = true;
            directionsDataGrid.AllowUserToResizeColumns = false;
            directionsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            directionsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            directionsDataGrid.BackgroundColor = SystemColors.ButtonFace;
            directionsDataGrid.BorderStyle = BorderStyle.Fixed3D;
            directionsDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            directionsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            directionsDataGrid.Columns.AddRange(new DataGridViewColumn[] { directionsColumn });
            directionsDataGrid.GridColor = SystemColors.Window;
            directionsDataGrid.Location = new Point(302, 155);
            directionsDataGrid.Name = "directionsDataGrid";
            directionsDataGrid.ReadOnly = true;
            directionsDataGrid.RowHeadersVisible = false;
            directionsDataGrid.RowHeadersWidth = 20;
            directionsDataGrid.ScrollBars = ScrollBars.Horizontal;
            directionsDataGrid.Size = new Size(350, 198);
            directionsDataGrid.TabIndex = 10;
            // 
            // directionsColumn
            // 
            directionsColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            directionsColumn.DividerWidth = 1;
            directionsColumn.HeaderText = "";
            directionsColumn.MinimumWidth = 346;
            directionsColumn.Name = "directionsColumn";
            directionsColumn.ReadOnly = true;
            directionsColumn.Resizable = DataGridViewTriState.False;
            directionsColumn.Width = 346;
            // 
            // ingredientsDataGrid
            // 
            ingredientsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            ingredientsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            ingredientsDataGrid.BackgroundColor = SystemColors.ButtonFace;
            ingredientsDataGrid.BorderStyle = BorderStyle.Fixed3D;
            ingredientsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ingredientsDataGrid.Columns.AddRange(new DataGridViewColumn[] { ingredientsColumn });
            ingredientsDataGrid.GridColor = SystemColors.Window;
            ingredientsDataGrid.Location = new Point(86, 155);
            ingredientsDataGrid.Name = "ingredientsDataGrid";
            ingredientsDataGrid.ReadOnly = true;
            ingredientsDataGrid.RowHeadersVisible = false;
            ingredientsDataGrid.Size = new Size(186, 245);
            ingredientsDataGrid.TabIndex = 11;
            // 
            // ingredientsColumn
            // 
            ingredientsColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ingredientsColumn.DividerWidth = 1;
            ingredientsColumn.HeaderText = "";
            ingredientsColumn.MinimumWidth = 134;
            ingredientsColumn.Name = "ingredientsColumn";
            ingredientsColumn.ReadOnly = true;
            ingredientsColumn.Resizable = DataGridViewTriState.False;
            // 
            // SingleRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(757, 445);
            Controls.Add(ingredientsDataGrid);
            Controls.Add(directionsDataGrid);
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
            Load += SingleRecipe_Load;
            ((System.ComponentModel.ISupportInitialize)directionsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingredientsDataGrid).EndInit();
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
        private DataGridView directionsDataGrid;
        private DataGridView ingredientsDataGrid;
        private DataGridViewTextBoxColumn directionsColumn;
        private DataGridViewTextBoxColumn ingredientsColumn;
    }
}