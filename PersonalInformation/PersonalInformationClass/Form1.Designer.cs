
namespace PersonalInformationClass
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
            this.myGroupBox = new System.Windows.Forms.GroupBox();
            this.secondGroupBox = new System.Windows.Forms.GroupBox();
            this.thirdGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.myNameLabel = new System.Windows.Forms.Label();
            this.myNumberLabel = new System.Windows.Forms.Label();
            this.myAgeLabel = new System.Windows.Forms.Label();
            this.myAddressLabel = new System.Windows.Forms.Label();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.secondAddressLabel = new System.Windows.Forms.Label();
            this.secondAgeLabel = new System.Windows.Forms.Label();
            this.secondNumberLabel = new System.Windows.Forms.Label();
            this.thirdNameLabel = new System.Windows.Forms.Label();
            this.thirdAddressLabel = new System.Windows.Forms.Label();
            this.thirdAgeLabel = new System.Windows.Forms.Label();
            this.thirdNumberLabel = new System.Windows.Forms.Label();
            this.myNameText = new System.Windows.Forms.Label();
            this.myAddressText = new System.Windows.Forms.Label();
            this.myAgeText = new System.Windows.Forms.Label();
            this.myNumberText = new System.Windows.Forms.Label();
            this.secondNameText = new System.Windows.Forms.Label();
            this.secondAddressText = new System.Windows.Forms.Label();
            this.secondAgeText = new System.Windows.Forms.Label();
            this.secondNumberText = new System.Windows.Forms.Label();
            this.thirdNameText = new System.Windows.Forms.Label();
            this.thirdAddressText = new System.Windows.Forms.Label();
            this.thirdAgeText = new System.Windows.Forms.Label();
            this.thirdNumberText = new System.Windows.Forms.Label();
            this.myGroupBox.SuspendLayout();
            this.secondGroupBox.SuspendLayout();
            this.thirdGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // myGroupBox
            // 
            this.myGroupBox.Controls.Add(this.myNumberText);
            this.myGroupBox.Controls.Add(this.myAgeText);
            this.myGroupBox.Controls.Add(this.myAddressText);
            this.myGroupBox.Controls.Add(this.myNameText);
            this.myGroupBox.Controls.Add(this.myAddressLabel);
            this.myGroupBox.Controls.Add(this.myAgeLabel);
            this.myGroupBox.Controls.Add(this.myNumberLabel);
            this.myGroupBox.Controls.Add(this.myNameLabel);
            this.myGroupBox.Location = new System.Drawing.Point(12, 13);
            this.myGroupBox.Name = "myGroupBox";
            this.myGroupBox.Size = new System.Drawing.Size(198, 100);
            this.myGroupBox.TabIndex = 0;
            this.myGroupBox.TabStop = false;
            this.myGroupBox.Text = "My Object";
            // 
            // secondGroupBox
            // 
            this.secondGroupBox.Controls.Add(this.secondAddressLabel);
            this.secondGroupBox.Controls.Add(this.secondAgeLabel);
            this.secondGroupBox.Controls.Add(this.secondNumberLabel);
            this.secondGroupBox.Controls.Add(this.secondNumberText);
            this.secondGroupBox.Controls.Add(this.secondAgeText);
            this.secondGroupBox.Controls.Add(this.secondAddressText);
            this.secondGroupBox.Controls.Add(this.secondNameText);
            this.secondGroupBox.Controls.Add(this.secondNameLabel);
            this.secondGroupBox.Location = new System.Drawing.Point(13, 119);
            this.secondGroupBox.Name = "secondGroupBox";
            this.secondGroupBox.Size = new System.Drawing.Size(197, 109);
            this.secondGroupBox.TabIndex = 0;
            this.secondGroupBox.TabStop = false;
            this.secondGroupBox.Text = "Second Object";
            // 
            // thirdGroupBox
            // 
            this.thirdGroupBox.Controls.Add(this.thirdAddressLabel);
            this.thirdGroupBox.Controls.Add(this.thirdAgeLabel);
            this.thirdGroupBox.Controls.Add(this.thirdNumberLabel);
            this.thirdGroupBox.Controls.Add(this.thirdNumberText);
            this.thirdGroupBox.Controls.Add(this.thirdAgeText);
            this.thirdGroupBox.Controls.Add(this.thirdAddressText);
            this.thirdGroupBox.Controls.Add(this.thirdNameText);
            this.thirdGroupBox.Controls.Add(this.thirdNameLabel);
            this.thirdGroupBox.Location = new System.Drawing.Point(12, 234);
            this.thirdGroupBox.Name = "thirdGroupBox";
            this.thirdGroupBox.Size = new System.Drawing.Size(198, 106);
            this.thirdGroupBox.TabIndex = 0;
            this.thirdGroupBox.TabStop = false;
            this.thirdGroupBox.Text = "Third Object";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(143, 346);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(67, 38);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // myNameLabel
            // 
            this.myNameLabel.AutoSize = true;
            this.myNameLabel.Location = new System.Drawing.Point(8, 20);
            this.myNameLabel.Name = "myNameLabel";
            this.myNameLabel.Size = new System.Drawing.Size(38, 13);
            this.myNameLabel.TabIndex = 0;
            this.myNameLabel.Text = "Name:";
            // 
            // myNumberLabel
            // 
            this.myNumberLabel.AutoSize = true;
            this.myNumberLabel.Location = new System.Drawing.Point(-2, 76);
            this.myNumberLabel.Name = "myNumberLabel";
            this.myNumberLabel.Size = new System.Drawing.Size(51, 13);
            this.myNumberLabel.TabIndex = 0;
            this.myNumberLabel.Text = "Phone #:";
            // 
            // myAgeLabel
            // 
            this.myAgeLabel.AutoSize = true;
            this.myAgeLabel.Location = new System.Drawing.Point(17, 56);
            this.myAgeLabel.Name = "myAgeLabel";
            this.myAgeLabel.Size = new System.Drawing.Size(29, 13);
            this.myAgeLabel.TabIndex = 0;
            this.myAgeLabel.Text = "Age:";
            // 
            // myAddressLabel
            // 
            this.myAddressLabel.AutoSize = true;
            this.myAddressLabel.Location = new System.Drawing.Point(-2, 39);
            this.myAddressLabel.Name = "myAddressLabel";
            this.myAddressLabel.Size = new System.Drawing.Size(48, 13);
            this.myAddressLabel.TabIndex = 0;
            this.myAddressLabel.Text = "Address:";
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Location = new System.Drawing.Point(7, 16);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(38, 13);
            this.secondNameLabel.TabIndex = 0;
            this.secondNameLabel.Text = "Name:";
            // 
            // secondAddressLabel
            // 
            this.secondAddressLabel.AutoSize = true;
            this.secondAddressLabel.Location = new System.Drawing.Point(-1, 39);
            this.secondAddressLabel.Name = "secondAddressLabel";
            this.secondAddressLabel.Size = new System.Drawing.Size(48, 13);
            this.secondAddressLabel.TabIndex = 0;
            this.secondAddressLabel.Text = "Address:";
            // 
            // secondAgeLabel
            // 
            this.secondAgeLabel.AutoSize = true;
            this.secondAgeLabel.Location = new System.Drawing.Point(16, 64);
            this.secondAgeLabel.Name = "secondAgeLabel";
            this.secondAgeLabel.Size = new System.Drawing.Size(29, 13);
            this.secondAgeLabel.TabIndex = 0;
            this.secondAgeLabel.Text = "Age:";
            // 
            // secondNumberLabel
            // 
            this.secondNumberLabel.AutoSize = true;
            this.secondNumberLabel.Location = new System.Drawing.Point(-4, 84);
            this.secondNumberLabel.Name = "secondNumberLabel";
            this.secondNumberLabel.Size = new System.Drawing.Size(51, 13);
            this.secondNumberLabel.TabIndex = 0;
            this.secondNumberLabel.Text = "Phone #:";
            // 
            // thirdNameLabel
            // 
            this.thirdNameLabel.AutoSize = true;
            this.thirdNameLabel.Location = new System.Drawing.Point(7, 16);
            this.thirdNameLabel.Name = "thirdNameLabel";
            this.thirdNameLabel.Size = new System.Drawing.Size(38, 13);
            this.thirdNameLabel.TabIndex = 0;
            this.thirdNameLabel.Text = "Name:";
            // 
            // thirdAddressLabel
            // 
            this.thirdAddressLabel.AutoSize = true;
            this.thirdAddressLabel.Location = new System.Drawing.Point(0, 39);
            this.thirdAddressLabel.Name = "thirdAddressLabel";
            this.thirdAddressLabel.Size = new System.Drawing.Size(48, 13);
            this.thirdAddressLabel.TabIndex = 0;
            this.thirdAddressLabel.Text = "Address:";
            // 
            // thirdAgeLabel
            // 
            this.thirdAgeLabel.AutoSize = true;
            this.thirdAgeLabel.Location = new System.Drawing.Point(16, 62);
            this.thirdAgeLabel.Name = "thirdAgeLabel";
            this.thirdAgeLabel.Size = new System.Drawing.Size(29, 13);
            this.thirdAgeLabel.TabIndex = 0;
            this.thirdAgeLabel.Text = "Age:";
            // 
            // thirdNumberLabel
            // 
            this.thirdNumberLabel.AutoSize = true;
            this.thirdNumberLabel.Location = new System.Drawing.Point(-4, 84);
            this.thirdNumberLabel.Name = "thirdNumberLabel";
            this.thirdNumberLabel.Size = new System.Drawing.Size(51, 13);
            this.thirdNumberLabel.TabIndex = 0;
            this.thirdNumberLabel.Text = "Phone #:";
            // 
            // myNameText
            // 
            this.myNameText.AutoSize = true;
            this.myNameText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.myNameText.Location = new System.Drawing.Point(53, 20);
            this.myNameText.MinimumSize = new System.Drawing.Size(120, 0);
            this.myNameText.Name = "myNameText";
            this.myNameText.Size = new System.Drawing.Size(120, 13);
            this.myNameText.TabIndex = 1;
            // 
            // myAddressText
            // 
            this.myAddressText.AutoSize = true;
            this.myAddressText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.myAddressText.Location = new System.Drawing.Point(52, 39);
            this.myAddressText.MinimumSize = new System.Drawing.Size(120, 0);
            this.myAddressText.Name = "myAddressText";
            this.myAddressText.Size = new System.Drawing.Size(120, 13);
            this.myAddressText.TabIndex = 1;
            // 
            // myAgeText
            // 
            this.myAgeText.AutoSize = true;
            this.myAgeText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.myAgeText.Location = new System.Drawing.Point(52, 56);
            this.myAgeText.MinimumSize = new System.Drawing.Size(120, 0);
            this.myAgeText.Name = "myAgeText";
            this.myAgeText.Size = new System.Drawing.Size(120, 13);
            this.myAgeText.TabIndex = 1;
            // 
            // myNumberText
            // 
            this.myNumberText.AutoSize = true;
            this.myNumberText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.myNumberText.Location = new System.Drawing.Point(52, 76);
            this.myNumberText.MinimumSize = new System.Drawing.Size(120, 0);
            this.myNumberText.Name = "myNumberText";
            this.myNumberText.Size = new System.Drawing.Size(120, 13);
            this.myNumberText.TabIndex = 1;
            // 
            // secondNameText
            // 
            this.secondNameText.AutoSize = true;
            this.secondNameText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.secondNameText.Location = new System.Drawing.Point(51, 16);
            this.secondNameText.MinimumSize = new System.Drawing.Size(120, 0);
            this.secondNameText.Name = "secondNameText";
            this.secondNameText.Size = new System.Drawing.Size(120, 13);
            this.secondNameText.TabIndex = 1;
            // 
            // secondAddressText
            // 
            this.secondAddressText.AutoSize = true;
            this.secondAddressText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.secondAddressText.Location = new System.Drawing.Point(51, 39);
            this.secondAddressText.MinimumSize = new System.Drawing.Size(120, 0);
            this.secondAddressText.Name = "secondAddressText";
            this.secondAddressText.Size = new System.Drawing.Size(120, 13);
            this.secondAddressText.TabIndex = 1;
            // 
            // secondAgeText
            // 
            this.secondAgeText.AutoSize = true;
            this.secondAgeText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.secondAgeText.Location = new System.Drawing.Point(51, 64);
            this.secondAgeText.MinimumSize = new System.Drawing.Size(120, 0);
            this.secondAgeText.Name = "secondAgeText";
            this.secondAgeText.Size = new System.Drawing.Size(120, 13);
            this.secondAgeText.TabIndex = 1;
            // 
            // secondNumberText
            // 
            this.secondNumberText.AutoSize = true;
            this.secondNumberText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.secondNumberText.Location = new System.Drawing.Point(51, 84);
            this.secondNumberText.MinimumSize = new System.Drawing.Size(120, 0);
            this.secondNumberText.Name = "secondNumberText";
            this.secondNumberText.Size = new System.Drawing.Size(120, 13);
            this.secondNumberText.TabIndex = 1;
            // 
            // thirdNameText
            // 
            this.thirdNameText.AutoSize = true;
            this.thirdNameText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.thirdNameText.Location = new System.Drawing.Point(51, 16);
            this.thirdNameText.MinimumSize = new System.Drawing.Size(120, 0);
            this.thirdNameText.Name = "thirdNameText";
            this.thirdNameText.Size = new System.Drawing.Size(120, 13);
            this.thirdNameText.TabIndex = 1;
            // 
            // thirdAddressText
            // 
            this.thirdAddressText.AutoSize = true;
            this.thirdAddressText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.thirdAddressText.Location = new System.Drawing.Point(51, 39);
            this.thirdAddressText.MinimumSize = new System.Drawing.Size(120, 0);
            this.thirdAddressText.Name = "thirdAddressText";
            this.thirdAddressText.Size = new System.Drawing.Size(120, 13);
            this.thirdAddressText.TabIndex = 1;
            // 
            // thirdAgeText
            // 
            this.thirdAgeText.AutoSize = true;
            this.thirdAgeText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.thirdAgeText.Location = new System.Drawing.Point(51, 62);
            this.thirdAgeText.MinimumSize = new System.Drawing.Size(120, 0);
            this.thirdAgeText.Name = "thirdAgeText";
            this.thirdAgeText.Size = new System.Drawing.Size(120, 13);
            this.thirdAgeText.TabIndex = 1;
            // 
            // thirdNumberText
            // 
            this.thirdNumberText.AutoSize = true;
            this.thirdNumberText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.thirdNumberText.Location = new System.Drawing.Point(51, 84);
            this.thirdNumberText.MinimumSize = new System.Drawing.Size(120, 0);
            this.thirdNumberText.Name = "thirdNumberText";
            this.thirdNumberText.Size = new System.Drawing.Size(120, 13);
            this.thirdNumberText.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 400);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.thirdGroupBox);
            this.Controls.Add(this.secondGroupBox);
            this.Controls.Add(this.myGroupBox);
            this.Name = "Form1";
            this.Text = "Personal Info Class";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.myGroupBox.ResumeLayout(false);
            this.myGroupBox.PerformLayout();
            this.secondGroupBox.ResumeLayout(false);
            this.secondGroupBox.PerformLayout();
            this.thirdGroupBox.ResumeLayout(false);
            this.thirdGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox myGroupBox;
        private System.Windows.Forms.GroupBox secondGroupBox;
        private System.Windows.Forms.GroupBox thirdGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label myAddressLabel;
        private System.Windows.Forms.Label myAgeLabel;
        private System.Windows.Forms.Label myNumberLabel;
        private System.Windows.Forms.Label myNameLabel;
        private System.Windows.Forms.Label secondAddressLabel;
        private System.Windows.Forms.Label secondAgeLabel;
        private System.Windows.Forms.Label secondNumberLabel;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.Label thirdAddressLabel;
        private System.Windows.Forms.Label thirdAgeLabel;
        private System.Windows.Forms.Label thirdNumberLabel;
        private System.Windows.Forms.Label thirdNameLabel;
        private System.Windows.Forms.Label myAgeText;
        private System.Windows.Forms.Label myAddressText;
        private System.Windows.Forms.Label myNameText;
        private System.Windows.Forms.Label myNumberText;
        private System.Windows.Forms.Label secondNumberText;
        private System.Windows.Forms.Label secondAgeText;
        private System.Windows.Forms.Label secondAddressText;
        private System.Windows.Forms.Label secondNameText;
        private System.Windows.Forms.Label thirdNumberText;
        private System.Windows.Forms.Label thirdAgeText;
        private System.Windows.Forms.Label thirdAddressText;
        private System.Windows.Forms.Label thirdNameText;
    }
}

