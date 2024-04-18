namespace Recipe_Management_System
{
    partial class WelcomeScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            recipeComboBox = new ComboBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            instructionsButton = new Button();
            recipeCRUDbutton = new Button();
            searchButton = new Button();
            welcomeImage = new PictureBox();
            newRecipeButton = new Button();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)welcomeImage).BeginInit();
            SuspendLayout();
            // 
            // recipeComboBox
            // 
            recipeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            recipeComboBox.FormattingEnabled = true;
            recipeComboBox.Location = new Point(200, 335);
            recipeComboBox.Name = "recipeComboBox";
            recipeComboBox.Size = new Size(156, 23);
            recipeComboBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.MenuBar;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(657, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadMenuItem, exitMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadMenuItem
            // 
            loadMenuItem.Name = "loadMenuItem";
            loadMenuItem.Size = new Size(100, 22);
            loadMenuItem.Text = "Load";
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(100, 22);
            exitMenuItem.Text = "Exit";
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // instructionsButton
            // 
            instructionsButton.Location = new Point(161, 256);
            instructionsButton.Name = "instructionsButton";
            instructionsButton.Size = new Size(100, 30);
            instructionsButton.TabIndex = 2;
            instructionsButton.Text = "Instructions";
            instructionsButton.UseVisualStyleBackColor = true;
            instructionsButton.Click += instructionsOpenButton_Click;
            // 
            // recipeCRUDbutton
            // 
            recipeCRUDbutton.Location = new Point(373, 334);
            recipeCRUDbutton.Name = "recipeCRUDbutton";
            recipeCRUDbutton.Size = new Size(83, 24);
            recipeCRUDbutton.TabIndex = 3;
            recipeCRUDbutton.Text = "View/Edit";
            recipeCRUDbutton.UseVisualStyleBackColor = true;
            recipeCRUDbutton.Click += recipeCRUDbutton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(278, 256);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(100, 30);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // welcomeImage
            // 
            welcomeImage.Image = (Image)resources.GetObject("welcomeImage.Image");
            welcomeImage.Location = new Point(128, 27);
            welcomeImage.Name = "welcomeImage";
            welcomeImage.Size = new Size(400, 200);
            welcomeImage.SizeMode = PictureBoxSizeMode.Zoom;
            welcomeImage.TabIndex = 5;
            welcomeImage.TabStop = false;
            // 
            // newRecipeButton
            // 
            newRecipeButton.Location = new Point(395, 256);
            newRecipeButton.Name = "newRecipeButton";
            newRecipeButton.Size = new Size(100, 30);
            newRecipeButton.TabIndex = 6;
            newRecipeButton.Text = "Add New";
            newRecipeButton.UseVisualStyleBackColor = true;
            newRecipeButton.Click += newRecipeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 313);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 7;
            label1.Text = "Select a Recipe";
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(657, 410);
            Controls.Add(label1);
            Controls.Add(newRecipeButton);
            Controls.Add(welcomeImage);
            Controls.Add(searchButton);
            Controls.Add(recipeCRUDbutton);
            Controls.Add(instructionsButton);
            Controls.Add(recipeComboBox);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "WelcomeScreen";
            Text = "Recipe Management System - Welcome";
            Load += WelcomeScreen_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)welcomeImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox recipeComboBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private Button instructionsButton;
        private Button recipeCRUDbutton;
        private Button searchButton;
        private PictureBox welcomeImage;
        private Button newRecipeButton;
        private Label label1;
    }
}
