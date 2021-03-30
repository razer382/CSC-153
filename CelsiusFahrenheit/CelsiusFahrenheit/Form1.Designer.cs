
namespace CelsiusFahrenheit
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
            this.convertedListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // convertedListBox
            // 
            this.convertedListBox.FormattingEnabled = true;
            this.convertedListBox.Location = new System.Drawing.Point(13, 13);
            this.convertedListBox.Name = "convertedListBox";
            this.convertedListBox.Size = new System.Drawing.Size(137, 316);
            this.convertedListBox.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(80, 358);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(70, 40);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(13, 358);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(61, 40);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "Display C to F";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 428);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertedListBox);
            this.Name = "Form1";
            this.Text = "Celsius to Fahrenheit";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.ListBox convertedListBox;
    }
}

