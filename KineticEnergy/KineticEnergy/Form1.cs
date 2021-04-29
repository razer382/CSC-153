/*
 * 4/28/2021
 * CSC 153
 * Branden Alder
 * Program taking mass and velocity and calculating kinetic energy 
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
using KineticEnergyLibrary;

namespace KineticEnergy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e) // Gets mass and velocity from text boxes, gets kinetic energy then puts in text label
        {
            double mass = TryParse.ParseDouble(massTextBox.Text);
            double velocity = TryParse.ParseDouble(velocityTextBox.Text);
            kineticEnergyText.Text = Calculations.GetKineticEnergy(mass, velocity).ToString();
        }

        private void exitButton_Click(object sender, EventArgs e) // closes application
        {
            this.Close();
        }
    }
}
