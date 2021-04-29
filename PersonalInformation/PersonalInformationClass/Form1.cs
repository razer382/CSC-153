/*
 * 4/29/2021
 * CSC 153
 * Branden Alder
 * Program making three objects of peoples info and displaying to screen
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
using PersonalInfoLibrary;

namespace PersonalInformationClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e) // Creates objects on load and displays to textboxes
        {
            PersonalInformation one = new PersonalInformation("Branden", "676 Broad St.", 26, "319-666-6969");
            PersonalInformation two = new PersonalInformation("Josh", "555 Toad Ave.", 29, "910-222-6767");
            PersonalInformation three = new PersonalInformation("Tom", "22 Duh St.", 27, "990-282-2828");

            myNameText.Text = one.Name;
            myAddressText.Text = one.Address;
            myAgeText.Text = one.Age.ToString();
            myNumberText.Text = one.Number;

            secondNameText.Text = two.Name;
            secondAddressText.Text = two.Address;
            secondAgeText.Text = two.Age.ToString();
            secondNumberText.Text = two.Number;

            thirdNameText.Text = three.Name;
            thirdAddressText.Text = three.Address;
            thirdAgeText.Text = three.Age.ToString();
            thirdNumberText.Text = three.Number;
        }

        private void exitButton_Click(object sender, EventArgs e) // Closes application
        {
            this.Close();
        }
    }
}
