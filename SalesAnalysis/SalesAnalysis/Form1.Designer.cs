
namespace SalesAnalysis
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
            this.salesListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.averageText = new System.Windows.Forms.Label();
            this.largestLabel = new System.Windows.Forms.Label();
            this.smallestLabel = new System.Windows.Forms.Label();
            this.largestText = new System.Windows.Forms.Label();
            this.smallestText = new System.Windows.Forms.Label();
            this.salesGroupBox = new System.Windows.Forms.GroupBox();
            this.salesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesListBox
            // 
            this.salesListBox.FormattingEnabled = true;
            this.salesListBox.Location = new System.Drawing.Point(18, 18);
            this.salesListBox.Name = "salesListBox";
            this.salesListBox.Size = new System.Drawing.Size(100, 160);
            this.salesListBox.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(103, 312);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(41, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(23, 312);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(66, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(20, 211);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total:";
            // 
            // totalText
            // 
            this.totalText.AutoSize = true;
            this.totalText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalText.Location = new System.Drawing.Point(60, 211);
            this.totalText.MinimumSize = new System.Drawing.Size(85, 0);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(85, 13);
            this.totalText.TabIndex = 4;
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(3, 231);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(50, 13);
            this.averageLabel.TabIndex = 4;
            this.averageLabel.Text = "Average:";
            // 
            // averageText
            // 
            this.averageText.AutoSize = true;
            this.averageText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.averageText.Location = new System.Drawing.Point(59, 231);
            this.averageText.MinimumSize = new System.Drawing.Size(85, 0);
            this.averageText.Name = "averageText";
            this.averageText.Size = new System.Drawing.Size(85, 13);
            this.averageText.TabIndex = 4;
            // 
            // largestLabel
            // 
            this.largestLabel.AutoSize = true;
            this.largestLabel.Location = new System.Drawing.Point(9, 253);
            this.largestLabel.Name = "largestLabel";
            this.largestLabel.Size = new System.Drawing.Size(45, 13);
            this.largestLabel.TabIndex = 4;
            this.largestLabel.Text = "Largest:";
            // 
            // smallestLabel
            // 
            this.smallestLabel.AutoSize = true;
            this.smallestLabel.Location = new System.Drawing.Point(5, 276);
            this.smallestLabel.Name = "smallestLabel";
            this.smallestLabel.Size = new System.Drawing.Size(49, 13);
            this.smallestLabel.TabIndex = 4;
            this.smallestLabel.Text = "Smallest:";
            // 
            // largestText
            // 
            this.largestText.AutoSize = true;
            this.largestText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.largestText.Location = new System.Drawing.Point(59, 253);
            this.largestText.MinimumSize = new System.Drawing.Size(85, 0);
            this.largestText.Name = "largestText";
            this.largestText.Size = new System.Drawing.Size(85, 13);
            this.largestText.TabIndex = 4;
            // 
            // smallestText
            // 
            this.smallestText.AutoSize = true;
            this.smallestText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.smallestText.Location = new System.Drawing.Point(60, 276);
            this.smallestText.MinimumSize = new System.Drawing.Size(85, 0);
            this.smallestText.Name = "smallestText";
            this.smallestText.Size = new System.Drawing.Size(85, 13);
            this.smallestText.TabIndex = 4;
            // 
            // salesGroupBox
            // 
            this.salesGroupBox.Controls.Add(this.salesListBox);
            this.salesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.salesGroupBox.Name = "salesGroupBox";
            this.salesGroupBox.Size = new System.Drawing.Size(134, 186);
            this.salesGroupBox.TabIndex = 5;
            this.salesGroupBox.TabStop = false;
            this.salesGroupBox.Text = "Sales";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 359);
            this.Controls.Add(this.salesGroupBox);
            this.Controls.Add(this.smallestText);
            this.Controls.Add(this.largestText);
            this.Controls.Add(this.averageText);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.smallestLabel);
            this.Controls.Add(this.largestLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "SalesAnalysisList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.salesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalText;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label averageText;
        private System.Windows.Forms.Label largestLabel;
        private System.Windows.Forms.Label smallestLabel;
        private System.Windows.Forms.Label largestText;
        private System.Windows.Forms.Label smallestText;
        private System.Windows.Forms.GroupBox salesGroupBox;
        private System.Windows.Forms.ListBox salesListBox;
    }
}

