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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            ingredientsDataGrid = new DataGridView();
            ingredientsColumn = new DataGridViewTextBoxColumn();
            clearButton = new Button();
            headerLabelARecipe = new Label();
            directionsColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)directionsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredientsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // recipeExitButton
            // 
            recipeExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recipeExitButton.Location = new Point(665, 12);
            recipeExitButton.Name = "recipeExitButton";
            recipeExitButton.Size = new Size(85, 25);
            recipeExitButton.TabIndex = 0;
            recipeExitButton.Text = "Exit";
            recipeExitButton.UseVisualStyleBackColor = true;
            recipeExitButton.Click += recipeExitButton_Click;
            // 
            // deleteRecipeButton
            // 
            deleteRecipeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteRecipeButton.Location = new Point(592, 370);
            deleteRecipeButton.Name = "deleteRecipeButton";
            deleteRecipeButton.Size = new Size(100, 30);
            deleteRecipeButton.TabIndex = 1;
            deleteRecipeButton.Text = "Delete";
            deleteRecipeButton.UseVisualStyleBackColor = true;
            deleteRecipeButton.Click += deleteRecipeButton_Click;
            // 
            // editRecipeButton
            // 
            editRecipeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editRecipeButton.Location = new Point(576, 76);
            editRecipeButton.Name = "editRecipeButton";
            editRecipeButton.Size = new Size(100, 30);
            editRecipeButton.TabIndex = 2;
            editRecipeButton.Text = "Edit";
            editRecipeButton.UseVisualStyleBackColor = true;
            editRecipeButton.Click += editRecipeButton_Click;
            // 
            // saveRecipeButton
            // 
            saveRecipeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveRecipeButton.Location = new Point(342, 370);
            saveRecipeButton.Name = "saveRecipeButton";
            saveRecipeButton.Size = new Size(100, 30);
            saveRecipeButton.TabIndex = 3;
            saveRecipeButton.Text = "Save";
            saveRecipeButton.UseVisualStyleBackColor = true;
            saveRecipeButton.Click += saveRecipeButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(90, 80);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(55, 21);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // ingredientsLabel
            // 
            ingredientsLabel.AutoSize = true;
            ingredientsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ingredientsLabel.Location = new Point(46, 136);
            ingredientsLabel.Name = "ingredientsLabel";
            ingredientsLabel.Size = new Size(91, 21);
            ingredientsLabel.TabIndex = 5;
            ingredientsLabel.Text = "Ingredients:";
            // 
            // directionsLabel
            // 
            directionsLabel.AutoSize = true;
            directionsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            directionsLabel.Location = new Point(302, 136);
            directionsLabel.Name = "directionsLabel";
            directionsLabel.Size = new Size(83, 21);
            directionsLabel.TabIndex = 6;
            directionsLabel.Text = "Directions:";
            // 
            // mealTypeLabel
            // 
            mealTypeLabel.AutoSize = true;
            mealTypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mealTypeLabel.Location = new Point(326, 80);
            mealTypeLabel.Name = "mealTypeLabel";
            mealTypeLabel.Size = new Size(83, 21);
            mealTypeLabel.TabIndex = 7;
            mealTypeLabel.Text = "Meal Type:";
            // 
            // mealTypeDropdown
            // 
            mealTypeDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            mealTypeDropdown.Enabled = false;
            mealTypeDropdown.FormattingEnabled = true;
            mealTypeDropdown.Items.AddRange(new object[] { "Breakfast", "Lunch", "Dinner", "Dessert" });
            mealTypeDropdown.Location = new Point(415, 80);
            mealTypeDropdown.Name = "mealTypeDropdown";
            mealTypeDropdown.Size = new Size(121, 23);
            mealTypeDropdown.TabIndex = 8;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(151, 80);
            nameTextBox.MaxLength = 50;
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
            directionsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            directionsDataGrid.BackgroundColor = SystemColors.ButtonFace;
            directionsDataGrid.BorderStyle = BorderStyle.Fixed3D;
            directionsDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            directionsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            directionsDataGrid.ColumnHeadersVisible = false;
            directionsDataGrid.Columns.AddRange(new DataGridViewColumn[] { directionsColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            directionsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            directionsDataGrid.GridColor = SystemColors.Window;
            directionsDataGrid.Location = new Point(302, 155);
            directionsDataGrid.Name = "directionsDataGrid";
            directionsDataGrid.ReadOnly = true;
            directionsDataGrid.RowHeadersVisible = false;
            directionsDataGrid.RowHeadersWidth = 20;
            directionsDataGrid.ScrollBars = ScrollBars.Vertical;
            directionsDataGrid.Size = new Size(428, 198);
            directionsDataGrid.TabIndex = 10;
            // 
            // ingredientsDataGrid
            // 
            ingredientsDataGrid.AllowUserToResizeColumns = false;
            ingredientsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 192, 255);
            ingredientsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            ingredientsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ingredientsDataGrid.BackgroundColor = SystemColors.ButtonFace;
            ingredientsDataGrid.BorderStyle = BorderStyle.Fixed3D;
            ingredientsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ingredientsDataGrid.Columns.AddRange(new DataGridViewColumn[] { ingredientsColumn });
            ingredientsDataGrid.GridColor = SystemColors.Window;
            ingredientsDataGrid.Location = new Point(46, 155);
            ingredientsDataGrid.Name = "ingredientsDataGrid";
            ingredientsDataGrid.ReadOnly = true;
            ingredientsDataGrid.RowHeadersVisible = false;
            ingredientsDataGrid.Size = new Size(226, 245);
            ingredientsDataGrid.TabIndex = 11;
            // 
            // ingredientsColumn
            // 
            ingredientsColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ingredientsColumn.DividerWidth = 1;
            ingredientsColumn.HeaderText = "";
            ingredientsColumn.MaxInputLength = 100;
            ingredientsColumn.MinimumWidth = 134;
            ingredientsColumn.Name = "ingredientsColumn";
            ingredientsColumn.ReadOnly = true;
            ingredientsColumn.Resizable = DataGridViewTriState.False;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(469, 370);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(100, 30);
            clearButton.TabIndex = 12;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // headerLabelARecipe
            // 
            headerLabelARecipe.AutoSize = true;
            headerLabelARecipe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabelARecipe.Location = new Point(34, 19);
            headerLabelARecipe.Name = "headerLabelARecipe";
            headerLabelARecipe.Size = new Size(206, 32);
            headerLabelARecipe.TabIndex = 13;
            headerLabelARecipe.Text = "View/Edit Recipe";
            // 
            // directionsColumn
            // 
            directionsColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            directionsColumn.DividerWidth = 1;
            directionsColumn.HeaderText = "";
            directionsColumn.MaxInputLength = 100;
            directionsColumn.MinimumWidth = 347;
            directionsColumn.Name = "directionsColumn";
            directionsColumn.ReadOnly = true;
            directionsColumn.Resizable = DataGridViewTriState.False;
            // 
            // SingleRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(757, 445);
            Controls.Add(headerLabelARecipe);
            Controls.Add(clearButton);
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
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SingleRecipe";
            Text = "RMS - View/Edit Recipe";
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
        private Button clearButton;
        private Label headerLabelARecipe;
        private DataGridViewTextBoxColumn ingredientsColumn;
        private DataGridViewTextBoxColumn directionsColumn;
    }
}