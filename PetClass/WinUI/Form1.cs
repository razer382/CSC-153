/*
 * 3/4/2021
 * CSC 153
 * Branden Alder
 * Creates pet object based on input and displays to user
 */

using MyClassLibrary;
using System;
using System.Windows.Forms;

namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void petTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes application
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            petNameTextBox.Text = "";  // Clears Text Boxes and labels
            petTypeTextBox.Text = "";
            petAgeTextBox.Text = "";
            petNameText.Text = "";
            petTypeText.Text = "";
            petAgeText.Text = "";
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();            //Makes pet Object, calls GetPetInfo then places in labels
            GetPetInfo(pet);
            petNameText.Text = pet.PetName;
            petTypeText.Text = pet.PetType;
            petAgeText.Text = pet.PetAge;
        }

        private void GetPetInfo(Pet pet)
        {
            pet.PetName = petNameTextBox.Text;   //Stores data put into text boxes into pet object
            pet.PetType = petTypeTextBox.Text;
            pet.PetAge = petAgeTextBox.Text;
        }
    }
}
