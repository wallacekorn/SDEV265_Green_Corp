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
            ((System.ComponentModel.ISupportInitialize)instructionsImage).BeginInit();
            SuspendLayout();
            // 
            // instructionsHeader
            // 
            instructionsHeader.AutoSize = true;
            instructionsHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instructionsHeader.Location = new Point(12, 140);
            instructionsHeader.Name = "instructionsHeader";
            instructionsHeader.Size = new Size(337, 32);
            instructionsHeader.TabIndex = 0;
            instructionsHeader.Text = "How to Use This Application";
            instructionsHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 191);
            label1.Name = "label1";
            label1.Size = new Size(591, 15);
            label1.TabIndex = 1;
            label1.Text = "To Load a list of Recipes and their directions/ingredients, select File > Load and find your recipes file recipes.csv\r\n";
            // 
            // instructionsExitButton
            // 
            instructionsExitButton.Location = new Point(582, 12);
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
            instructionsImage.Location = new Point(298, 13);
            instructionsImage.Name = "instructionsImage";
            instructionsImage.Size = new Size(88, 101);
            instructionsImage.SizeMode = PictureBoxSizeMode.CenterImage;
            instructionsImage.TabIndex = 3;
            instructionsImage.TabStop = false;
            // 
            // Instructions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(677, 450);
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
    }
}