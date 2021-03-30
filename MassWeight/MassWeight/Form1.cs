/*
 * 3/23/2021
 * CSC 153
 * Branden Alder
 * Program that takes mass of an object and displays weight in newtons 
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
using WeightCalculatorLibrary;

namespace MassWeight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e) // Parses mass entered, calculates weight and puts it into the weight text box
        {
            double weight;
            weight = TryParse.ParseDouble(massTextBox.Text);
            Calculate.CalculateWeight(ref weight);
            weightText.Text = weight.ToString() + " newtons";
            Messages.HeavyOrLight(weight);
        }

        private void clearButton_Click(object sender, EventArgs e) // Clears text
        {
            massTextBox.Text = "";
            weightText.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e) // Closes application
        {
            this.Close();
        }
    }
}
