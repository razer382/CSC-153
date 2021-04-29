
namespace KineticEnergy
{
    partial class Form1
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
            this.massLabel = new System.Windows.Forms.Label();
            this.entryGroupBox = new System.Windows.Forms.GroupBox();
            this.velocityLabel = new System.Windows.Forms.Label();
            this.massTextBox = new System.Windows.Forms.TextBox();
            this.velocityTextBox = new System.Windows.Forms.TextBox();
            this.kineticEnergyLabel = new System.Windows.Forms.Label();
            this.kineticEnergyText = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.entryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // massLabel
            // 
            this.massLabel.AutoSize = true;
            this.massLabel.Location = new System.Drawing.Point(19, 16);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(35, 13);
            this.massLabel.TabIndex = 0;
            this.massLabel.Text = "Mass:";
            // 
            // entryGroupBox
            // 
            this.entryGroupBox.Controls.Add(this.velocityTextBox);
            this.entryGroupBox.Controls.Add(this.massTextBox);
            this.entryGroupBox.Controls.Add(this.velocityLabel);
            this.entryGroupBox.Controls.Add(this.massLabel);
            this.entryGroupBox.Location = new System.Drawing.Point(13, 13);
            this.entryGroupBox.Name = "entryGroupBox";
            this.entryGroupBox.Size = new System.Drawing.Size(177, 62);
            this.entryGroupBox.TabIndex = 1;
            this.entryGroupBox.TabStop = false;
            this.entryGroupBox.Text = "Enter Data";
            // 
            // velocityLabel
            // 
            this.velocityLabel.AutoSize = true;
            this.velocityLabel.Location = new System.Drawing.Point(8, 39);
            this.velocityLabel.Name = "velocityLabel";
            this.velocityLabel.Size = new System.Drawing.Size(47, 13);
            this.velocityLabel.TabIndex = 1;
            this.velocityLabel.Text = "Velocity:";
            // 
            // massTextBox
            // 
            this.massTextBox.Location = new System.Drawing.Point(61, 13);
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.Size = new System.Drawing.Size(100, 20);
            this.massTextBox.TabIndex = 2;
            // 
            // velocityTextBox
            // 
            this.velocityTextBox.Location = new System.Drawing.Point(61, 36);
            this.velocityTextBox.Name = "velocityTextBox";
            this.velocityTextBox.Size = new System.Drawing.Size(100, 20);
            this.velocityTextBox.TabIndex = 2;
            // 
            // kineticEnergyLabel
            // 
            this.kineticEnergyLabel.AutoSize = true;
            this.kineticEnergyLabel.Location = new System.Drawing.Point(13, 92);
            this.kineticEnergyLabel.Name = "kineticEnergyLabel";
            this.kineticEnergyLabel.Size = new System.Drawing.Size(78, 13);
            this.kineticEnergyLabel.TabIndex = 2;
            this.kineticEnergyLabel.Text = "Kinetic Energy:";
            // 
            // kineticEnergyText
            // 
            this.kineticEnergyText.AutoSize = true;
            this.kineticEnergyText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kineticEnergyText.Location = new System.Drawing.Point(98, 92);
            this.kineticEnergyText.MinimumSize = new System.Drawing.Size(73, 0);
            this.kineticEnergyText.Name = "kineticEnergyText";
            this.kineticEnergyText.Size = new System.Drawing.Size(73, 13);
            this.kineticEnergyText.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(119, 134);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(55, 39);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(16, 124);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 58);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate Kinetic Energy";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 204);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.kineticEnergyText);
            this.Controls.Add(this.kineticEnergyLabel);
            this.Controls.Add(this.entryGroupBox);
            this.Name = "Form1";
            this.Text = "Kinetic Energy";
            this.entryGroupBox.ResumeLayout(false);
            this.entryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label massLabel;
        private System.Windows.Forms.GroupBox entryGroupBox;
        private System.Windows.Forms.TextBox velocityTextBox;
        private System.Windows.Forms.TextBox massTextBox;
        private System.Windows.Forms.Label velocityLabel;
        private System.Windows.Forms.Label kineticEnergyLabel;
        private System.Windows.Forms.Label kineticEnergyText;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
    }
}

