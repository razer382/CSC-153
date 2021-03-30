/*
 * 3/30/2021
 * CSC 153
 * Branden Alder
 * Program that converts 0-20C to F and displays in list box control
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CelsiusToFahrenheitLibrary;

namespace CelsiusFahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e) // Closes app
        {
            this.Close();
        }

        private void displayButton_Click(object sender, EventArgs e) // Calls DisplayConversion method from display class
        {
                Display.DisplayConversion(convertedListBox);
        }
    }
}
