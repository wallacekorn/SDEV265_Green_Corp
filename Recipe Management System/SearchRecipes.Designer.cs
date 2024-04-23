namespace Recipe_Management_System
{
    partial class SearchRecipes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchRecipes));
            searchExitButton = new Button();
            searchListBox = new ListBox();
            searchBar = new TextBox();
            label1 = new Label();
            searchHeader = new Label();
            searchButton = new Button();
            nameRadioButton = new RadioButton();
            ingredientRadioButton = new RadioButton();
            typeComboBox = new ComboBox();
            mealTypeRadioButton = new RadioButton();
            searchViewRecipe = new Button();
            SuspendLayout();
            // 
            // searchExitButton
            // 
            searchExitButton.Location = new Point(344, 12);
            searchExitButton.Name = "searchExitButton";
            searchExitButton.Size = new Size(85, 25);
            searchExitButton.TabIndex = 0;
            searchExitButton.Text = "Exit";
            searchExitButton.UseVisualStyleBackColor = true;
            searchExitButton.Click += searchExitButton_Click;
            // 
            // searchListBox
            // 
            searchListBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchListBox.FormattingEnabled = true;
            searchListBox.ItemHeight = 17;
            searchListBox.Location = new Point(52, 158);
            searchListBox.Name = "searchListBox";
            searchListBox.Size = new Size(323, 191);
            searchListBox.TabIndex = 1;
            // 
            // searchBar
            // 
            searchBar.BorderStyle = BorderStyle.FixedSingle;
            searchBar.Location = new Point(225, 76);
            searchBar.MinimumSize = new Size(0, 25);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(140, 25);
            searchBar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 56);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 3;
            label1.Text = "Search by:";
            // 
            // searchHeader
            // 
            searchHeader.AutoSize = true;
            searchHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchHeader.Location = new Point(39, 12);
            searchHeader.Name = "searchHeader";
            searchHeader.Size = new Size(89, 32);
            searchHeader.TabIndex = 5;
            searchHeader.Text = "Search";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(245, 113);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(100, 30);
            searchButton.TabIndex = 6;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // nameRadioButton
            // 
            nameRadioButton.AutoSize = true;
            nameRadioButton.Location = new Point(103, 74);
            nameRadioButton.Name = "nameRadioButton";
            nameRadioButton.Size = new Size(95, 19);
            nameRadioButton.TabIndex = 7;
            nameRadioButton.TabStop = true;
            nameRadioButton.Text = "Recipe Name";
            nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // ingredientRadioButton
            // 
            ingredientRadioButton.AutoSize = true;
            ingredientRadioButton.Location = new Point(103, 97);
            ingredientRadioButton.Name = "ingredientRadioButton";
            ingredientRadioButton.Size = new Size(79, 19);
            ingredientRadioButton.TabIndex = 8;
            ingredientRadioButton.TabStop = true;
            ingredientRadioButton.Text = "Ingredient";
            ingredientRadioButton.UseVisualStyleBackColor = true;
            // 
            // typeComboBox
            // 
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.DropDownWidth = 75;
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Items.AddRange(new object[] { "Breakfast", "Lunch", "Dinner", "Dessert" });
            typeComboBox.Location = new Point(121, 118);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(75, 23);
            typeComboBox.TabIndex = 10;
            typeComboBox.Click += typeComboBox_Click;
            // 
            // mealTypeRadioButton
            // 
            mealTypeRadioButton.AutoSize = true;
            mealTypeRadioButton.Location = new Point(103, 122);
            mealTypeRadioButton.Name = "mealTypeRadioButton";
            mealTypeRadioButton.Size = new Size(14, 13);
            mealTypeRadioButton.TabIndex = 11;
            mealTypeRadioButton.TabStop = true;
            mealTypeRadioButton.UseVisualStyleBackColor = true;
            mealTypeRadioButton.CheckedChanged += mealTypeRadioButton_CheckedChanged;
            // 
            // searchViewRecipe
            // 
            searchViewRecipe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchViewRecipe.Location = new Point(275, 365);
            searchViewRecipe.Name = "searchViewRecipe";
            searchViewRecipe.Size = new Size(100, 30);
            searchViewRecipe.TabIndex = 12;
            searchViewRecipe.Text = "View/Edit";
            searchViewRecipe.UseVisualStyleBackColor = true;
            searchViewRecipe.Click += searchViewRecipe_Click;
            // 
            // SearchRecipes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(441, 450);
            Controls.Add(searchViewRecipe);
            Controls.Add(mealTypeRadioButton);
            Controls.Add(typeComboBox);
            Controls.Add(ingredientRadioButton);
            Controls.Add(nameRadioButton);
            Controls.Add(searchButton);
            Controls.Add(searchHeader);
            Controls.Add(label1);
            Controls.Add(searchBar);
            Controls.Add(searchListBox);
            Controls.Add(searchExitButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SearchRecipes";
            Text = "RMS - Search Recipe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchExitButton;
        private ListBox searchListBox;
        private TextBox searchBar;
        private Label label1;
        private Label searchHeader;
        private Button searchButton;
        private RadioButton nameRadioButton;
        private RadioButton ingredientRadioButton;
        private ComboBox typeComboBox;
        private RadioButton mealTypeRadioButton;
        private Button searchViewRecipe;
    }
}