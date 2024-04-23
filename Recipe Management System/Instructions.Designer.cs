namespace Recipe_Management_System
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            instructionsHeader = new Label();
            label1 = new Label();
            instructionsExitButton = new Button();
            instructionsImage = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)instructionsImage).BeginInit();
            SuspendLayout();
            // 
            // instructionsHeader
            // 
            instructionsHeader.AutoSize = true;
            instructionsHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instructionsHeader.Location = new Point(22, 12);
            instructionsHeader.Name = "instructionsHeader";
            instructionsHeader.Size = new Size(337, 32);
            instructionsHeader.TabIndex = 0;
            instructionsHeader.Text = "How to Use This Application";
            instructionsHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 113);
            label1.Name = "label1";
            label1.Size = new Size(526, 45);
            label1.TabIndex = 1;
            label1.Text = "To Load another list of Recipes and their directions/ingredients: \r\n                                             Select File > Load from the Welcome screen and find your recipes.csv file\r\n\r\n";
            // 
            // instructionsExitButton
            // 
            instructionsExitButton.Location = new Point(684, 12);
            instructionsExitButton.Name = "instructionsExitButton";
            instructionsExitButton.Size = new Size(85, 25);
            instructionsExitButton.TabIndex = 2;
            instructionsExitButton.Text = "Exit";
            instructionsExitButton.UseVisualStyleBackColor = true;
            instructionsExitButton.Click += instructionsExitButton_Click;
            // 
            // instructionsImage
            // 
            instructionsImage.Image = (Image)resources.GetObject("instructionsImage.Image");
            instructionsImage.Location = new Point(681, 55);
            instructionsImage.Name = "instructionsImage";
            instructionsImage.Size = new Size(88, 101);
            instructionsImage.SizeMode = PictureBoxSizeMode.CenterImage;
            instructionsImage.TabIndex = 3;
            instructionsImage.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(174, 145);
            label2.Name = "label2";
            label2.Size = new Size(446, 13);
            label2.TabIndex = 4;
            label2.Text = "(the related filenames MUST be named Ingredients.csv and Directions.csv respectively)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 68);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 5;
            label3.Text = "Load";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 93);
            label4.Name = "label4";
            label4.Size = new Size(588, 15);
            label4.TabIndex = 6;
            label4.Text = "Application folder/recipes/recipes.csv and it's accompanied files will be loaded automatically loaded if present";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 160);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 7;
            label5.Text = "Create";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 308);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 8;
            label6.Text = "Delete";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 379);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 9;
            label7.Text = "Search";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 183);
            label8.Name = "label8";
            label8.Size = new Size(423, 60);
            label8.TabIndex = 10;
            label8.Text = resources.GetString("label8.Text");
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 335);
            label9.Name = "label9";
            label9.Size = new Size(685, 30);
            label9.TabIndex = 11;
            label9.Text = resources.GetString("label9.Text");
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 406);
            label10.Name = "label10";
            label10.Size = new Size(740, 45);
            label10.TabIndex = 12;
            label10.Text = resources.GetString("label10.Text");
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label11.Location = new Point(22, 254);
            label11.Name = "label11";
            label11.Size = new Size(85, 21);
            label11.TabIndex = 13;
            label11.Text = "Edit/View";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(41, 278);
            label12.Name = "label12";
            label12.Size = new Size(641, 30);
            label12.TabIndex = 14;
            label12.Text = "Select a recipe from the dropdown menu on the Welcome screen, click \"View/Edit,\" then \"Edit\" to unlock the input fields\r\n ";
            // 
            // Instructions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(781, 476);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(instructionsImage);
            Controls.Add(instructionsExitButton);
            Controls.Add(label1);
            Controls.Add(instructionsHeader);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Instructions";
            Text = "RMS - Instructions";
            ((System.ComponentModel.ISupportInitialize)instructionsImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label instructionsHeader;
        private Label label1;
        private Button instructionsExitButton;
        private PictureBox instructionsImage;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}