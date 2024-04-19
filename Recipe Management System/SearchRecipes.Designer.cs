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
            textBox1 = new TextBox();
            label1 = new Label();
            searchCRUDbutton = new Button();
            searchHeader = new Label();
            SuspendLayout();
            // 
            // searchExitButton
            // 
            searchExitButton.Location = new Point(354, 12);
            searchExitButton.Name = "searchExitButton";
            searchExitButton.Size = new Size(75, 23);
            searchExitButton.TabIndex = 0;
            searchExitButton.Text = "Exit";
            searchExitButton.UseVisualStyleBackColor = true;
            searchExitButton.Click += searchExitButton_Click;
            // 
            // searchListBox
            // 
            searchListBox.FormattingEnabled = true;
            searchListBox.ItemHeight = 15;
            searchListBox.Location = new Point(104, 157);
            searchListBox.Name = "searchListBox";
            searchListBox.Size = new Size(241, 139);
            searchListBox.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 121);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 3;
            label1.Text = "Search by Recipe Name";
            // 
            // searchCRUDbutton
            // 
            searchCRUDbutton.Location = new Point(270, 314);
            searchCRUDbutton.Name = "searchCRUDbutton";
            searchCRUDbutton.Size = new Size(75, 23);
            searchCRUDbutton.TabIndex = 4;
            searchCRUDbutton.Text = "View/Edit";
            searchCRUDbutton.UseVisualStyleBackColor = true;
            searchCRUDbutton.Click += searchCRUDbutton_Click;
            // 
            // searchHeader
            // 
            searchHeader.AutoSize = true;
            searchHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchHeader.Location = new Point(63, 55);
            searchHeader.Name = "searchHeader";
            searchHeader.Size = new Size(89, 32);
            searchHeader.TabIndex = 5;
            searchHeader.Text = "Search";
            // 
            // SearchRecipes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(441, 450);
            Controls.Add(searchHeader);
            Controls.Add(searchCRUDbutton);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(searchListBox);
            Controls.Add(searchExitButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SearchRecipes";
            Text = "RMS - Search Recipe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchExitButton;
        private ListBox searchListBox;
        private TextBox textBox1;
        private Label label1;
        private Button searchCRUDbutton;
        private Label searchHeader;
    }
}