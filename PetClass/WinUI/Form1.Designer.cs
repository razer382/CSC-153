
namespace WinUI
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
            this.petNameLabel = new System.Windows.Forms.Label();
            this.petTypeLabel = new System.Windows.Forms.Label();
            this.petAgeLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.petNameTextBox = new System.Windows.Forms.TextBox();
            this.petTypeTextBox = new System.Windows.Forms.TextBox();
            this.petAgeTextBox = new System.Windows.Forms.TextBox();
            this.entryBox = new System.Windows.Forms.GroupBox();
            this.displayBox = new System.Windows.Forms.GroupBox();
            this.petNameObjectLabel = new System.Windows.Forms.Label();
            this.petAgeObjectLabel = new System.Windows.Forms.Label();
            this.petTypeObjectLabel = new System.Windows.Forms.Label();
            this.petNameText = new System.Windows.Forms.Label();
            this.petAgeText = new System.Windows.Forms.Label();
            this.petTypeText = new System.Windows.Forms.Label();
            this.entryBox.SuspendLayout();
            this.displayBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // petNameLabel
            // 
            this.petNameLabel.AutoSize = true;
            this.petNameLabel.Location = new System.Drawing.Point(4, 17);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(57, 13);
            this.petNameLabel.TabIndex = 0;
            this.petNameLabel.Text = "Pet Name:";
            // 
            // petTypeLabel
            // 
            this.petTypeLabel.AutoSize = true;
            this.petTypeLabel.Location = new System.Drawing.Point(8, 43);
            this.petTypeLabel.Name = "petTypeLabel";
            this.petTypeLabel.Size = new System.Drawing.Size(53, 13);
            this.petTypeLabel.TabIndex = 1;
            this.petTypeLabel.Text = "Pet Type:";
            this.petTypeLabel.Click += new System.EventHandler(this.petTypeLabel_Click);
            // 
            // petAgeLabel
            // 
            this.petAgeLabel.AutoSize = true;
            this.petAgeLabel.Location = new System.Drawing.Point(13, 72);
            this.petAgeLabel.Name = "petAgeLabel";
            this.petAgeLabel.Size = new System.Drawing.Size(48, 13);
            this.petAgeLabel.TabIndex = 2;
            this.petAgeLabel.Text = "Pet Age:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(144, 251);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(84, 251);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(39, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(14, 238);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(55, 48);
            this.displayButton.TabIndex = 5;
            this.displayButton.Text = "Display Pet Info";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.petNameTextBox.Location = new System.Drawing.Point(67, 14);
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.petNameTextBox.TabIndex = 6;
            // 
            // petTypeTextBox
            // 
            this.petTypeTextBox.Location = new System.Drawing.Point(67, 43);
            this.petTypeTextBox.Name = "petTypeTextBox";
            this.petTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.petTypeTextBox.TabIndex = 7;
            // 
            // petAgeTextBox
            // 
            this.petAgeTextBox.Location = new System.Drawing.Point(67, 69);
            this.petAgeTextBox.Name = "petAgeTextBox";
            this.petAgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.petAgeTextBox.TabIndex = 8;
            // 
            // entryBox
            // 
            this.entryBox.Controls.Add(this.petNameLabel);
            this.entryBox.Controls.Add(this.petAgeTextBox);
            this.entryBox.Controls.Add(this.petNameTextBox);
            this.entryBox.Controls.Add(this.petTypeTextBox);
            this.entryBox.Controls.Add(this.petAgeLabel);
            this.entryBox.Controls.Add(this.petTypeLabel);
            this.entryBox.Location = new System.Drawing.Point(8, 12);
            this.entryBox.Name = "entryBox";
            this.entryBox.Size = new System.Drawing.Size(195, 97);
            this.entryBox.TabIndex = 9;
            this.entryBox.TabStop = false;
            this.entryBox.Text = "Enter Pet Info";
            // 
            // displayBox
            // 
            this.displayBox.Controls.Add(this.petTypeText);
            this.displayBox.Controls.Add(this.petAgeText);
            this.displayBox.Controls.Add(this.petNameText);
            this.displayBox.Controls.Add(this.petTypeObjectLabel);
            this.displayBox.Controls.Add(this.petAgeObjectLabel);
            this.displayBox.Controls.Add(this.petNameObjectLabel);
            this.displayBox.Location = new System.Drawing.Point(8, 128);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(195, 100);
            this.displayBox.TabIndex = 10;
            this.displayBox.TabStop = false;
            this.displayBox.Text = "Object Info";
            // 
            // petNameObjectLabel
            // 
            this.petNameObjectLabel.AutoSize = true;
            this.petNameObjectLabel.Location = new System.Drawing.Point(23, 25);
            this.petNameObjectLabel.Name = "petNameObjectLabel";
            this.petNameObjectLabel.Size = new System.Drawing.Size(38, 13);
            this.petNameObjectLabel.TabIndex = 0;
            this.petNameObjectLabel.Text = "Name:";
            // 
            // petAgeObjectLabel
            // 
            this.petAgeObjectLabel.AutoSize = true;
            this.petAgeObjectLabel.Location = new System.Drawing.Point(28, 77);
            this.petAgeObjectLabel.Name = "petAgeObjectLabel";
            this.petAgeObjectLabel.Size = new System.Drawing.Size(29, 13);
            this.petAgeObjectLabel.TabIndex = 1;
            this.petAgeObjectLabel.Text = "Age:";
            // 
            // petTypeObjectLabel
            // 
            this.petTypeObjectLabel.AutoSize = true;
            this.petTypeObjectLabel.Location = new System.Drawing.Point(23, 51);
            this.petTypeObjectLabel.Name = "petTypeObjectLabel";
            this.petTypeObjectLabel.Size = new System.Drawing.Size(34, 13);
            this.petTypeObjectLabel.TabIndex = 2;
            this.petTypeObjectLabel.Text = "Type:";
            // 
            // petNameText
            // 
            this.petNameText.AutoSize = true;
            this.petNameText.BackColor = System.Drawing.SystemColors.Control;
            this.petNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petNameText.Location = new System.Drawing.Point(67, 25);
            this.petNameText.MinimumSize = new System.Drawing.Size(100, 0);
            this.petNameText.Name = "petNameText";
            this.petNameText.Size = new System.Drawing.Size(100, 15);
            this.petNameText.TabIndex = 3;
            // 
            // petAgeText
            // 
            this.petAgeText.AutoSize = true;
            this.petAgeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petAgeText.Location = new System.Drawing.Point(66, 77);
            this.petAgeText.MinimumSize = new System.Drawing.Size(100, 0);
            this.petAgeText.Name = "petAgeText";
            this.petAgeText.Size = new System.Drawing.Size(100, 15);
            this.petAgeText.TabIndex = 4;
            // 
            // petTypeText
            // 
            this.petTypeText.AutoSize = true;
            this.petTypeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petTypeText.Location = new System.Drawing.Point(67, 51);
            this.petTypeText.MinimumSize = new System.Drawing.Size(100, 0);
            this.petTypeText.Name = "petTypeText";
            this.petTypeText.Size = new System.Drawing.Size(100, 15);
            this.petTypeText.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 303);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.entryBox);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Pet Class";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.entryBox.ResumeLayout(false);
            this.entryBox.PerformLayout();
            this.displayBox.ResumeLayout(false);
            this.displayBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label petNameLabel;
        private System.Windows.Forms.Label petTypeLabel;
        private System.Windows.Forms.Label petAgeLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.TextBox petNameTextBox;
        private System.Windows.Forms.TextBox petTypeTextBox;
        private System.Windows.Forms.TextBox petAgeTextBox;
        private System.Windows.Forms.GroupBox entryBox;
        private System.Windows.Forms.GroupBox displayBox;
        private System.Windows.Forms.Label petNameText;
        private System.Windows.Forms.Label petTypeObjectLabel;
        private System.Windows.Forms.Label petAgeObjectLabel;
        private System.Windows.Forms.Label petNameObjectLabel;
        private System.Windows.Forms.Label petTypeText;
        private System.Windows.Forms.Label petAgeText;
    }
}

