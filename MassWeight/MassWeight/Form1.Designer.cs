
namespace MassWeight
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
            this.entryGroupBox = new System.Windows.Forms.GroupBox();
            this.massTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.weightText = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.entryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryGroupBox
            // 
            this.entryGroupBox.Controls.Add(this.massTextBox);
            this.entryGroupBox.Controls.Add(this.weightLabel);
            this.entryGroupBox.Location = new System.Drawing.Point(12, 13);
            this.entryGroupBox.Name = "entryGroupBox";
            this.entryGroupBox.Size = new System.Drawing.Size(163, 51);
            this.entryGroupBox.TabIndex = 0;
            this.entryGroupBox.TabStop = false;
            this.entryGroupBox.Text = "Enter Mass";
            // 
            // massTextBox
            // 
            this.massTextBox.Location = new System.Drawing.Point(48, 17);
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.Size = new System.Drawing.Size(100, 20);
            this.massTextBox.TabIndex = 1;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(7, 20);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(35, 13);
            this.weightLabel.TabIndex = 0;
            this.weightLabel.Text = "Mass:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Weight:";
            // 
            // weightText
            // 
            this.weightText.AutoSize = true;
            this.weightText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.weightText.Location = new System.Drawing.Point(57, 86);
            this.weightText.MinimumSize = new System.Drawing.Size(100, 0);
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(100, 13);
            this.weightText.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 129);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(61, 36);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate Weight";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(81, 136);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(43, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(130, 136);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(49, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 179);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.weightText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entryGroupBox);
            this.Name = "Form1";
            this.Text = "Mass Calculator";
            this.entryGroupBox.ResumeLayout(false);
            this.entryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox entryGroupBox;
        private System.Windows.Forms.TextBox massTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label weightText;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

