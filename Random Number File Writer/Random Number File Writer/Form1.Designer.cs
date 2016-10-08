namespace Random_Number_File_Writer
{
    partial class RandomNumberGenerator
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
            this.discriptionLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.amtNumsTextBox = new System.Windows.Forms.TextBox();
            this.writeNumButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // discriptionLabel
            // 
            this.discriptionLabel.AutoSize = true;
            this.discriptionLabel.Location = new System.Drawing.Point(12, 18);
            this.discriptionLabel.Name = "discriptionLabel";
            this.discriptionLabel.Size = new System.Drawing.Size(300, 13);
            this.discriptionLabel.TabIndex = 0;
            this.discriptionLabel.Text = "This application will write random numbers to a file you specify.";
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(64, 65);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(138, 13);
            this.promptLabel.TabIndex = 1;
            this.promptLabel.Text = "Amount of numbers to write:";
            // 
            // amtNumsTextBox
            // 
            this.amtNumsTextBox.Location = new System.Drawing.Point(208, 62);
            this.amtNumsTextBox.Name = "amtNumsTextBox";
            this.amtNumsTextBox.Size = new System.Drawing.Size(44, 20);
            this.amtNumsTextBox.TabIndex = 2;
            this.amtNumsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // writeNumButton
            // 
            this.writeNumButton.Location = new System.Drawing.Point(75, 97);
            this.writeNumButton.Name = "writeNumButton";
            this.writeNumButton.Size = new System.Drawing.Size(75, 34);
            this.writeNumButton.TabIndex = 3;
            this.writeNumButton.Text = "Write Numbers";
            this.writeNumButton.UseVisualStyleBackColor = true;
            this.writeNumButton.Click += new System.EventHandler(this.writeNumButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(172, 97);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 34);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // RandomNumberGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 146);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeNumButton);
            this.Controls.Add(this.amtNumsTextBox);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.discriptionLabel);
            this.Name = "RandomNumberGenerator";
            this.Text = "Random Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label discriptionLabel;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox amtNumsTextBox;
        private System.Windows.Forms.Button writeNumButton;
        private System.Windows.Forms.Button exitButton;
    }
}

